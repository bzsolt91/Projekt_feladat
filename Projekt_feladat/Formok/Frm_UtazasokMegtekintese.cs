using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using System.Data;
using System.Collections.Generic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using static Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu;
using System.Drawing.Printing;
using System.Drawing;

namespace Projekt_feladat.Formok
{
    public partial class Frm_UtazasokMegtekintese : Form
    {
        ListBox lst_talalatok = new ListBox();
        string constr;
        ToolTip? egyeniTooltip = new ToolTip();
        private bool vanValtozas = false;
        string? utazasDesztinacio = null;
        string? utazasIdoszak = null;
        string? utazasNeve = null;
        private bool szuresAktiv = false;
        private int sorIndexAHolFolytatniKell = 0;
        public Frm_UtazasokMegtekintese()
        {
            InitializeComponent();
         
            dgv_utazasok.ShowCellToolTips = false;

      

            egyeniTooltip.OwnerDraw = true;
            egyeniTooltip.Draw += EgyeniTooltip_Draw;
            egyeniTooltip.Popup += EgyeniTooltip_Popup;

            this.AutoScaleMode = AutoScaleMode.None;
            form_elrendezes();

            lst_talalatok.Visible = false;
            lst_talalatok.DrawMode = DrawMode.OwnerDrawFixed;
            lst_talalatok.DrawItem += lst_talalatok_DrawItem;
            lst_talalatok.MouseDown += lst_talalatok_MouseDown;
            lst_talalatok.Width = kszm_utasNeve.Width;
            szpn_szuroPanel.Controls.Add(lst_talalatok);
             constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "utazast_kezelo", "utazast_kezelo1234", "utazast_kezelo");
        }
        private void lst_talalatok_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lst_talalatok.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                lst_talalatok.SelectedIndex = index;

                if (lst_talalatok.Tag is kerekitettSzovegMezo aktivMezo)
                {
                    aktivMezo.Texts = lst_talalatok.Items[index].ToString();
                    aktivMezo.Focus();
                }

                lst_talalatok.Visible = false;
            }
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
            szpn_szuroPanel.Location = new Point((this.Width / 2) - (szpn_szuroPanel.Width / 2), this.Height / 2 - szpn_szuroPanel.Height / 2);
            pnl_utasLista.Location = new Point((this.Width / 2) - (pnl_utasLista.Width / 2), this.Height / 2 - pnl_utasLista.Height / 2);

            lst_talalatok.Location = new Point(kszm_utasNeve.Location.X, kszm_utasNeve.Location.Y + kszm_utasNeve.Height + 10);
            this.Controls.Add(dgv_utazasok);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (egyeniTooltip != null)
            {
                egyeniTooltip.RemoveAll();  // Az összes tooltip eltávolítása
                egyeniTooltip.Dispose();    // Tooltip tényleges felszabadítása
                egyeniTooltip = null;
            }


            base.OnFormClosing(e);
        }
        private void MeretezdCellakAlapjan(DataGridView dgv)
        {
            using (Graphics g = dgv.CreateGraphics())
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    int maxWidth = 0;

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
                    string fejlecSzoveg = col.HeaderText;
                    Font fejlecFont = col.HeaderCell.Style.Font ?? dgv.ColumnHeadersDefaultCellStyle.Font ?? dgv.Font;
                    SizeF fejlecMeret = g.MeasureString(fejlecSzoveg, fejlecFont);
                    int fejlecSzelesseg = (int)Math.Ceiling(fejlecMeret.Width);
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
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            
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
        // Frm_UtazasokMegtekintese.cs

        private void lekerdezes_kivalasztva()
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();

                    string sql = @"
                SELECT
                    u.utas_id AS 'Sorszám',
                    u.titulus AS 'Titulus',
                    u.vezeteknev AS 'Vezetéknév',
                    u.keresztnev1 AS 'Keresztnév',
                    u.keresztnev2 AS 'Második keresztnév',
                    u.szuletesi_datum AS 'Születési dátum',
                    GROUP_CONCAT(DISTINCT telefon.telefon SEPARATOR ', ') AS 'Telefonszám',
                    GROUP_CONCAT(DISTINCT cim.lakcim SEPARATOR ' | ') AS 'Lakcím',
                    GROUP_CONCAT(DISTINCT cim.email_cim SEPARATOR ', ') AS 'Email',
                    GROUP_CONCAT(DISTINCT fizetes.befizetett_osszeg SEPARATOR ', ') AS 'Befizetett összeg',
                    GROUP_CONCAT(DISTINCT fizetes.biztositas SEPARATOR ', ') AS 'Biztosítás van',
                    GROUP_CONCAT(DISTINCT megjegyzes.megjegyzes SEPARATOR ' | ') AS 'Megjegyzés',
                    GROUP_CONCAT(CONCAT(t_ossz.desztinacio, ' - ', t_ossz.utazas_ideje, ' - ', t_ossz.utazas_elnevezese) SEPARATOR '\n') AS 'Utazások',
                    szemelyi.szemelyi_vagy_utlevel AS 'Okmány',
                    szemelyi.allampolgarsag AS 'Állampolgárság',
                    szemelyi.okmany_lejarat AS 'Érvényesség'
                FROM utas AS u
                INNER JOIN utas_utazasai AS uu_ossz ON u.utas_id = uu_ossz.utas_id
                INNER JOIN utazas AS t_ossz ON uu_ossz.utazas_id = t_ossz.utazas_id
                LEFT JOIN telefon ON u.utas_id = telefon.utas_id
                LEFT JOIN cim ON u.utas_id = cim.utas_id
                LEFT JOIN fizetes ON u.utas_id = fizetes.utas_id
                LEFT JOIN szemelyi ON u.utas_id = szemelyi.utas_id
                LEFT JOIN megjegyzes ON u.utas_id = megjegyzes.utas_id
                WHERE u.utas_id IN (
                    SELECT uu.utas_id
                    FROM utas_utazasai AS uu
                    INNER JOIN utazas AS t ON uu.utazas_id = t.utazas_id
                    WHERE (@utazasideje IS NULL OR t.utazas_ideje = @utazasideje)
                      AND (@desztinacio IS NULL OR t.desztinacio = @desztinacio)
                      AND (@utazasneve IS NULL OR t.utazas_elnevezese = @utazasneve)
                )
                GROUP BY 
                    u.utas_id,
                    u.titulus,
                    u.vezeteknev,
                    u.keresztnev1,
                    u.keresztnev2,
                    u.szuletesi_datum,
                    szemelyi.szemelyi_vagy_utlevel,
                    szemelyi.allampolgarsag,
                    szemelyi.okmany_lejarat
                ORDER BY u.vezeteknev, u.keresztnev1;";

                    var cmd = new MySqlCommand(sql, mc_mysqlcon);
                    cmd.Parameters.AddWithValue("@utazasideje", utazasIdoszak);
                    cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                    cmd.Parameters.AddWithValue("@utazasneve", utazasNeve);

                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utazasok.DataSource = dt;
                    dgv_utazasok.Columns[0].ReadOnly = true;
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
              

                    Point kurzor = Cursor.Position;
                    Point formPozicio = this.PointToClient(kurzor);

                    egyeniTooltip.Show(szoveg, this, formPozicio.X + 10, formPozicio.Y + 20, 3000);
                }
            }
        }

        private void dgv_utazasok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            vanValtozas = true;
            btn_mentes.HatterSzine = Color.Red;

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
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                lekerdezes_kivalasztva();
            else
            {
                szpn_szuroPanel.Visible = false;
                return;
            }

            lst_talalatok.Visible = false;
            szpn_szuroPanel.Visible = false;

            // --- Szűrők számolása ---
            int szurokSzama = 0;
            if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_email.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_telefon.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_allampolgarsag.Texts)) szurokSzama++;
            if (kb_befizetes.AktualisAllas != KapcsoloGomb.KapcsoloAllas.Ki) szurokSzama++;
            if (kb_biztositas.AktualisAllas != KapcsoloGomb.KapcsoloAllas.Ki) szurokSzama++;
            if (kb_okmanyErvenyes.AktualisAllas != KapcsoloGomb.KapcsoloAllas.Ki) szurokSzama++;
            if (klm_utazasiMod.ComboText.ToLower() != "mind" &&
                klm_utazasiMod.ComboText.ToLower() != "utazási mód")
                szurokSzama++;

            bool barmiszuroaktiv = szurokSzama > 0;

            if (barmiszuroaktiv)
            {
                kg_szures.HatterSzine = Color.Orange;
                kg_szures.ErtesitesSzam = szurokSzama;   // <-- Itt írjuk ki a darabszámot
                szuresAktiv = true;
            }
            else
            {
                kg_szures.HatterSzine = Color.MediumSlateBlue;
                kg_szures.ErtesitesSzam = 0;             // <-- Nincs szűrés → 0
                if (szuresAktiv)
                    lekerdezes_kivalasztva();
                szuresAktiv = false;
            }

            lekerdezes();
        }


        private void lekerdezes()
        {
            try
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();
                    var cmd = new MySqlCommand();
                    cmd.Connection = mc_mysqlcon;

                    string sql = @"
                SELECT
                    u.utas_id AS 'Sorszám',
                    u.titulus AS 'Titulus',
                    u.vezeteknev AS 'Vezetéknév',
                    u.keresztnev1 AS 'Keresztnév',
                    u.keresztnev2 AS 'Második keresztnév',
                    u.szuletesi_datum AS 'Születési dátum',
                    GROUP_CONCAT(DISTINCT telefon.telefon SEPARATOR ', ') AS 'Telefonszám',
                    GROUP_CONCAT(DISTINCT cim.lakcim SEPARATOR ' | ') AS 'Lakcím',
                    GROUP_CONCAT(DISTINCT cim.email_cim SEPARATOR ', ') AS 'Email',
                    GROUP_CONCAT(DISTINCT fizetes.befizetett_osszeg SEPARATOR ', ') AS 'Befizetett összeg',
                    GROUP_CONCAT(DISTINCT fizetes.biztositas SEPARATOR ', ') AS 'Biztosítás van',
                    GROUP_CONCAT(DISTINCT megjegyzes.megjegyzes SEPARATOR ' | ') AS 'Megjegyzés',
                    GROUP_CONCAT(CONCAT(t_ossz.desztinacio, ' - ', t_ossz.utazas_ideje, ' - ', t_ossz.utazas_elnevezese) SEPARATOR '\n') AS 'Utazások',
                    szemelyi.szemelyi_vagy_utlevel AS 'Okmány',
                    szemelyi.allampolgarsag AS 'Állampolgárság',
                    szemelyi.okmany_lejarat AS 'Érvényesség'
                FROM utas AS u
                INNER JOIN utas_utazasai AS uu_ossz ON u.utas_id = uu_ossz.utas_id
                INNER JOIN utazas AS t_ossz ON uu_ossz.utazas_id = t_ossz.utazas_id
                LEFT JOIN telefon ON u.utas_id = telefon.utas_id
                LEFT JOIN cim ON u.utas_id = cim.utas_id
                LEFT JOIN fizetes ON u.utas_id = fizetes.utas_id
                LEFT JOIN szemelyi ON u.utas_id = szemelyi.utas_id
                LEFT JOIN megjegyzes ON u.utas_id = megjegyzes.utas_id
                WHERE u.utas_id IN (
                    SELECT uu.utas_id
                    FROM utas_utazasai AS uu
                    INNER JOIN utazas AS t ON uu.utazas_id = t.utazas_id
                    WHERE (@utazasideje IS NULL OR t.utazas_ideje = @utazasideje)
                      AND (@desztinacio IS NULL OR t.desztinacio = @desztinacio)
                      AND (@utazasneve IS NULL OR t.utazas_elnevezese = @utazasneve)
                )";

                    List<string> feltetelek = new List<string>();

                    // --- Dinamikus szűrés (a meglévő logikád változatlan maradt) ---
                    if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts))
                    {
                        var nevReszek = kszm_utasNeve.Texts.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        int nevIndex = 0;
                        foreach (var szo in nevReszek)
                        {
                            string paramNev = "@nev" + nevIndex++;
                            feltetelek.Add($@"(
                        u.titulus LIKE {paramNev}
                        OR u.vezeteknev LIKE {paramNev}
                        OR u.keresztnev1 LIKE {paramNev}
                        OR u.keresztnev2 LIKE {paramNev}
                    )");
                            cmd.Parameters.AddWithValue(paramNev, "%" + szo + "%");
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(kszm_telefon.Texts))
                    {
                        feltetelek.Add("telefon.telefon LIKE @telefon");
                        cmd.Parameters.AddWithValue("@telefon", "%" + kszm_telefon.Texts + "%");
                    }
                    if (!string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts))
                    {
                        feltetelek.Add("szemelyi.szemelyi_vagy_utlevel LIKE @okmany");
                        cmd.Parameters.AddWithValue("@okmany", "%" + kszm_okmanySzam.Texts + "%");
                    }
                    if (!string.IsNullOrWhiteSpace(kszm_allampolgarsag.Texts))
                    {
                        feltetelek.Add("szemelyi.allampolgarsag LIKE @allamp");
                        cmd.Parameters.AddWithValue("@allamp", "%" + kszm_allampolgarsag.Texts + "%");
                    }
                    if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                        feltetelek.Add("szemelyi.okmany_lejarat < CURDATE()");
                    else if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                        feltetelek.Add("szemelyi.okmany_lejarat >= CURDATE()");

                    if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts))
                    {
                        feltetelek.Add("cim.lakcim LIKE @lakcim");
                        cmd.Parameters.AddWithValue("@lakcim", "%" + kszm_lakcim.Texts + "%");
                    }
                    if (!string.IsNullOrWhiteSpace(kszm_email.Texts))
                    {
                        feltetelek.Add("cim.email_cim LIKE @email");
                        cmd.Parameters.AddWithValue("@email", "%" + kszm_email.Texts + "%");
                    }
                    if (kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                        feltetelek.Add("fizetes.befizetett_osszeg = 0");
                    else if (kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                        feltetelek.Add("fizetes.befizetett_osszeg > 0");

                    if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                        feltetelek.Add("fizetes.biztositas = 'nem'");
                    else if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                        feltetelek.Add("fizetes.biztositas = 'igen'");

                    if (!string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts))
                    {
                        feltetelek.Add("megjegyzes.megjegyzes LIKE @megjegyzes");
                        cmd.Parameters.AddWithValue("@megjegyzes", "%" + kszm_megjegyzes.Texts + "%");
                    }

                    string mod = klm_utazasiMod.ComboText.ToLower();
                    if (mod != "mind" && mod != "utazási mód")
                    {
                        feltetelek.Add("t_ossz.utazas_modja = @kozmod");
                        cmd.Parameters.AddWithValue("@kozmod", klm_utazasiMod.ComboText);
                    }

                    cmd.Parameters.AddWithValue("@utazasideje", utazasIdoszak);
                    cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                    cmd.Parameters.AddWithValue("@utazasneve", utazasNeve);

                    if (feltetelek.Count > 0)
                        sql += " AND " + string.Join(" AND ", feltetelek);

                    sql += @"
                GROUP BY 
                    u.utas_id,
                    u.titulus,
                    u.vezeteknev,
                    u.keresztnev1,
                    u.keresztnev2,
                    u.szuletesi_datum,
                    szemelyi.szemelyi_vagy_utlevel,
                    szemelyi.allampolgarsag,
                    szemelyi.okmany_lejarat
                ORDER BY u.vezeteknev, u.keresztnev1;";

                    cmd.CommandText = sql;

                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utazasok.DataSource = dt;
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

        private void kszm_AutoComplete(object sender, EventArgs e)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            

            if (utazasDesztinacio == null && utazasIdoszak == null && utazasNeve == null)
                return;
            var aktivMezo = sender as Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo;
            if (aktivMezo == null) return;
            lst_talalatok.Tag = aktivMezo;
            lst_talalatok.Visible = true;

            lst_talalatok.Location = new Point(aktivMezo.Location.X, aktivMezo.Location.Y + aktivMezo.Height + 10);
            lst_talalatok.BringToFront();
            var lista = new List<string>();
            var nev = aktivMezo.Name;

            try
            {

                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    string sql = "";
                    var cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    switch (nev)
                    {
                        case "kszm_utasNeve":
                                sql = @"SELECT u.titulus, u.vezeteknev, u.keresztnev1, u.keresztnev2
                                FROM utas AS u
                                INNER JOIN utas_utazasai AS uu ON u.utas_id = uu.utas_id
                                INNER JOIN utazas AS t ON uu.utazas_id = t.utazas_id
                               WHERE LOWER(CONCAT_WS(' ', u.titulus, u.vezeteknev, u.keresztnev1, u.keresztnev2)) LIKE @nev
                                GROUP BY u.utas_id
                                LIMIT 4";

                            cmd.Parameters.AddWithValue("@nev", "%" + aktivMezo.Texts.Trim().ToLower() + "%");

                            cmd.Parameters.AddWithValue("@utazasideje", utazasIdoszak);
                            cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                            cmd.Parameters.AddWithValue("@utazasneve", utazasNeve);
                            break;

                        case "kszm_email":
                            sql = "SELECT DISTINCT email_cim FROM cim WHERE email_cim LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_telefon":
                            sql = "SELECT DISTINCT telefon FROM telefon WHERE telefon LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_lakcim":
                            sql = "SELECT DISTINCT lakcim FROM cim WHERE lakcim LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_okmanySzam":
                            sql = "SELECT DISTINCT szemelyi_vagy_utlevel FROM szemelyi WHERE szemelyi_vagy_utlevel LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_megjegyzes":
                            sql = "SELECT DISTINCT megjegyzes FROM megjegyzes WHERE megjegyzes LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        default:
                            return;
                    }

                    cmd.CommandText = sql;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (nev == "kszm_utasNeve")
                            {
                                string titulus = reader.IsDBNull(0) ? "" : reader.GetString(0);
                                string vezeteknev = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                string keresztnev1 = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                string keresztnev2 = reader.IsDBNull(3) ? "" : reader.GetString(3);

                                string teljesNev = $"{titulus} {vezeteknev} {keresztnev1} {keresztnev2}".Trim();
                                lista.Add(teljesNev);
                            }
                            else
                            {
                                lista.Add(reader.GetString(0));
                            }
                        }
                    }

                    lst_talalatok.DataSource = null;
                    lst_talalatok.DataSource = lista;
                }
            }
            catch (Exception xe)
            {
                if (xe.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(xe.Message);
            }
        }
       

        private void SzovegMezo_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lst_talalatok.Visible) return;

            var aktivMezo = sender as Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo;
            if (aktivMezo == null) return;

            if (e.KeyCode == Keys.Down && lst_talalatok.SelectedIndex < lst_talalatok.Items.Count - 1)
            {
                lst_talalatok.SelectedIndex++;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up && lst_talalatok.SelectedIndex > 0)
            {
                lst_talalatok.SelectedIndex--;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter && lst_talalatok.SelectedItem != null)
            {
                aktivMezo.Texts = lst_talalatok.SelectedItem.ToString();
                lst_talalatok.Visible = false;
                e.Handled = true;
            }
        }
        private void kszm_Leave(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                // Csak akkor zárjuk be a ListBox-ot, ha az egér nincs rajta és nem aktív vezérlő
                if (!lst_talalatok.Bounds.Contains(PointToClient(Cursor.Position)) &&
                    !lst_talalatok.Focused)
                {
                    lst_talalatok.Visible = false;
                }
            }));
        }
        private void szpn_szuroPanel_Click(object sender, EventArgs e)
        {
            szpn_szuroPanel.Focus();
        }

        private void btn_mentes_Click(object sender, EventArgs e)
        {

            if (!vanValtozas)
            {
                MessageBox.Show("Jelenleg nincs mentendő változtatás.");
                return;
            }

            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 0)
            {
                MessageBox.Show(
                    "A művelet végrehajtásához nincs engedélye.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            using (var kapcsolat = new MySqlConnection(constr))
            {
                kapcsolat.Open();

                foreach (DataGridViewRow sor in dgv_utazasok.Rows)
                {
                    if (sor.IsNewRow) continue;

                    int utasId = Convert.ToInt32(sor.Cells["Sorszám"].Value);

                    string titulus = sor.Cells["Titulus"].Value?.ToString();
                    string vezeteknev = sor.Cells["Vezetéknév"].Value?.ToString();
                    string keresztnev1 = sor.Cells["Keresztnév"].Value?.ToString();
                    string keresztnev2 = sor.Cells["Második keresztnév"].Value?.ToString();
                    string telefon = sor.Cells["Telefonszám"].Value?.ToString();
                    string okmany = sor.Cells["Okmány"].Value?.ToString();
                    DateTime ervenyesseg = Convert.ToDateTime(sor.Cells["Érvényesség"].Value);
                    string lakcim = sor.Cells["Lakcím"].Value?.ToString();
                    string email = sor.Cells["Email"].Value?.ToString();
                    int befizetett = Convert.ToInt32(sor.Cells["Befizetett összeg"].Value);
                    string biztositas = sor.Cells["Biztosítás van"].Value.ToString();
                    string megjegyzes = sor.Cells["Megjegyzés"].Value?.ToString();

                    // ugyanazok az UPDATE-ek, mint korábban...
                    using (var cmd = new MySqlCommand(@"UPDATE utas SET 
                titulus = @titulus, vezeteknev = @vezeteknev, keresztnev1 = @kn1, keresztnev2 = @kn2 
                WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@titulus", titulus);
                        cmd.Parameters.AddWithValue("@vezeteknev", vezeteknev);
                        cmd.Parameters.AddWithValue("@kn1", keresztnev1);
                        cmd.Parameters.AddWithValue("@kn2", keresztnev2);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE telefon SET telefon = @telefon WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        cmd.ExecuteNonQuery();
                    }

                    string allampolgarsag = sor.Cells["Állampolgárság"].Value?.ToString();
                    using (var cmd = new MySqlCommand(@"
    UPDATE szemelyi 
    SET szemelyi_vagy_utlevel = @okmany, 
        okmany_lejarat = @ervenyesseg,
        allampolgarsag = @allamp
    WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@okmany", okmany);
                        cmd.Parameters.AddWithValue("@ervenyesseg", ervenyesseg);
                        cmd.Parameters.AddWithValue("@allamp", allampolgarsag);
                        cmd.Parameters.AddWithValue("@id", utasId);
                         cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE cim SET lakcim = @lakcim, email_cim = @email WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@lakcim", lakcim);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE fizetes SET befizetett_osszeg = @osszeg, biztositas = @bizt WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@osszeg", befizetett);
                        cmd.Parameters.AddWithValue("@bizt", biztositas);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE megjegyzes SET megjegyzes = @megj WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@megj", megjegyzes);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        cmd.ExecuteNonQuery();
                    }
                }

                btn_mentes.HatterSzine = Color.MediumSlateBlue;
                MessageBox.Show( "Az adatok sikeresen frissültek!" ,
    "Mentés",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
            }
            vanValtozas = false;  // visszaállítjuk
            btn_mentes.HatterSzine = Color.MediumSlateBlue;
        }

        private void kg_kilepes_Click(object sender, EventArgs e)
        {
            pnl_utasLista.Visible = false;
            kszm_utasLista.HatterSzine = Color.MediumSlateBlue;
        }

        private void kg_UlNyomtatas_Click(object sender, EventArgs e)
        {
            ppd_utasLista.Document = pd_utasLista;
            ppd_utasLista.ShowDialog(); //
            pnl_utasLista.Visible = false;
            kszm_utasLista.HatterSzine = Color.MediumSlateBlue;
        }
        private void BetoltUtasLista()
        {
            try
            {
                DataTable dt = new DataTable();
                using (var con = new MySqlConnection(constr))
                {
                    con.Open();
                    string sql = @"SELECT
    CONCAT(u.vezeteknev, ' ', u.keresztnev1, ' ', u.keresztnev2) AS 'Név',
    GROUP_CONCAT(DISTINCT telefon.telefon SEPARATOR ', ') AS 'Telefonszám'
FROM utas u
JOIN utas_utazasai uu ON u.utas_id = uu.utas_id
JOIN utazas t ON uu.utazas_id = t.utazas_id
LEFT JOIN telefon ON u.utas_id = telefon.utas_id
WHERE t.utazas_elnevezese = @nev 
  AND t.desztinacio = @dest 
  AND t.utazas_ideje = @datum
GROUP BY u.utas_id, u.vezeteknev, u.keresztnev1, u.keresztnev2
ORDER BY u.vezeteknev, u.keresztnev1;";


                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nev", utazasNeve);
                        cmd.Parameters.AddWithValue("@dest", utazasDesztinacio);
                        cmd.Parameters.AddWithValue("@datum", utazasIdoszak);

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                    // Automatikus sorszám oszlop
                    dt.Columns.Add("Sorszám", typeof(int));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["Sorszám"] = i + 1;
                    }
                    dt.Columns["Sorszám"].SetOrdinal(0);

                    dgv_utasLista.DataSource = dt;
                    dgv_utasLista.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    pnl_utasLista.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }

        private void kerekitettGomb3_Click(object sender, EventArgs e)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
           
            kszm_utasLista.HatterSzine = Color.Green;

            BetoltUtasLista();
        }


        private void pd_utasLista_PrintPage(object sender, PrintPageEventArgs e)
        {
            int marginLeft = 50;
            int y = 50;
            int rowHeight = 25;
            Brush brush = Brushes.Black;

            int x1 = 50;  // első oszlop X pozíció
            int x2 = 300; // második oszlop X pozíció
            int sorKoz = 25;

            Font fejlec = new Font("Arial", 12, FontStyle.Bold);
            Font normal = new Font("Arial", 10);

            e.Graphics.DrawString("Utaslista", fejlec, Brushes.Black, x1, y);
            y += 40;

            // Első sor: Dátum - Busz rendszám
            e.Graphics.DrawString("Dátum: " + kszm_datum.Texts, normal, Brushes.Black, x1, y);
            e.Graphics.DrawString("Jármű száma: " + kszm_jarmuSzama.Texts, normal, Brushes.Black, x2, y);
            y += sorKoz;

            // Második sor: Vezetők - Úticél
            e.Graphics.DrawString("Vezetők neve: " + kszm_vezetoNeve1.Texts + " " + kszm_vezetoNeve2.Texts, normal, Brushes.Black, x1, y);
            e.Graphics.DrawString("Úti cél: " + kszm_uticel.Texts, normal, Brushes.Black, x2, y);
            y += sorKoz;

            // Harmadik sor: Indulás helye (csak bal oldalt)
            e.Graphics.DrawString("Indulás helye: " + kszm_indulasHelye.Texts, normal, Brushes.Black, x1, y);
            y += sorKoz + 10;

            // Oszlopfejlécek
            int col1_x = marginLeft;
            int col2_x = col1_x + 150;   // Sorszám után
            int col3_x = col2_x + 250; // Név után

            e.Graphics.DrawString("Sorszám", fejlec, brush, col1_x, y);
            e.Graphics.DrawString("Név", fejlec, brush, col2_x, y);
            e.Graphics.DrawString("Telefonszám", fejlec, brush, col3_x, y);
            y += rowHeight;

            // Adatsorok
            foreach (DataGridViewRow row in dgv_utasLista.Rows)
            {
                if (row.IsNewRow) continue;

                string sorszam = row.Cells[0].Value?.ToString() ?? "";
                string nev = row.Cells[1].Value?.ToString() ?? "";
                string telszam = row.Cells[2].Value?.ToString() ?? "";

                e.Graphics.DrawString(sorszam, normal, brush, col1_x, y);
                e.Graphics.DrawString(nev, normal, brush, col2_x, y);
                e.Graphics.DrawString(telszam, normal, brush, col3_x, y);

                y += rowHeight;

                // Oldaltörés
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }



        }

        private void kszm_nyomtatas_Click(object sender, EventArgs e)
        {
            sorIndexAHolFolytatniKell = 0;
            ppd_utasLista.Document = pd_utazasok;
            ppd_utasLista.ShowDialog(); //
            pnl_utasLista.Visible = false;
            szpn_szuroPanel.Visible = false;
            kszm_nyomtatas.HatterSzine = Color.MediumSlateBlue;
        }

        private void pd_utazasok_PrintPage(object sender, PrintPageEventArgs e)
        {
            int marginLeft = 50;
            int y = 50;
            int rowHeight = 25;
            Brush brush = Brushes.Black;

            // Oszlopfejlécek (csak az első oldalon vagy minden oldalon, ha akarod)
            // Jelenleg úgy van, hogy minden oldalon megjelennek
            Font fejlec = new Font("Arial", 12, FontStyle.Bold);
            Font normal = new Font("Arial", 10);

            // Fejlécek kirajzolása (csak az első oldalon, vagy ha szeretnéd, minden oldalon)
            // Ha csak az első oldalon akarod, akkor egy if-fel kellene ellenőrizni, hogy sorIndexAHolFolytatniKell == 0
            e.Graphics.DrawString("Titulus", fejlec, brush, marginLeft, y);
            e.Graphics.DrawString("Vezetéknév", fejlec, brush, marginLeft + 75, y);
            e.Graphics.DrawString("Keresztnév", fejlec, brush, marginLeft + 180, y);
            e.Graphics.DrawString("Email", fejlec, brush, marginLeft + 325, y); // Példa: email oszlop
            e.Graphics.DrawString("Telefonszám", fejlec, brush, marginLeft + 550, y); // Példa: telefonszám oszlop


            y += rowHeight + 10; // Hely a fejléc és az első sor között

            // --- FONTOS VÁLTOZÁS: FOR CIKLUS ÉS AZ OSZTÁLYSZINTŰ VÁLTOZÓ HASZNÁLATA ---
            // A ciklus az eltárolt sorIndexAHolFolytatniKell-től indul
            for (; sorIndexAHolFolytatniKell < dgv_utazasok.Rows.Count; sorIndexAHolFolytatniKell++)
            {
                DataGridViewRow row = dgv_utazasok.Rows[sorIndexAHolFolytatniKell];

                if (row.IsNewRow) // Kihagyjuk az új (üres) sort a végén
                {
                    continue; // Átugorja az isNewRow-t, és folytatja a következő iterációval, ha van még
                }


                // Ellenőrizd, hogy az oszlopindexek helyesek-e a DataGridView-ben!
                // Feltételezve, hogy az oszlopok sorrendje: 0:Sorszám, 1:Titulus, 2:Vezetéknév, 3:Keresztnév, 4:Második Keresztnév, 5:Telefonszám, 6:Okmány...
                string s1 = row.Cells["Titulus"].Value?.ToString() ?? "";       // Index 1
                string s2 = row.Cells["Vezetéknév"].Value?.ToString() ?? "";    // Index 2
                string s3 = row.Cells["Keresztnév"].Value?.ToString() ?? "";    // Index 3
                string s4 = row.Cells["Email"].Value?.ToString() ?? "";         // Példa: email oszlop (megfelelő index vagy név kell ide!)
                string s5 = row.Cells["Telefonszám"].Value?.ToString() ?? "";   // Példa: telefonszám oszlop (megfelelő index vagy név kell ide!)
                                                                                // string s6 = row.Cells[6].Value?.ToString() ?? ""; // Ezt nem használtad fel az alábbi DrawString-ekben


                e.Graphics.DrawString(s1, normal, brush, marginLeft, y);
                e.Graphics.DrawString(s2, normal, brush, marginLeft + 75, y);
                e.Graphics.DrawString(s3, normal, brush, marginLeft + 180, y);
                e.Graphics.DrawString(s4, normal, brush, marginLeft + 325, y); // Példa
                e.Graphics.DrawString(s5, normal, brush, marginLeft + 550, y); // Példa

                y += rowHeight;

                // Oldaltörés ellenőrzése
                if (y >= e.MarginBounds.Bottom) // Ha elérjük az oldal alját, vagy túlhaladjuk
                {
                    e.HasMorePages = true; // Jelzi, hogy van még nyomtatnivaló
                    sorIndexAHolFolytatniKell++; // Növeljük az indexet, hogy a következő oldal a következő sorral kezdődjön
                    return; // Fontos: Kilépünk a metódusból!
                }
            }

            // Ha a ciklus lefutott a végéig, és nincs több sor
            e.HasMorePages = false; // Nincs több oldal
            sorIndexAHolFolytatniKell = 0; // Visszaállítjuk az indexet 0-ra a következő nyomtatás elindításához

        }
        private void lst_talalatok_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var listBox = sender as ListBox;
            var item = listBox.Items[e.Index].ToString();
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // A simítás és a szöveg renderelésének beállítása
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // A kijelölés hátterének kitöltése, függetlenül attól, hogy ki van-e jelölve.
            // Így elkerüljük a maradék pixeleket a korábbi rajzolásból.
            e.Graphics.FillRectangle(new SolidBrush(listBox.BackColor), e.Bounds);

            // Kerekített háttérrajzolás, ha ki van jelölve
            if (isSelected)
            {
                int radius = 8; // Kerekítés mértéke
                                // Kicsi margót hagyunk a kijelölés körül
                Rectangle selectionBounds = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 4, e.Bounds.Height - 2);

                using (GraphicsPath path = GetRoundedRectanglePath(selectionBounds, radius))
                using (Brush bgBrush = new SolidBrush(Color.DarkViolet))
                {
                    e.Graphics.FillPath(bgBrush, path);
                }
            }

            // Szöveg rajzolása a megfelelő színekkel
            using (Brush textBrush = new SolidBrush(isSelected ? Color.White : listBox.ForeColor))
            {
                // A szöveg rajzolásához érdemes egy kicsit beljebb húzódni, hogy ne érjen a lekerekített szélhez
                Rectangle textBounds = new Rectangle(e.Bounds.X + 6, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                TextRenderer.DrawText(e.Graphics, item, e.Font, textBounds, isSelected ? Color.White : listBox.ForeColor, TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Bal felső sarok
            path.AddArc(arc, 180, 90);

            // Jobb felső sarok
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Jobb alsó sarok
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bal alsó sarok
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void kszm_torles_Click(object sender, EventArgs e)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 0)
            {
                MessageBox.Show(
                    "A művelet végrehajtásához nincs engedélye.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            // Ellenőrizzük, hogy van-e kiválasztott sor a DataGridView-ben
            if (dgv_utazasok.SelectedRows.Count > 0)
            {
                // Csak az első kijelölt sort vesszük figyelembe
                DataGridViewRow selectedRow = dgv_utazasok.SelectedRows[0];

                // Megerősítést kérünk a felhasználótól
                DialogResult result = MessageBox.Show(
                    "Biztosan törölni szeretnéd ezt a felhasználót a kiválasztott utazásból?",
                    "Megerősítés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Az utas_id lekérése a kijelölt sorból
                        // Feltételezzük, hogy az 'Sorszám' oszlop tartalmazza az utas_id-t
                        if (selectedRow.Cells["Sorszám"].Value == null)
                        {
                            MessageBox.Show("A kiválasztott sor nem tartalmaz érvényes utas azonosítót.", "Hiba");
                            return;
                        }
                        int utasId = Convert.ToInt32(selectedRow.Cells["Sorszám"].Value);

                        // Megkeressük az utazás_id-t az aktuálisan kiválasztott utazási adatok alapján
                        // (ezek a form változói: utazasDesztinacio, utazasIdoszak, utazasNeve)
                        if (string.IsNullOrEmpty(utazasDesztinacio) || string.IsNullOrEmpty(utazasIdoszak) || string.IsNullOrEmpty(utazasNeve))
                        {
                            MessageBox.Show("Kérjük, válasszon ki egy utazást a szűrőkből.", "Figyelmeztetés");
                            return;
                        }

                        int utazasId = UtazasIdLekerese(utazasDesztinacio, utazasIdoszak, utazasNeve);

                        if (utazasId > 0)
                        {
                            // Töröljük a felhasználót az utazásból
                            UtasFromUtazasTorles(utasId, utazasId);
                            // Frissítsük a DataGridView-t a törlés után, hogy azonnal látható legyen a változás
                            lekerdezes_kivalasztva();
                            MessageBox.Show("A felhasználó sikeresen törölve lett az utazásból.", "Siker");
                        }
                        else
                        {
                            MessageBox.Show("Nem található az utazás azonosítója. Kérjük, győződjön meg róla, hogy érvényes utazás van kiválasztva.", "Hiba");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a törlés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon ki egy sort a törléshez.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int UtazasIdLekerese(string desztinacio, string idoszak, string utazasNeve)
        {
            int utazasId = -1; // Alapértelmezett érték, ha nem található

            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    string sql = "SELECT utazas_id FROM utazas WHERE desztinacio = @desztinacio AND utazas_ideje = @idoszak AND utazas_elnevezese = @utazasneve LIMIT 1";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@desztinacio", desztinacio);
                       
                        cmd.Parameters.AddWithValue("@idoszak", DateTime.Parse(idoszak));
                        cmd.Parameters.AddWithValue("@utazasneve", utazasNeve);

                        object result = cmd.ExecuteScalar(); 

                        if (result != null && result != DBNull.Value)
                        {
                            utazasId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba az utazás azonosító lekérésekor: {e.Message}", "Adatbázis hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return utazasId;
        }

        /// <summary>
        /// Törli a felhasználó és az utazás közötti hozzárendelést az utas_utazasai táblából.
        /// </summary>
        private void UtasFromUtazasTorles(int utasId, int utazasId)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 0)
            {
                MessageBox.Show(
                    "A művelet végrehajtásához nincs engedélye.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    string sql = "DELETE FROM utas_utazasai WHERE utas_id = @utasId AND utazas_id = @utazasId";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.Parameters.AddWithValue("@utazasId", utazasId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Nem történt törlés. Lehet, hogy a felhasználó már nincs hozzárendelve ehhez az utazáshoz, vagy az adatok nem egyeznek.", "Információ");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba a felhasználó utazásból való törlésekor: {e.Message}", "Adatbázis hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
