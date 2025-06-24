using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_feladat.Formok
{
    public partial class frm_UtazasokHozzaadasa : Form
    {

        public frm_UtazasokHozzaadasa()
        {
            InitializeComponent();
        }
        string constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "utazast_kezelo");
        private void kszm_hozzaadas_Click(object sender, EventArgs e)
        {
          
            using (var kapcsolatObj = new MySqlConnection(constr))
            {
                try
                {
                    kapcsolatObj.Open();

                    string sql = @"INSERT INTO utazas (utazas_elnevezese, utazas_ideje, desztinacio)
                           VALUES (@elnevezes, @ido, @desztinacio)";

                    using (var cmd = new MySqlCommand(sql, kapcsolatObj))
                    {
                        cmd.Parameters.AddWithValue("@elnevezes", kszm_utazasElnevezese.Texts.Trim());
                        cmd.Parameters.AddWithValue("@ido", dt_datumvalaszto.Value.ToString("yyyy-MM-dd")); // Biztonságos formátum SQL-hez
                        cmd.Parameters.AddWithValue("@desztinacio", kszm_desztinacio.Texts.Trim());

                        int siker = cmd.ExecuteNonQuery();

                        if (siker > 0)
                            //MessageBox.Show("Sikeres mentés!");
                            kszm_hozzaadas.HatterSzine = Color.Green;
                        else
                            // MessageBox.Show("Nem sikerült menteni.");
                            kszm_hozzaadas.HatterSzine = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt: " + ex.Message);
                }
            }
        }

    }

}

