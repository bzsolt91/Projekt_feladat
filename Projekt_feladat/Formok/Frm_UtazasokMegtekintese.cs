using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using System.Data;
using System.Collections.Generic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Projekt_feladat.Formok
{
    public partial class Frm_UtazasokMegtekintese : Form
    {
        string constr;
        ToolTip? egyeniTooltip = new ToolTip();
        string? utazasDesztinacio = null;
        string? utazasIdoszak = null;
        string? utazasNeve = null;
        public Frm_UtazasokMegtekintese()
        {
            InitializeComponent();
            egyeniTooltip.OwnerDraw = true;
            dgv_utazasok.ShowCellToolTips = false;
            egyeniTooltip.Draw += EgyeniTooltip_Draw;
            egyeniTooltip.Popup += EgyeniTooltip_Popup;
            this.AutoScaleMode = AutoScaleMode.None;
            constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "utazast_kezelo");


        }
        private void vizualisrendezes()
        {
            form_elrendezes();

            this.Controls.Add(rcb_idoszak);
            this.Controls.Add(rcb_desztinacio);
            this.Controls.Add(rcb_utazasNeve);
           

        }

        private void form_elrendezes()
        {
            int spacing = 100;

            int formWidth = this.Width;
            int totalWidth = 3 * rcb_idoszak.Width + 2 * spacing;
            int startX = (formWidth - totalWidth) / 2;
            int y = 10;
            // === DataGridView pozicionálása alá ===
            dgv_utazasok.Location = new Point(10, rcb_idoszak.Bounds.Bottom);
            dgv_utazasok.Size = new Size(this.Width - 20, this.Height  - pnl_vezerlok.Height - rcb_idoszak.Height-15);
            dgv_utazasok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(dgv_utazasok);
        }

        private void MeretezdCellakAlapjan(DataGridView dgv)

        {

            using (Graphics g = dgv.CreateGraphics())
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    int maxWidth = 0;

                    // Mérjük meg a cellák szövegét
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow && row.Cells[col.Index].Value != null)
                        {
                            string cellaSzoveg = row.Cells[col.Index].Value.ToString();
                            SizeF cellaMeret = g.MeasureString(cellaSzoveg, dgv.DefaultCellStyle.Font);
                            int cellaSzelesseg = (int)Math.Ceiling(cellaMeret.Width);
                            if (cellaSzelesseg > maxWidth)
                                maxWidth = cellaSzelesseg;
                        }
                    }

                    // Mérjük meg a fejléc szövegét a fejléc fontjával
                    string fejlecSzoveg = col.HeaderText;
                    Font fejlecFont = col.HeaderCell.Style.Font ?? dgv.ColumnHeadersDefaultCellStyle.Font ?? dgv.Font;
                    SizeF fejlecMeret = g.MeasureString(fejlecSzoveg, fejlecFont);
                    int fejlecSzelesseg = (int)Math.Ceiling(fejlecMeret.Width);

                    // A kettő közül a nagyobb, + némi margó
                    col.Width = Math.Max(maxWidth, fejlecSzelesseg) + 20;
                }
            }
        }
        private void roundedComboBox1_Load(object sender, EventArgs e)
        {
            using (var mc_mysqlcon = new MySqlConnection(constr))
            {
                var utazasIdopontok = new List<string>();
                string sql = "SELECT DISTINCT utazas_ideje FROM utazas";

                using (var cmd = new MySqlCommand(sql, mc_mysqlcon))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            // Dátum formázása stringgé (ha szükséges)
                            DateTime datum = Convert.ToDateTime(row["utazas_ideje"]);
                            utazasIdopontok.Add(datum.ToString("yyyy-MM-dd"));
                        }
                    }
                }

                // Feltételezzük, hogy a custom combo box egy string tömböt fogad el
                rcb_idoszak.adatForras = utazasIdopontok.ToArray();
                    
            }

            rcb_idoszak.ElemKivalasztva += (s, e) =>
            {
                
                if(e.Ertek !=null)
                        utazasIdoszak = e.Ertek;

                if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                    lekerdezes_kivalasztva();
            };
        }

        private void lekerdezes_kivalasztva()
        {
            using (var mc_mysqlcon = new MySqlConnection(constr))
            {
                var dt = new DataTable();
                String sql = @" SELECT
                                u.utas_id AS 'Sorszám',
                                u.titulus AS 'Titulus',
                                u.vezeteknev AS 'Vezetéknév',
                                u.keresztnev1 AS 'Keresztnév',
                                u.keresztnev2 AS 'Második keresztnév',
                                telefon.telefon AS 'Telefonszám', -- Feltételezve, hogy az utas_id egyedi a telefon, cim, fizetes, szemelyi, megjegyzes táblákban is, különben GROUP BY kellhet!
                                szemelyi.szemelyi_vagy_utlevel AS 'Okmány',
                                szemelyi.okmany_lejarat AS 'Érvényesség',
                                cim.lakcim AS 'Lakcím',
                                cim.email_cim AS 'Email',
                                fizetes.befizetett_osszeg AS 'Befizetett összeg',
                                fizetes.biztositas AS 'Biztosítás van',
                                megjegyzes.megjegyzes AS 'Megjegyzés'
                            FROM
                                utas AS u
                            INNER JOIN
                                utas_utazasai AS uu ON u.utas_id = uu.utas_id
                            INNER JOIN
                                utazas AS t ON uu.utazas_id = t.utazas_id -- Itt kapcsoljuk az utazás táblát az utas_utazasai táblán keresztül. Az alias 't'
                            LEFT JOIN -- LEFT JOIN-t használok, hogy akkor is megjelenjen az utas, ha nincs telefon, cím stb. Ha mindenképp kell, akkor INNER JOIN marad
                                telefon ON u.utas_id = telefon.utas_id
                            LEFT JOIN
                                cim ON u.utas_id = cim.utas_id
                            LEFT JOIN
                                fizetes ON u.utas_id = fizetes.utas_id
                            LEFT JOIN
                                szemelyi ON u.utas_id = szemelyi.utas_id
                            LEFT JOIN
                                megjegyzes ON u.utas_id = megjegyzes.utas_id
                            WHERE
                                t.utazas_ideje = @utazasideje
                                AND t.desztinacio = @desztinacio
                                AND t.utazas_elnevezese = @utazasneve";

                var cmd = new MySqlCommand(sql, mc_mysqlcon);
                cmd.Parameters.AddWithValue("@utazasideje",utazasIdoszak);
                cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                cmd.Parameters.AddWithValue("@utazasneve", utazasNeve);
                //      cmd.Parameters.AddWithValue("@utazasideje", e.Ertek);

                var da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_utazasok.DataSource = dt;
            }
        }



        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dgv_utazasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv_utazasok.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgv_utazasok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_utazasok.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn col in dgv_utazasok.Columns)
            {
                col.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                col.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
            MeretezdCellakAlapjan(dgv_utazasok);
        }

        private void roundedComboBox2_Load(object sender, EventArgs e)
        {

            using (var mc_mysqlcon = new MySqlConnection(constr))
            {
                mc_mysqlcon.Open();
                var utazasIdopontok = new List<string>();
                string sql = "SELECT DISTINCT desztinacio FROM utazas";

                using (var cmd = new MySqlCommand(sql, mc_mysqlcon))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {


                            utazasIdopontok.Add(row["desztinacio"].ToString());
                        }
                    }
                }

                // Feltételezzük, hogy a custom combo box egy string tömböt fogad el
                rcb_desztinacio.adatForras = utazasIdopontok.ToArray();

            }
            rcb_desztinacio.ElemKivalasztva += (s, e) =>
            {

                if (e.Ertek != null)
                    utazasDesztinacio = e.Ertek;

                if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                    lekerdezes_kivalasztva();
            };
        }

        private void roundedComboBox3_Load(object sender, EventArgs e)
        {
            using (var mc_mysqlcon = new MySqlConnection(constr))
            {
                mc_mysqlcon.Open();
                var elnevezesek = new List<string>();
                string sql = "SELECT DISTINCT utazas_elnevezese FROM utazas";

                using (var cmd = new MySqlCommand(sql, mc_mysqlcon))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {


                            elnevezesek.Add(row["utazas_elnevezese"].ToString());
                        }
                    }
                }

                // Feltételezzük, hogy a custom combo box egy string tömböt fogad el
                rcb_utazasNeve.adatForras = elnevezesek.ToArray();

            }
            rcb_utazasNeve.ElemKivalasztva += (s, e) =>
            {

                if (e.Ertek != null)
                    utazasNeve = e.Ertek;

                if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                    lekerdezes_kivalasztva();
            };
        }


        private void Frm_UtazasokMegtekintese_Resize(object sender, EventArgs e)
        {
            form_elrendezes();
        }
        private void EgyeniTooltip_Popup(object sender, PopupEventArgs e)
        {
            Font font = new Font("Segoe UI", 18);

            // Itt a 'sender' a ToolTip objektum, tehát le tudjuk kérni belőle a szöveget
            ToolTip tooltip = (ToolTip)sender;
            string szoveg = tooltip.GetToolTip(e.AssociatedControl);

            Size meret = TextRenderer.MeasureText(szoveg, font, new Size(1000, 0), TextFormatFlags.WordBreak);
            e.ToolTipSize = new Size(meret.Width + 10, meret.Height + 10);
        }

        private void EgyeniTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font font = new Font("Segoe UI", 14);
            using (LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.BlueViolet, Color.BlueViolet, 90f))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            e.Graphics.DrawRectangle(Pens.DarkViolet, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
            TextRenderer.DrawText(e.Graphics, e.ToolTipText, font, e.Bounds, Color.White, TextFormatFlags.WordBreak);

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cella = dgv_utazasok[e.ColumnIndex, e.RowIndex];
                if (cella.Value != null)
                {
                    string szoveg = cella.Value.ToString();

                    egyeniTooltip.OwnerDraw = true; // saját rajzolás engedélyezése
                    egyeniTooltip.Draw += EgyeniTooltip_Draw;
                    egyeniTooltip.Popup += EgyeniTooltip_Popup;

                    Point kurzor = Cursor.Position;
                    Point formPozicio = this.PointToClient(kurzor);

                    egyeniTooltip.Show(szoveg, this, formPozicio.X + 10, formPozicio.Y + 20, 3000);
                }
            }
        }

        private void dgv_utazasok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            btn_mentes.HatterSzine = Color.Red;
         
        }
    }
}
