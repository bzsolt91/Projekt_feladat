
using MySqlConnector;
using System.Data; // Kell a MySQL connector

namespace Projekt_feladat.Formok
{
    public partial class frm_ertesitesek : Form
    {
        public frm_ertesitesek()
        {
            InitializeComponent();
        }

        private void ablakUjrarajzolas()
        {
            int celMeret = this.ClientSize.Width;
            if (celMeret < 0) celMeret = 0;

            pl_terkezelo.Width = celMeret - 20;

            // Kényszerítsd az FLP-t, hogy újraszámolja a belső területét
            flp_rendezoPanel.PerformLayout();
            flp_rendezoPanel.Invalidate();
        }

        private void frm_ertesitesek_Load(object sender, EventArgs e)
        {
            ablakUjrarajzolas();

            string kapcsolatString = String.Format(
                "Server={0};User ID={1};Password={2};Database={3}",
                "127.0.0.1",
                "utazast_kezelo",
                "utazast_kezelo1234",
                "utazast_kezelo"
            );

            using (MySqlConnection kapcsolat = new MySqlConnection(kapcsolatString))
            {
                try
                {
                    kapcsolat.Open();

                    // 1. Lejáró okmányok betöltése
                    string okmanyQuery = "SELECT * FROM lejaro_okmanyok;";
                    MySqlDataAdapter daOkmany = new MySqlDataAdapter(okmanyQuery, kapcsolat);
                    System.Data.DataTable dtOkmany = new DataTable();
                    daOkmany.Fill(dtOkmany);
                    dgv_okmanyLejaratok.DataSource = dtOkmany;
                    dgv_okmanyLejaratok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // 2. Előfoglalások betöltése (csak érdeklődők)
                    string elofoglalasQuery = @"
                        SELECT teljes_nev as 'Név',
                                telefon as 'Telefonszám',
                                regisztracio_idopont as 'Regisztráció időpontja',
                                allapot as 'Állapot'
                        FROM elofoglalas 
                        WHERE allapot = 'érdeklődik';
                    ";
                    MySqlDataAdapter daElofoglalas = new MySqlDataAdapter(elofoglalasQuery, kapcsolat);
                    DataTable dtElofoglalas = new DataTable();
                    daElofoglalas.Fill(dtElofoglalas);
                    dgv_elofoglalasok.DataSource = dtElofoglalas;
                    dgv_elofoglalasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt az adatok betöltésekor: " + ex.Message);
                }
            }
        }

        private void frm_ertesitesek_Resize(object sender, EventArgs e)
        {
            ablakUjrarajzolas();
        }
    }
}
