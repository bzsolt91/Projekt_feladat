using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using System.Data;
using System.Collections.Generic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using static Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu;

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
            form_elrendezes();

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
            dgv_utazasok.Size = new Size(this.Width - 20, this.Height - pnl_vezerlok.Height - rcb_idoszak.Height - 15);
            dgv_utazasok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            szpn_szuroPanel.Location = new Point((this.Width / 2) - (szpn_szuroPanel.Width / 2), this.Height/2-szpn_szuroPanel.Height/2);
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
        private void rcb_desztinacio_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasDesztinacio)
                {
                    rcb_idoszak.ComboText = "Időszak";
                    rcb_utazasNeve.ComboText = "Utazás neve";
                    rcb_idoszak.adatForras = new string[0];
                    rcb_utazasNeve.adatForras = new string[0];
                    utazasIdoszak = null;
                    utazasNeve = null;
                }

                utazasDesztinacio = e.Ertek;

                // Töröljük a további két combobox tartalmát
                rcb_idoszak.adatForras = new string[0];
                rcb_utazasNeve.adatForras = new string[0];
                utazasIdoszak = null;
                utazasNeve = null;

                // Betöltjük az időszakokat az 2-es comboboxba
                idoszak_betoltes();
            }
            else
                return;


        }
        private void utazasok_betoltes()
        {
            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    var lista = new List<string>();
                    string sql = "SELECT DISTINCT desztinacio FROM utazas ORDER BY desztinacio";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(reader.GetString(0));
                        }
                    }

                    rcb_desztinacio.adatForras = lista.ToArray();
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázihoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(e.Message);
            }
        }
        private void lekerdezes_kivalasztva()
        {
            try
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
                                telefon.telefon AS 'Telefonszám', 
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
                                utazas AS t ON uu.utazas_id = t.utazas_id 
                            LEFT JOIN 
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
                    cmd.Parameters.AddWithValue("@utazasideje", utazasIdoszak);
                    cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                    cmd.Parameters.AddWithValue("@utazasneve", utazasNeve);
                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utazasok.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázihoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(e.Message);
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

        private void rcb_idoszak_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasIdoszak)
                {

                    rcb_utazasNeve.ComboText = "Utazás neve";
                    rcb_utazasNeve.adatForras = new string[0];
                    utazasNeve = null;
                }


                utazasIdoszak = e.Ertek;
                if (utazasIdoszak != null && utazasDesztinacio != null)
                    utazasneve_betoltes();
            }
            else
                return;




        }
        private void idoszak_betoltes()
        {
            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    var lista = new List<string>();
                    string sql = "SELECT DISTINCT utazas_ideje FROM utazas WHERE desztinacio = @desztinacio ORDER BY utazas_ideje";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime datum = reader.GetDateTime(0);
                                lista.Add(datum.ToString("yyyy-MM-dd"));
                            }
                        }
                    }

                    rcb_idoszak.adatForras = lista.ToArray();
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázihoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(e.Message);
            }
        }

        private void rcb_utazasNeve_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {



            if (e.Ertek != null)
                utazasNeve = e.Ertek;

            if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                lekerdezes_kivalasztva();

        }

        private void utazasneve_betoltes()
        {
            try
            {

                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    var lista = new List<string>();
                    string sql = "SELECT DISTINCT utazas_elnevezese FROM utazas WHERE desztinacio = @desztinacio AND utazas_ideje = @idoszak ORDER BY utazas_elnevezese";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                        cmd.Parameters.AddWithValue("@idoszak", DateTime.Parse(utazasIdoszak));

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(reader.GetString(0));
                            }
                        }
                    }

                    rcb_utazasNeve.adatForras = lista.ToArray();
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázihoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(e.Message);
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

        private void pnl_vezerlok_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kerekitettGomb2_Click(object sender, EventArgs e)
        {
            if (szpn_szuroPanel.Visible)
            {
                szpn_szuroPanel.Visible = false;
               
            }
            else
            {
                szpn_szuroPanel.Visible = true;
               
            }
        }

        private void kg_pipa_Click(object sender, EventArgs e)
        {
            szpn_szuroPanel.Visible = false;
            try
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();
                    var whereClauses = new List<string>();
                    var cmd = new MySqlCommand();
                    cmd.Connection = mc_mysqlcon;

                    string sql = @"SELECT
                            u.utas_id AS 'Sorszám',
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
                        FROM
                            utas AS u
                        INNER JOIN
                            utas_utazasai AS uu ON u.utas_id = uu.utas_id
                        INNER JOIN
                            utazas AS t ON uu.utazas_id = t.utazas_id 
                        LEFT JOIN 
                            telefon ON u.utas_id = telefon.utas_id
                        LEFT JOIN
                            cim ON u.utas_id = cim.utas_id
                        LEFT JOIN
                            fizetes ON u.utas_id = fizetes.utas_id
                        LEFT JOIN
                            szemelyi ON u.utas_id = szemelyi.utas_id
                        LEFT JOIN
                            megjegyzes ON u.utas_id = megjegyzes.utas_id";

                    // Szűrők hozzáadása

                    // Név szűrés (összefűzve)
                    if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts))
                    {
                        whereClauses.Add(@"(
                            u.titulus LIKE @nev 
                            OR u.vezeteknev LIKE @nev 
                            OR u.keresztnev1 LIKE @nev 
                            OR u.keresztnev2 LIKE @nev
                        )");
                        cmd.Parameters.AddWithValue("@nev", "%" + kszm_utasNeve.Texts.Trim() + "%");
                    }


                    if (!string.IsNullOrWhiteSpace(kszm_telefon.Texts))
                    {
                        whereClauses.Add("telefon.telefon LIKE @telefon");
                        cmd.Parameters.AddWithValue("@telefon", "%" + kszm_telefon.Texts + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts))
                    {
                        whereClauses.Add("szemelyi.szemelyi_vagy_utlevel LIKE @okmany");
                        cmd.Parameters.AddWithValue("@okmany", "%" + kszm_okmanySzam.Texts + "%");
                    }

                    if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                    {
                        whereClauses.Add("szemelyi.okmany_lejarat < CURDATE()");
                    }
                    else if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                    {
                        whereClauses.Add("szemelyi.okmany_lejarat >= CURDATE()");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts))
                    {
                        whereClauses.Add("cim.lakcim LIKE @lakcim");
                        cmd.Parameters.AddWithValue("@lakcim", "%" + kszm_lakcim.Texts + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_email.Texts))
                    {
                        whereClauses.Add("cim.email_cim LIKE @email");
                        cmd.Parameters.AddWithValue("@email", "%" + kszm_email.Texts + "%");
                    }

                    if (kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                    {
                        whereClauses.Add("fizetes.befizetett_osszeg = 0");
                    }
                    else if(kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                    {
                        whereClauses.Add("fizetes.befizetett_osszeg > 0");
                    }

                    if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                    {
                        whereClauses.Add("fizetes.biztositas = 'nem'");
                    }
                    else if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                    {
                        whereClauses.Add("fizetes.biztositas = 'igen'");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts))
                    {
                        whereClauses.Add("megjegyzes.megjegyzes LIKE @megjegyzes");
                        cmd.Parameters.AddWithValue("@megjegyzes", "%" + kszm_megjegyzes.Texts + "%");
                    }

                
                    if (whereClauses.Count > 0)
                    {
                        sql += " WHERE " + string.Join(" AND ", whereClauses);
                    }
                    sql += " GROUP BY u.utas_id";

                    cmd.CommandText = sql;
                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utazasok.DataSource = dt;
                    if (string.IsNullOrWhiteSpace(kszm_utasNeve.Texts) && string.IsNullOrWhiteSpace(kszm_email.Texts) && string.IsNullOrWhiteSpace(kszm_lakcim.Texts) && string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts)
                        && string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts) && string.IsNullOrWhiteSpace(kszm_telefon.Texts) && kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Ki
                        && kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Ki && kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Ki)
                        kg_szures.HatterSzine = Color.DarkKhaki;
                    else
                        kg_szures.HatterSzine = Color.AliceBlue;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(ex.Message);
            }
        }
    }
}
