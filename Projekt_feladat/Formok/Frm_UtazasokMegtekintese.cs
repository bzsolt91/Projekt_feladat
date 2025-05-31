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
        ToolTip egyeniTooltip = new ToolTip();
        public Frm_UtazasokMegtekintese()
        {
            InitializeComponent();
            egyeniTooltip.OwnerDraw = true;
            dataGridView1.ShowCellToolTips = false;
            egyeniTooltip.Draw += EgyeniTooltip_Draw;
            egyeniTooltip.Popup += EgyeniTooltip_Popup;
            this.AutoScaleMode = AutoScaleMode.None;
            constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "utazast_kezelo");
          

        }
        private void vizualisrendezes()
        {
            form_elrendezes();

            this.Controls.Add(roundedComboBox1);
            this.Controls.Add(roundedComboBox2);
            this.Controls.Add(roundedComboBox3);
        }

        private void form_elrendezes()
        {
            int spacing = 100;

            int formWidth = this.Width;
            int totalWidth = 3 * roundedComboBox1.Width + 2 * spacing;
            int startX = (formWidth - totalWidth) / 2;
            int y = 10;
            // === DataGridView pozicionálása alá ===
            dataGridView1.Location = new Point(10, roundedComboBox1.Location.X + roundedComboBox1.Height + 30);
            dataGridView1.Size = new Size(this.Width - 20, this.Height - (y + roundedComboBox1.Height + 25) - pnl_vezerlok.Height - 15);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(dataGridView1);
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
                string sql = "SELECT utazas_ideje FROM utazas";

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
                roundedComboBox1.adatForras = utazasIdopontok.ToArray();

            }

            roundedComboBox1.ElemKivalasztva += (s, e) =>
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();
                    String sql = @" SELECT u.utas_id AS 'Sorszám',
                                           u.titulus AS 'Titulus',
                                           u.vezeteknev AS 'Vezetéknév',
                                           u.keresztnev1 AS 'Keresztnév',
                                           u.keresztnev2 AS 'Második keresztnév',
                                           telefon.telefon AS 'Telefonszám',
                                           szemelyi.szemelyi_vagy_utlevel AS 'Okmány',
                                           szemelyi.okmany_lejarat AS 'Érvényesség',
                                           cim.lakcim AS 'Lakcím',
                                           cim.email_cim AS 'Email',
                                           fizetes.befizetett_osszeg AS 'Befizetett összeg',
                                           fizetes.biztositas AS 'Biztosítás van',
                                           megjegyzes.megjegyzes AS 'Megjegyzés'
                                    FROM utas u
                                    INNER JOIN cim ON u.utas_id = cim.utas_id
                                    INNER JOIN utazas ON u.utas_id = utazas.utas_id
                                    INNER JOIN telefon ON u.utas_id = telefon.utas_id
                                    INNER JOIN fizetes ON u.utas_id = fizetes.utas_id
                                    INNER JOIN szemelyi ON u.utas_id = szemelyi.utas_id
                                    INNER JOIN megjegyzes ON u.utas_id = megjegyzes.utas_id
                                    WHERE utazas.utazas_ideje = @utazasideje";
                    //     AND utazas.desztinacio = @desztinacio";


                    var cmd = new MySqlCommand(sql, mc_mysqlcon);
                    cmd.Parameters.AddWithValue("@utazasideje", e.Ertek);
                    //      cmd.Parameters.AddWithValue("@utazasideje", e.Ertek);

                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            };
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                col.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
            MeretezdCellakAlapjan(dataGridView1);
        }

        private void roundedComboBox2_Load(object sender, EventArgs e)
        {

            using (var mc_mysqlcon = new MySqlConnection(constr))
            {
                mc_mysqlcon.Open();
                var utazasIdopontok = new List<string>();
                string sql = "SELECT desztinacio FROM utazas";

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
                roundedComboBox2.adatForras = utazasIdopontok.ToArray();

            }
        }

        private void roundedComboBox3_Load(object sender, EventArgs e)
        {
            using (var mc_mysqlcon = new MySqlConnection(constr))
            {
                mc_mysqlcon.Open();
                var elnevezesek = new List<string>();
                string sql = "SELECT utazas_elnevezese FROM utazas";

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
                roundedComboBox3.adatForras = elnevezesek.ToArray();

            }
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
                var cella = dataGridView1[e.ColumnIndex, e.RowIndex];
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
    }
}
