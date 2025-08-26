using System;
using System.Data;
using System.Drawing;
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
        string kapcsolatString = String.Format("Server={0};User ID={1};Password={2};Database={3}",
            "127.0.0.1", "utazast_kezelo", "utazast_kezelo1234", "utazast_kezelo");

        int oldalMeret = 100;   // ÚJ: oldalankénti sorok száma

        public frm_Elofoglalasok()
        {
            InitializeComponent();
            klm_foglalasiAllapot.Visible = false;
            pnl_vezerlopanel.Height = 70;

            this.Load += Frm_Elofoglalasok_Load;

            // ÚJ: NumericUpDown esemény bekötése
            nud_oldalszam.ValueChanged += nud_oldalszam_ValueChanged;
        }
        public frm_foForm FoForm { get; set; }

        private void Frm_Elofoglalasok_Load(object sender, EventArgs e)
        {
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
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(ex.Message);
            }
        }
        private void AdatokBetoltese()
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
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Változtatások mentve!");
            AdatokBetoltese();
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
                pnl_vezerlopanel.BackColor = Color.DarkViolet;
                klm_foglalasiAllapot.Visible = false;
                kszm_szerkesztes.HatterSzine = Color.DarkGoldenrod;
            }
            else
            {
                dgv_utasok.ReadOnly = false;
                szerkesztesAktiv = true;
                pnl_vezerlopanel.Height += 70;
                klm_foglalasiAllapot.Location = new Point(pnl_segedPanel.Location.X,
                                                         pnl_segedPanel.Location.Y + klm_foglalasiAllapot.Height + 10);
                pnl_vezerlopanel.BackColor = Color.Orange;
                kszm_szerkesztes.HatterSzine = Color.Green;
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
            bool barmiszuroaktiv =
                !string.IsNullOrWhiteSpace(kszm_utasNeve.Texts) ||
                !string.IsNullOrWhiteSpace(kszm_email.Texts) ||
                !string.IsNullOrWhiteSpace(kszm_lakcim.Texts) ||
                !string.IsNullOrWhiteSpace(kszm_telefon.Texts) ||
                dtp_relativDatum.Checked ||
                (!string.IsNullOrEmpty(klm_allapot.ComboText) &&
                 klm_allapot.ComboText.ToLower() != "mind" &&
                 klm_allapot.ComboText.ToLower() != "állapot");

            if (barmiszuroaktiv)
            {
                lekerdezes();
            }
            else
            {
                szuresAktiv = false;
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
       
    }
}

    

