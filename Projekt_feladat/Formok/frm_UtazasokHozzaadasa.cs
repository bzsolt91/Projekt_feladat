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
using static Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu;

namespace Projekt_feladat.Formok
{
    public partial class frm_UtazasokHozzaadasa : Form
    {
        string? utazasDesztinacio = null;
        string? utazasIdoszak = null;
        string? utazasNeve = null;
        public frm_UtazasokHozzaadasa()
        {
            InitializeComponent();
        }
        string constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "utazast_kezelo");
        private void kszm_hozzaadas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kszm_desztinacio.Texts) &&
                string.IsNullOrWhiteSpace(kszm_utazasElnevezese.Texts) &&
                dt_datumvalaszto.Value.Date == DateTime.Now.Date)
            {
                return;
            }
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

        private void frm_UtazasokHozzaadasa_Load(object sender, EventArgs e)
        {
            utazasok_betoltes();
        }

        private void rcb_desztinacio_Load(object sender, EventArgs e)
        {
            rcb_desztinacio.BringToFront();
        }
        private void rcb_desztinacio_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasDesztinacio)
                {
                    rcb_utazasIdeje.ComboText = "Időszak";
                    rcb_utazasElnevezese.ComboText = "Utazás neve";
                    rcb_utazasIdeje.adatForras = new string[0];
                    rcb_utazasElnevezese.adatForras = new string[0];
                    utazasIdoszak = null;
                    utazasNeve = null;
                }

                utazasDesztinacio = e.Ertek;

                // Töröljük a további két combobox tartalmát
                rcb_utazasIdeje.adatForras = new string[0];
                rcb_utazasElnevezese.adatForras = new string[0];
                utazasIdoszak = null;
                utazasNeve = null;

                // Betöltjük az időszakokat az 2-es comboboxba
                idoszak_betoltes();
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

                    rcb_utazasIdeje.adatForras = lista.ToArray();
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

        private void rcb_utazasIdeje_Load(object sender, EventArgs e)
        {
            rcb_utazasIdeje.BringToFront();
        }
        private void rcb_idoszak_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasIdoszak)
                {

                    rcb_utazasElnevezese.ComboText = "Utazás neve";
                    rcb_utazasElnevezese.adatForras = new string[0];
                    utazasNeve = null;
                }
                utazasIdoszak = e.Ertek;
                if (utazasIdoszak != null && utazasDesztinacio != null)
                    utazasneve_betoltes();
            }
            else
                return;
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
                    rcb_utazasElnevezese.adatForras = lista.ToArray();
                    
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

        private void rcb_utazasElnevezese_Load(object sender, EventArgs e)
        {
            rcb_utazasElnevezese.BringToFront();
        }

        private void kg_utazasTorlese_Click(object sender, EventArgs e)
        {
            pnl_torles.BringToFront();
            lb_utazas.Text = utazasDesztinacio + ", "+utazasIdoszak +", "+ utazasNeve;
            if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                pnl_torles.Visible = true;
            pnl_torles.Location = new Point(this.Width / 2 - pnl_torles.Width / 2, this.Height / 2 - pnl_torles.Height / 2);

        }
        private void rcb_utazasNeve_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
                utazasNeve = e.Ertek;

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kg_nem_Click(object sender, EventArgs e)
        {
            pnl_torles.Visible = false;
        }

        private void kg_igen_Click(object sender, EventArgs e)
        {
 
            if (utazasDesztinacio != null && utazasIdoszak != null && utazasNeve != null)
            {
                try
                {
                    using (var kapcsolat = new MySqlConnection(constr))
                    {
                        kapcsolat.Open();

                        string sql = @"DELETE FROM utazas 
                               WHERE desztinacio = @desztinacio 
                                 AND utazas_ideje = @ido 
                                 AND utazas_elnevezese = @elnevezes";

                        using (var cmd = new MySqlCommand(sql, kapcsolat))
                        {
                            cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                            cmd.Parameters.AddWithValue("@ido", DateTime.Parse(utazasIdoszak));
                            cmd.Parameters.AddWithValue("@elnevezes", utazasNeve);

                            int toroltSorok = cmd.ExecuteNonQuery();

                            if (toroltSorok > 0)
                            {
                                MessageBox.Show("Az utazás sikeresen törölve lett.");
                                utazasDesztinacio = null;
                                utazasIdoszak = null;
                                utazasNeve = null;
                                rcb_desztinacio.ComboText = "Desztináció";
                                rcb_utazasIdeje.ComboText = "Időszak";
                                rcb_utazasElnevezese.ComboText = "Utazás neve";
                                rcb_utazasIdeje.adatForras = new string[0];
                                rcb_utazasElnevezese.adatForras = new string[0];
                                utazasok_betoltes(); // újratölti a desztinációkat
                            }
                            else
                            {
                                MessageBox.Show("Nem történt törlés. Lehet, hogy az adat már nem létezik.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt a törlés során: " + ex.Message);
                }
                finally
                {
                    pnl_torles.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Hiányos adatok. Ellenőrizd, hogy ki van-e választva a desztináció, időszak és az utazás neve.");
            }
        }
    }
    }



