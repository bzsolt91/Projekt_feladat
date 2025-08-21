using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using static Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu;

namespace Projekt_feladat.Formok
{
    public partial class frm_Elofoglalasok : Form
    {
        bool szerkesztesAktiv = false;
        string kapcsolatString = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "utazast_kezelo", "utazast_kezelo1234", "utazast_kezelo");

        public frm_Elofoglalasok()
        {
            InitializeComponent();
            klm_foglalasiAllapot.Visible = false;
            pnl_vezerlopanel.Height = 70;

            this.Load += Frm_Elofoglalasok_Load;

        }

        private void Frm_Elofoglalasok_Load(object sender, EventArgs e)
        {
            AdatokBetoltese();
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
                kg_szures.HatterSzine = Color.MediumSlateBlue;

            }
            else
            {
                szpn_szuroPanel.Visible = true;
                kg_szures.HatterSzine = Color.Orange;
            }
        }

        private void kg_pipa_Click(object sender, EventArgs e)
        {

        }
    }
}
