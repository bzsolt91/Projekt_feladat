using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using static Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu;

namespace Projekt_feladat.Formok
{
    public partial class frm_Elofoglalasok : Form
    {
        bool szerkesztesAktiv = false;
        bool szuresAktiv = false;
        private bool vanValtozas = false;
        string kapcsolatString = String.Format("Server={0};User ID={1};Password={2};Database={3}",
            "127.0.0.1", "utazast_kezelo", "utazast_kezelo1234", "utazast_kezelo");

        int oldalMeret = 100;   // ÚJ: oldalankénti sorok száma
        ToolTip? egyeniTooltip = new ToolTip();
        public frm_Elofoglalasok()
        {
            InitializeComponent();
            klm_foglalasiAllapot.Visible = false;
            pnl_vezerlopanel.Height = 70;
            dgv_utasok.ShowCellToolTips = false;
            this.Load += Frm_Elofoglalasok_Load;
            egyeniTooltip.OwnerDraw = true;
            egyeniTooltip.Draw += EgyeniTooltip_Draw;
            egyeniTooltip.Popup += EgyeniTooltip_Popup;

            // ÚJ: NumericUpDown esemény bekötése
            nud_oldalszam.ValueChanged += nud_oldalszam_ValueChanged;
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
        public frm_foForm FoForm { get; set; }

        private void Frm_Elofoglalasok_Load(object sender, EventArgs e)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show("Az előfoglalások megtekintéséhez előbb be kell jelentkeznie a főoldalon.",
                                "Bejelentkezés szükséges",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                // táblázat üres
                dgv_utasok.DataSource = new DataTable();

                // minden vezérlő letiltása
                kszm_szerkesztes.Enabled = false;
                kg_mentes.Enabled = false;
                kg_szures.Enabled = false;
                klm_foglalasiAllapot.Enabled = false;
                kg_felvetelUtasnak.Enabled = false;

                return; // fontos: kilépünk a Load további részéből
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 0) // operátor
            {
                dgv_utasok.ReadOnly = true;

                kszm_szerkesztes.Enabled = false;
                kg_mentes.Enabled = false;
          
                klm_foglalasiAllapot.Enabled = false;
                kg_felvetelUtasnak.Enabled = false;
            }


            AdatokBetoltese();
            szpn_szuroPanel.Location = new Point((this.Width / 2) - (szpn_szuroPanel.Width / 2), this.Height / 2 - szpn_szuroPanel.Height / 2);
        }
        public void lekerdezes()
        {
            try
            {
                if (!bejelentkezes.bejelentkezes.Bejelentkezve())
                {
                    MessageBox.Show("A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                                    "Bejelentkezés szükséges",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = new MySqlConnection(kapcsolatString))
                {
                    conn.Open();
                    var dt = new DataTable();
                    var cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    var feltetelek = new List<string>();

                    // --- Szűrési feltételek ---
                    if (szuresAktiv)
                    {
                        if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts))
                        {
                            var nevReszek = kszm_utasNeve.Texts.Trim()
                                                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            int nevIndex = 0;
                            foreach (var szo in nevReszek)
                            {
                                string paramNev = "@nev" + nevIndex++;
                                feltetelek.Add($"LOWER(e.teljes_nev) LIKE {paramNev}");
                                cmd.Parameters.AddWithValue(paramNev, "%" + szo.ToLower() + "%");
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(kszm_email.Texts))
                        {
                            feltetelek.Add("LOWER(e.email) LIKE @em");
                            cmd.Parameters.AddWithValue("@em", "%" + kszm_email.Texts.ToLower() + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(kszm_telefon.Texts))
                        {
                            feltetelek.Add("LOWER(e.telefon) LIKE @tel");
                            cmd.Parameters.AddWithValue("@tel", "%" + kszm_telefon.Texts.ToLower() + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts))
                        {
                            feltetelek.Add("LOWER(e.lakcim) LIKE @lak");
                            cmd.Parameters.AddWithValue("@lak", "%" + kszm_lakcim.Texts.ToLower() + "%");
                        }

                        if (klm_allapot.ComboText.ToLower() != "mind" &&
                            klm_allapot.ComboText.ToLower() != "állapot")
                        {
                            feltetelek.Add("e.allapot = @allapot");
                            cmd.Parameters.AddWithValue("@allapot", klm_allapot.ComboText);
                        }

                        if (dtp_relativDatum.Checked)
                        {
                            feltetelek.Add("e.regisztracio_idopont <= @datum");
                            cmd.Parameters.AddWithValue("@datum", dtp_relativDatum.Value.Date);
                        }
                    }

                    string alapSelect = @"
                        SELECT 
                            e.elofoglalas_id,
                            e.teljes_nev as 'Név',
                            e.telefon as 'Telefon',
                            e.email as 'E-mail cím',
                            e.lakcim as 'Lakcím',
                            e.regisztracio_idopont as 'Regisztráció időpont',
                            e.allapot as 'Állapot',
                            u.utazas_elnevezese as 'Utazás neve',
                            u.utazas_ideje as 'Utazás ideje'
                        FROM elofoglalas e
                        JOIN utazas u ON e.utazas_id = u.utazas_id
                    ";

                    string whereClause = feltetelek.Count > 0
                        ? "WHERE " + string.Join(" AND ", feltetelek)
                        : "";

                    // --- Összes sor számolása a lapozáshoz ---
                    string countQuery = "SELECT COUNT(*) FROM elofoglalas e JOIN utazas u ON e.utazas_id = u.utazas_id " + whereClause;
                    using (var countCmd = new MySqlCommand(countQuery, conn))
                    {
                        foreach (MySqlParameter p in cmd.Parameters)
                            countCmd.Parameters.AddWithValue(p.ParameterName, p.Value);

                        int osszesSor = Convert.ToInt32(countCmd.ExecuteScalar());
                        int maxOldal = (int)Math.Ceiling(osszesSor / (double)oldalMeret);
                        if (maxOldal == 0) maxOldal = 1;

                        nud_oldalszam.Maximum = maxOldal;
                        if (nud_oldalszam.Value > maxOldal)
                            nud_oldalszam.Value = maxOldal;
                        if (nud_oldalszam.Value < 1)
                            nud_oldalszam.Value = 1;
                    }

                    // --- OFFSET kiszámítása ---
                    int aktualisOldal = (int)nud_oldalszam.Value;
                    if (aktualisOldal < 1) aktualisOldal = 1;
                    int offset = (aktualisOldal - 1) * oldalMeret;

                    cmd.CommandText = alapSelect + " " + whereClause + @"
                        ORDER BY (e.allapot='érdeklődik') DESC, e.regisztracio_idopont DESC
                        LIMIT @limit OFFSET @offset";

                    cmd.Parameters.AddWithValue("@limit", oldalMeret);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utasok.DataSource = dt;

                    if (dgv_utasok.Columns.Contains("elofoglalas_id"))
                        dgv_utasok.Columns["elofoglalas_id"].Visible = false;
                }

                dgv_utasok.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                dgv_utasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv_utasok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1146) // Table doesn't exist
                {
                    MessageBox.Show("A szükséges adatbázis tábla nem található!\n(Keresse meg: elofoglalas vagy utazas tábla)",
                                    "Adatbázis hiba",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (ex.Number == 1049 || ex.Number == 1045) // adatbázis vagy jogosultság hiba
                {
                    MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz. Ellenőrizze a beállításokat!",
                                    "Kapcsolódási hiba",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("MySQL hiba: " + ex.Message,
                                    "Adatbázis hiba",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba: " + ex.Message,
                                "Hiba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void AdatokBetoltese()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(kapcsolatString))
                {
                    conn.Open();
                    string lekerdezes = @"
                    SELECT e.elofoglalas_id, e.teljes_nev as 'Név', e.telefon as 'Telefon', e.email as 'E-mail cím', e.lakcim as 'Lakcím',
                           e.regisztracio_idopont as 'Regisztráció', e.allapot as 'Állapot',
                           u.utazas_elnevezese as 'Utazás neve', u.utazas_ideje as 'Utazás ideje'
                    FROM elofoglalas e
                    JOIN utazas u ON e.utazas_id = u.utazas_id
                    ORDER BY (e.allapot='érdeklődik') DESC, e.regisztracio_idopont DESC
                    LIMIT 100;";

                    MySqlDataAdapter da = new MySqlDataAdapter(lekerdezes, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_utasok.DataSource = dt;
                    dgv_utasok.Columns["elofoglalas_id"].Visible = false;
                }

                dgv_utasok.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                dgv_utasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv_utasok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1146) // Hiányzó tábla
                {
                    MessageBox.Show("A szükséges adatbázis tábla nem található (pl. 'elofoglalas' vagy 'utazas').",
                                    "Adatbázis hiba",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (ex.Number == 1049 || ex.Number == 1045) // adatbázis/jelszó hiba
                {
                    MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz. Ellenőrizze a beállításokat!",
                                    "Kapcsolódási hiba",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("MySQL hiba: " + ex.Message,
                                    "Adatbázis hiba",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba: " + ex.Message,
                                "Hiba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Kg_email_Click(object sender, EventArgs e)
        {
            if (dgv_utasok.CurrentRow != null)
            {
                string email = dgv_utasok.CurrentRow.Cells["E-mail cím"].Value.ToString();
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = $"mailto:{email}",
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nem sikerült megnyitni az alapértelmezett email klienst: " + ex.Message);
                }
            }
        }

        private void Kg_telefonszamMasolas_Click(object sender, EventArgs e)
        {
            if (dgv_utasok.CurrentRow != null)
            {
                string telefon = dgv_utasok.CurrentRow.Cells["telefon"].Value.ToString();
                Clipboard.SetText(telefon);
                MessageBox.Show("Telefonszám vágólapra másolva!");
            }
        }

        private void Kg_mentes_Click(object sender, EventArgs e)
        {

           
            if (!vanValtozas)
            {
                MessageBox.Show("Jelenleg nincs mentendő változtatás.");
                return;
            }

            int frissitettSorok = 0;

            using (MySqlConnection conn = new MySqlConnection(kapcsolatString))
            {
                conn.Open();
                foreach (DataGridViewRow sor in dgv_utasok.Rows)
                {
                    if (sor.IsNewRow) continue;

                    string update = @"
                UPDATE elofoglalas 
                SET teljes_nev=@nev, telefon=@tel, email=@em, lakcim=@lak, allapot=@allapot 
                WHERE elofoglalas_id=@id;";

                    using (MySqlCommand cmd = new MySqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev", sor.Cells["Név"].Value);
                        cmd.Parameters.AddWithValue("@tel", sor.Cells["Telefon"].Value);
                        cmd.Parameters.AddWithValue("@em", sor.Cells["E-mail cím"].Value);
                        cmd.Parameters.AddWithValue("@lak", sor.Cells["Lakcím"].Value);
                        cmd.Parameters.AddWithValue("@allapot", sor.Cells["Állapot"].Value);
                        cmd.Parameters.AddWithValue("@id", sor.Cells["elofoglalas_id"].Value);

                        frissitettSorok += cmd.ExecuteNonQuery();
                    }
                }
            }

            if (frissitettSorok > 0)
            {
                kg_mentes.HatterSzine = Color.MediumSlateBlue;
                MessageBox.Show(
                    "Változtatások sikeresen mentve!",
                    "Mentés",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                AdatokBetoltese();
            }
            else
            {
                MessageBox.Show(
                    "Nem történt változás az adatokban.",
                    "Mentés",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            vanValtozas = false;  
            kg_mentes.HatterSzine = Color.MediumSlateBlue;
        }

        private void Kg_torles_Click(object sender, EventArgs e)
        {
            if (dgv_utasok.CurrentRow == null) return;

            string nev = dgv_utasok.CurrentRow.Cells["Név"].Value.ToString();
            DialogResult valasz = MessageBox.Show(
                $"Biztosan törölni szeretnéd a következő előfoglalást?\n\n{nev}",
                "Megerősítés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (valasz != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(dgv_utasok.CurrentRow.Cells["elofoglalas_id"].Value);
            using (MySqlConnection conn = new MySqlConnection(kapcsolatString))
            {
                conn.Open();
                string torles = "DELETE FROM elofoglalas WHERE elofoglalas_id=@id;";
                using (MySqlCommand cmd = new MySqlCommand(torles, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("A kiválasztott előfoglalás törölve lett!");
            AdatokBetoltese();
        }

        private void klm_foglalasiAllapot_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek == null) return;
            if (dgv_utasok.CurrentRow == null) return;

            string ujAllapot = e.Ertek.ToString();
            int id = Convert.ToInt32(dgv_utasok.CurrentRow.Cells["elofoglalas_id"].Value);

            using (MySqlConnection conn = new MySqlConnection(kapcsolatString))
            {
                conn.Open();
                string update = "UPDATE elofoglalas SET allapot=@allapot WHERE elofoglalas_id=@id;";
                using (MySqlCommand cmd = new MySqlCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("@allapot", ujAllapot);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            AdatokBetoltese();
        }

        private void kszm_szerkesztes_Click(object sender, EventArgs e)
        {
            if (szerkesztesAktiv)
            {
                dgv_utasok.ReadOnly = true;
                pnl_vezerlopanel.Height = 70;
                szerkesztesAktiv = false;

                klm_foglalasiAllapot.Visible = false;
                kszm_szerkesztes.HatterSzine = Color.MediumSlateBlue;
            }
            else
            {
                dgv_utasok.ReadOnly = false;
                szerkesztesAktiv = true;
                pnl_vezerlopanel.Height += 70;
                klm_foglalasiAllapot.Location = new Point(pnl_segedPanel.Location.X,
                                                         pnl_segedPanel.Location.Y + klm_foglalasiAllapot.Height + 10);

                kszm_szerkesztes.HatterSzine = Color.DarkGoldenrod;
                klm_foglalasiAllapot.Visible = true;
            }
        }

        private void kg_szures_Click(object sender, EventArgs e)
        {
            if (szpn_szuroPanel.Visible)
            {
                szpn_szuroPanel.Visible = false;
                szuresAktiv = false;
                kg_szures.HatterSzine = Color.MediumSlateBlue;

            }
            else
            {
                szuresAktiv = true;
                szpn_szuroPanel.Visible = true;
                kg_szures.HatterSzine = Color.DarkGoldenrod;
            }
        }


        private void kg_pipa_Click(object sender, EventArgs e)
        {
            szpn_szuroPanel.Visible = false;

            // --- számoljuk, hány szűrő van kitöltve ---
            int szurokSzama = 0;
            if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_email.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_telefon.Texts)) szurokSzama++;
            if (dtp_relativDatum.Checked) szurokSzama++;
            if (!string.IsNullOrEmpty(klm_allapot.ComboText) &&
                klm_allapot.ComboText.ToLower() != "mind" &&
                klm_allapot.ComboText.ToLower() != "állapot")
                szurokSzama++;

            bool barmiszuroaktiv = szurokSzama > 0;

            if (barmiszuroaktiv)
            {
                szuresAktiv = true;
                kg_szures.ErtesitesSzam = szurokSzama;
                kg_szures.HatterSzine = Color.DarkGoldenrod;
                lekerdezes();
            }
            else
            {
                szuresAktiv = false;
                kg_szures.ErtesitesSzam = 0;
                kg_szures.HatterSzine = Color.MediumSlateBlue;
                AdatokBetoltese();
            }
        }

        private void frm_Elofoglalasok_Resize(object sender, EventArgs e)
        {
            szpn_szuroPanel.Location = new Point((this.Width / 2) - (szpn_szuroPanel.Width / 2), this.Height / 2 - szpn_szuroPanel.Height / 2);
            klm_foglalasiAllapot.Location = new Point(pnl_segedPanel.Location.X,
                                                    pnl_segedPanel.Location.Y + klm_foglalasiAllapot.Height + 10);
        }
        private void nud_oldalszam_ValueChanged(object sender, EventArgs e)
        {
            lekerdezes();
        }
        private void kg_felvetelUtasnak_Click(object sender, EventArgs e)
        {
            if (dgv_utasok.CurrentRow == null)
            {
                MessageBox.Show("Nincs kijelölt sor!");
                return;
            }


            DataRowView drv = dgv_utasok.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;
            var ujForm = new frm_UtasokHozzaadasa();
            ujForm.BetoltAdatok(drv.Row); // Adatok átadása

            var utasForm = new frm_UtasokHozzaadasa();
            utasForm.BetoltAdatok(drv.Row);

            if (FoForm != null)
                FoForm.GyermekFormMegnyitas(utasForm, sender);



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

        private void EgyeniTooltip_Popup(object sender, PopupEventArgs e)
        {
            Font font = new Font("Segoe UI", 18);

            // Itt a 'sender' a ToolTip objektum, tehát le tudjuk kérni belőle a szöveget
            ToolTip tooltip = (ToolTip)sender;
            string szoveg = tooltip.GetToolTip(e.AssociatedControl);

            Size meret = TextRenderer.MeasureText(szoveg, font, new Size(1000, 0), TextFormatFlags.WordBreak);
            e.ToolTipSize = new Size(meret.Width + 10, meret.Height + 10);
        }
        private void dgv_utasok_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cella = dgv_utasok[e.ColumnIndex, e.RowIndex];
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

        private void dgv_utasok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            vanValtozas = true;
            kg_mentes.HatterSzine = Color.Red;
        }
}
}

    

