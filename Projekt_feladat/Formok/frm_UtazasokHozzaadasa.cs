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
            if (string.IsNullOrWhiteSpace(kszm_desztinacio.Texts) &&
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
            ablakUjrarajzolas();



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

                    klm_utazasSzerkeszeseIdoszak.ComboText = "Időszak";
                    klm_utazasSzerkeszeseUtazasNeve.ComboText = "Utazás neve";
                    klm_utazasSzerkeszeseIdoszak.adatForras = new string[0];
                    klm_utazasSzerkeszeseIdoszak.adatForras = new string[0];
                    utazasIdoszak = null;
                    utazasNeve = null;
                }

                utazasDesztinacio = e.Ertek;

                // Töröljük a további két combobox tartalmát
                rcb_utazasIdeje.adatForras = new string[0];
                rcb_utazasElnevezese.adatForras = new string[0];
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
                    if (!szp_utazasSzerkeszese.Visible)
                        rcb_utazasIdeje.adatForras = lista.ToArray();
                    else
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
                    if (!szp_utazasSzerkeszese.Visible)
                    {
                        rcb_utazasElnevezese.ComboText = "Utazás neve";
                        rcb_utazasElnevezese.adatForras = new string[0];
                    }
                    else
                    {
                        klm_utazasSzerkeszeseUtazasNeve.ComboText = "Utazás neve";
                        klm_utazasSzerkeszeseUtazasNeve.adatForras = new string[0];
                    }
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
                    if (!szp_utazasSzerkeszese.Visible)
                        rcb_utazasElnevezese.adatForras = lista.ToArray();
                    else
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

        private void rcb_utazasElnevezese_Load(object sender, EventArgs e)
        {
            rcb_utazasElnevezese.BringToFront();
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

        private void kszm_ujRegiFelhasznalo_Click(object sender, EventArgs e)
        {
            flp_rendezoPanel.Visible = true;
            kszm_mentes.Visible = false;
            tlp_utazasTorlese.Visible = false;
            kszm_hozzaadas.Visible = true;
            flp_utazasSzerkesztese.Visible = false;
        }

        private void kszm_utazasTorles_Click(object sender, EventArgs e)
        {
            flp_utazasSzerkesztese.Visible = false;
            flp_rendezoPanel.Visible = false;
            kszm_hozzaadas.Visible = false;
            tlp_utazasTorlese.Visible = true;
            kszm_mentes.Visible = false;
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

        }

        private void kg_meglevoSzerkesztese_Click(object sender, EventArgs e)
        {
            flp_utazasSzerkesztese.Visible = true;
            flp_rendezoPanel.Visible = false;
            tlp_utazasTorlese.Visible = false;
            kszm_hozzaadas.Visible = false;
            kszm_mentes.Visible = true;
        }

        private void kszm_mentes_Click(object sender, EventArgs e)
        {

        }
    }
}



    




