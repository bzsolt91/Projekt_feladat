using LiveChartsCore.Measure;
using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
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
        string kapcsolatString = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "utazast_kezelo");
        private void kszm_hozzaadas_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(kszm_desztinacio.Texts) ||
       string.IsNullOrWhiteSpace(kszm_utazasElnevezese.Texts))
            {
                kszm_hozzaadas.HatterSzine = Color.Red;
                return;
            }


            try
            {
                using (var kapcsolatObj = new MySqlConnection(kapcsolatString))
                {
                    kapcsolatObj.Open();


                    string utazas = @"
                INSERT INTO utazas
                (utazas_modja, utazas_elnevezese, utazas_ideje, desztinacio)
                VALUES (@mod, @nev, @ido, @hely)";

                    using (var cmd = new MySqlCommand(utazas, kapcsolatObj))
                    {
                        cmd.Parameters.AddWithValue("@mod", klm_utazasiMod.ComboText);
                        cmd.Parameters.AddWithValue("@nev", kszm_utazasElnevezese.Texts);
                        cmd.Parameters.AddWithValue("@ido", dtp_indulas.Value.Date);
                        cmd.Parameters.AddWithValue("@hely", kszm_desztinacio.Texts);
                        cmd.ExecuteNonQuery();
                    }

                    // Az újonnan beszúrt utazás ID-jának lekérése
                    long utazasId;
                    using (var cmdId = new MySqlCommand("SELECT LAST_INSERT_ID()", kapcsolatObj))
                    {
                        utazasId = Convert.ToInt64(cmdId.ExecuteScalar());
                    }


                    string leiras = kszm_leiras.Texts;
                    DateTime indulasiDatum = dtp_indulas.Value.Date;
                    DateTime visszaDatum = dtp_vissza.Value.Date;
                    int ar = int.TryParse(kszm_ar.Texts, out int tempAr) ? tempAr : 0;
                    string helyszin = kszm_indulasiHely.Texts;
                    string boritoFajlnev = "";
                    if (pcb_borito.Image != null && !string.IsNullOrEmpty(pcb_borito.Tag as string))
                    {
                        boritoFajlnev = Path.GetFileName(pcb_borito.Tag.ToString());
                    }


                    string insertUj = @"
                INSERT INTO utazas_reszletek
                (utazas_id, leiras, indulasi_datum, visszaindulas_datum, ar, indulasi_helyszin, boritokep)
                VALUES (@id, @leiras, @indulas, @vissza, @ar, @helyszin, @kep)";

                    using (var cmd = new MySqlCommand(insertUj, kapcsolatObj)) // Helyes SQL parancs használata
                    {
                        cmd.Parameters.AddWithValue("@id", utazasId);
                        cmd.Parameters.AddWithValue("@leiras", leiras);
                        cmd.Parameters.AddWithValue("@indulas", indulasiDatum);
                        cmd.Parameters.AddWithValue("@vissza", visszaDatum);
                        cmd.Parameters.AddWithValue("@ar", ar);
                        cmd.Parameters.AddWithValue("@helyszin", helyszin);
                        cmd.Parameters.AddWithValue("@kep", boritoFajlnev);

                        int siker = cmd.ExecuteNonQuery(); // Csak egyszer kell meghívni

                        if (siker > 0)
                        {
                            kszm_hozzaadas.HatterSzine = Color.Green;
                            MessageBox.Show("Az utazás sikeresen rögzítve lett!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UrllapReset();  // <<< EZ KELL

                        }
                        else
                        {
                            kszm_hozzaadas.HatterSzine = Color.Red;
                            MessageBox.Show("Nem sikerült menteni.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a mentés során: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kszm_hozzaadas.HatterSzine = Color.Red;
            }

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
                using (var conn = new MySqlConnection(kapcsolatString))
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
                    klm_utazasSzerkeszeseDesztinacio.adatForras = lista.ToArray();

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
            ablakUjrarajzolas();



        }


        private void rcb_desztinacio_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasDesztinacio)
                {


                    klm_utazasSzerkeszeseIdoszak.ComboText = "Időszak";
                    klm_utazasSzerkeszeseUtazasNeve.ComboText = "Utazás neve";
                    klm_utazasSzerkeszeseIdoszak.adatForras = new string[0];
                    klm_utazasSzerkeszeseIdoszak.adatForras = new string[0];
                    utazasIdoszak = null;
                    utazasNeve = null;
                }

                utazasDesztinacio = e.Ertek;

                // Töröljük a további két combobox tartalmát

                klm_utazasSzerkeszeseIdoszak.adatForras = new string[0];
                klm_utazasSzerkeszeseUtazasNeve.adatForras = new string[0];
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
                using (var conn = new MySqlConnection(kapcsolatString))
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

                    klm_utazasSzerkeszeseIdoszak.adatForras = lista.ToArray();
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


        private void rcb_idoszak_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasIdoszak)
                {


                    klm_utazasSzerkeszeseUtazasNeve.ComboText = "Utazás neve";
                    klm_utazasSzerkeszeseUtazasNeve.adatForras = new string[0];

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
                using (var conn = new MySqlConnection(kapcsolatString))
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

                    klm_utazasSzerkeszeseUtazasNeve.adatForras = lista.ToArray();

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



        private void kg_utazasTorlese_Click(object sender, EventArgs e)
        {
            pnl_torles.BringToFront();
            lb_utazas.Text = utazasDesztinacio + ", " + utazasIdoszak + ", " + utazasNeve;
            if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                pnl_torles.Visible = true;
            pnl_torles.Location = new Point(this.Width / 2 - pnl_torles.Width / 2, this.Height / 2 - pnl_torles.Height / 2);

        }
        private void rcb_utazasNeve_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
                utazasNeve = e.Ertek;



        }


        private void kg_nem_Click(object sender, EventArgs e)
        {
            pnl_torles.Visible = false;
        }

        private void kg_igen_Click(object sender, EventArgs e)
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

            if (utazasDesztinacio != null && utazasIdoszak != null && utazasNeve != null)
            {
                try
                {
                    using (var kapcsolat = new MySqlConnection(kapcsolatString))
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

                                utazasok_betoltes(); // újratölti a desztinációkat
                                UrllapReset();
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

        private void kszm_ujRegiFelhasznalo_Click(object sender, EventArgs e)
        {
            flp_rendezoPanel.Visible = true;
            kszm_mentes.Visible = false;
            kszm_utazasTorles.Visible = false;
            kszm_hozzaadas.Visible = true;
            flp_utazasSzerkesztese.Visible = false;
        }

        private void kszm_utazasTorles_Click(object sender, EventArgs e)
        {
            pnl_torles.BringToFront();
            lb_utazas.Text = utazasDesztinacio + ", " + utazasIdoszak + ", " + utazasNeve;
            if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
                pnl_torles.Visible = true;
            pnl_torles.Location = new Point(this.Width / 2 - pnl_torles.Width / 2, this.Height / 2 - pnl_torles.Height / 2);
        }


        private void ablakUjrarajzolas()
        {
            const int margin = 10;
            int celMeret = this.ClientSize.Width;
            if (celMeret < 0) celMeret = 0;

            pl_terkezelo.Width = celMeret - 20;
            pnl_utazasokSzerkeszteseTerkoz.Width = celMeret - 20;
            flp_utazasSzerkesztese.PerformLayout();
            flp_utazasSzerkesztese.Invalidate();
            flp_rendezoPanel.PerformLayout();
            flp_rendezoPanel.Invalidate();



        }

        private void flp_rendezoPanel_Resize(object sender, EventArgs e)
        {
            flp_rendezoPanel.HorizontalScroll.Maximum = 0;
            flp_rendezoPanel.SuspendLayout();
            flp_rendezoPanel.AutoScroll = false;

            ablakUjrarajzolas();

            flp_rendezoPanel.PerformLayout();
            flp_rendezoPanel.Invalidate();

            flp_rendezoPanel.AutoScroll = true;
            flp_rendezoPanel.ResumeLayout();
            RendezLenyilloMenu(szp_utazasSzerkeszese);
        }
        private void RendezLenyilloMenu(SzinatmenetPanel panel)
        {


            // A kombódobozok listája
            kerekitettLenyilloMenu[] comboList = new kerekitettLenyilloMenu[]
            {
        klm_utazasSzerkeszeseDesztinacio,
        klm_utazasSzerkeszeseIdoszak,
        klm_utazasSzerkeszeseUtazasNeve
            };

            // A panel szélessége és a margó (helykihagyás az elemek között)
            int panelSzelesseg = panel.Width;
            int margó = 10; // A margó értéke (10 pixel)

            int comboSzelesseg = (panelSzelesseg - (comboList.Length + 1) * margó) / comboList.Length;

            int currentX = margó; // Kezdő X pozíció

            for (int i = 0; i < comboList.Length; i++)
            {
                kerekitettLenyilloMenu combo = comboList[i];

                // Beállítjuk a méretet és a pozíciót
                combo.Width = comboSzelesseg;
                combo.Location = new Point(currentX, 20); // A 20 az Y koordináta

                // Frissítjük a következő elem X pozícióját
                currentX += combo.Width + margó;
            }
        }

        private void frm_UtazasokHozzaadasa_Resize(object sender, EventArgs e)
        {
            ablakUjrarajzolas();
        }

        private void kg_boritoValasztas_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Borítókép kiválasztása";
                ofd.Filter = "Képfájlok (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Kép betöltése a PictureBox-ba
                        pcb_borito.Image = Image.FromFile(ofd.FileName);
                        pcb_borito.SizeMode = PictureBoxSizeMode.Zoom;

                        // Elérési út eltárolása a Tag-ben
                        pcb_borito.Tag = ofd.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nem sikerült betölteni a képet: " + ex.Message,
                                        "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void klm_utazasSzerkeszeseUtazasNeve_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek == null) return;
            utazasNeve = e.Ertek;

            if (utazasDesztinacio == null || utazasIdoszak == null || utazasNeve == null)
                return;

            try
            {
                using (var kapcsolat = new MySqlConnection(kapcsolatString))
                {
                    kapcsolat.Open();

                    string sql = @"
                SELECT u.utazas_id, u.utazas_modja, r.indulasi_datum, r.visszaindulas_datum,
                       r.indulasi_helyszin, r.ar, r.leiras, r.boritokep
                FROM utazas u
                JOIN utazas_reszletek r ON u.utazas_id = r.utazas_id
                WHERE u.desztinacio = @desztinacio 
                  AND u.utazas_ideje = @ido 
                  AND u.utazas_elnevezese = @elnevezes";

                    using (var cmd = new MySqlCommand(sql, kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                        cmd.Parameters.AddWithValue("@ido", DateTime.Parse(utazasIdoszak));
                        cmd.Parameters.AddWithValue("@elnevezes", utazasNeve);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                klm_utazasSzerkeszeseUtazasModja.ComboText = reader.GetString("utazas_modja");
                                dtp_utazasSzerkeszeseUtazásIdeje.Value = reader.GetDateTime("indulasi_datum");
                                dtp_utazasSzerkeszeseVisszaindulas.Value = reader.GetDateTime("visszaindulas_datum");
                                kszm_utazasSzerkeszeseIndulasHelye.Texts = reader.GetString("indulasi_helyszin");
                                kszm_utazasSzerkeszeseAr.Texts = reader.GetInt32("ar").ToString();
                                kszm_utazasSzerkeszeseLeiras.Texts = reader.GetString("leiras");

                                string kep = reader.IsDBNull("boritokep") ? "" : reader.GetString("boritokep");
                                if (!string.IsNullOrEmpty(kep) && File.Exists(Path.Combine("boritokepek", kep)))
                                {
                                    pb_utazasSzerkeszeseBorito.Image = Image.FromFile(Path.Combine("boritokepek", kep));
                                    pb_utazasSzerkeszeseBorito.Tag = Path.Combine("boritokepek", kep);
                                }
                                else
                                {
                                    pb_utazasSzerkeszeseBorito.Image = null;
                                    pb_utazasSzerkeszeseBorito.Tag = null;
                                }

                                // Elmentjük az utazás ID-ját egy rejtett mezőbe vagy változóba
                                pb_utazasSzerkeszeseBorito.Tag = reader.GetInt32("utazas_id");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltése során: " + ex.Message);
            }
        }

        private void kg_meglevoSzerkesztese_Click(object sender, EventArgs e)
        {
            flp_utazasSzerkesztese.Visible = true;
            flp_rendezoPanel.Visible = false;
            kszm_utazasTorles.Visible = true;
            kszm_hozzaadas.Visible = false;
            kszm_mentes.Visible = true;
        }

        private void kszm_mentes_Click(object sender, EventArgs e)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show("A művelet végrehajtásához be kell jelentkeznie.", "Bejelentkezés szükséges");
                return;
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 0)
            {
                MessageBox.Show("A művelet végrehajtásához nincs engedélye.", "Nincs jogosultság");
                return;
            }
            if (utazasDesztinacio == null || utazasIdoszak == null || utazasNeve == null)
            {
                MessageBox.Show("Hiányos adatok: válasszon ki egy utazást szerkesztéshez.");
                return;
            }

            try
            {
                using (var kapcsolat = new MySqlConnection(kapcsolatString))
                {
                    kapcsolat.Open();

                    string boritoFajlnev = "";
                    if (pb_utazasSzerkeszeseBorito.Image != null && !string.IsNullOrEmpty(pb_utazasSzerkeszeseBorito.Tag as string))
                    {
                        boritoFajlnev = Path.GetFileName(pb_utazasSzerkeszeseBorito.Tag.ToString());
                    }

                    string sql = @"
                UPDATE utazas u
                JOIN utazas_reszletek r ON u.utazas_id = r.utazas_id
                SET 
                    u.utazas_modja = @mod,
                    r.indulasi_datum = @indulas,
                    r.visszaindulas_datum = @vissza,
                    r.indulasi_helyszin = @helyszin,
                    r.ar = @ar,
                    r.leiras = @leiras,
                    r.boritokep = @kep
                WHERE u.desztinacio = @desztinacio
                  AND u.utazas_ideje = @ido
                  AND u.utazas_elnevezese = @elnevezes";

                    using (var cmd = new MySqlCommand(sql, kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@mod", klm_utazasSzerkeszeseUtazasModja.ComboText);
                        cmd.Parameters.AddWithValue("@indulas", dtp_utazasSzerkeszeseUtazásIdeje.Value.Date);
                        cmd.Parameters.AddWithValue("@vissza", dtp_utazasSzerkeszeseVisszaindulas.Value.Date);
                        cmd.Parameters.AddWithValue("@helyszin", kszm_utazasSzerkeszeseIndulasHelye.Texts);
                        cmd.Parameters.AddWithValue("@ar", int.TryParse(kszm_utazasSzerkeszeseAr.Texts, out int ar) ? ar : 0);
                        cmd.Parameters.AddWithValue("@leiras", kszm_utazasSzerkeszeseLeiras.Texts);
                        cmd.Parameters.AddWithValue("@kep", boritoFajlnev);
                        cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                        cmd.Parameters.AddWithValue("@ido", DateTime.Parse(utazasIdoszak));
                        cmd.Parameters.AddWithValue("@elnevezes", utazasNeve);

                        int siker = cmd.ExecuteNonQuery();
                        if (siker > 0)
                        {

                            MessageBox.Show("Az utazás sikeresen frissítve lett!", "Siker");
                            UrllapReset();

                        }
                        else
                        {
                            MessageBox.Show("Nem történt módosítás. Ellenőrizze az adatokat.", "Figyelmeztetés");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a mentés során: " + ex.Message);
            }
        }
        private void UrllapReset()
        {
            // Reset flag-ek
            utazasDesztinacio = null;
            utazasIdoszak = null;
            utazasNeve = null;

            // Reset kombók
            klm_utazasSzerkeszeseDesztinacio.ComboText = "Desztináció";
            klm_utazasSzerkeszeseIdoszak.ComboText = "Időszak";
            klm_utazasSzerkeszeseUtazasNeve.ComboText = "Utazás neve";
            klm_utazasSzerkeszeseUtazasModja.ComboText = "Utazás módja";

            klm_utazasSzerkeszeseIdoszak.adatForras = new string[0];
            klm_utazasSzerkeszeseUtazasNeve.adatForras = new string[0];

            // Reset dátumok
            dtp_utazasSzerkeszeseUtazásIdeje.Value = DateTime.Now;
            dtp_utazasSzerkeszeseVisszaindulas.Value = DateTime.Now;

            // Reset szövegek
            kszm_utazasSzerkeszeseIndulasHelye.Texts = string.Empty;
            kszm_utazasSzerkeszeseAr.Texts = string.Empty;
            kszm_utazasSzerkeszeseLeiras.Texts = string.Empty;

            // Reset kép
            pb_utazasSzerkeszeseBorito.Image = null;
            pb_utazasSzerkeszeseBorito.Tag = null;

            // Ha a hozzáadási oldal is van:
            kszm_desztinacio.Texts = string.Empty;
            kszm_utazasElnevezese.Texts = string.Empty;
            kszm_leiras.Texts = string.Empty;
            kszm_indulasiHely.Texts = string.Empty;
            kszm_ar.Texts = string.Empty;
            pcb_borito.Image = null;
            pcb_borito.Tag = null;



            // Frissítjük a desztinációkat
            utazasok_betoltes();
        }

        private void kg_utazasSzerkeszeseBorito_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Borítókép kiválasztása";
                ofd.Filter = "Képfájlok (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Kép betöltése a PictureBox-ba
                        pb_utazasSzerkeszeseBorito.Image = Image.FromFile(ofd.FileName);
                        pb_utazasSzerkeszeseBorito.SizeMode = PictureBoxSizeMode.Zoom;

                        // Elérési út eltárolása a Tag-ben (hogy az UPDATE során tudjuk, melyik fájl lett kiválasztva)
                        pb_utazasSzerkeszeseBorito.Tag = ofd.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nem sikerült betölteni a képet: " + ex.Message,
                                        "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}



    




