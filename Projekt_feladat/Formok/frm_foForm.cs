using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using MySqlConnector;
using Projekt_feladat.bejelentkezes;
using Projekt_feladat.egyeni_vezerlok;
using Projekt_feladat.Formok;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;


namespace Projekt_feladat
{
    public partial class frm_foForm : Form
    {
        /************   Fejl�c mozgat�shoz sz�ks�ges v�ltoz�k    ************/
        private bool mozgatas_egerrel = false; //mozgat�si st�tusz r�gz�t�se
        private Point mozgatasi_pont; //a kurzor �j poz�ci�ja ahov� az ablak mozgat�dik
        private Point form_mozgatasi_pont; //
        /************************/
        private string configFile = Path.Combine(Application.StartupPath, "mysqldump_path.txt");

        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);
        private int celMagassag = 0;
        private int lepes = 2;

        private Stopwatch animacioStopper = new Stopwatch();
        private int animacioKezdoMagassag;
        private int animacioCelMagassag;
        private int animacioIdotartam = 200; // anim�ci� id�tartama ms-ban


        private Form aktivForm;
        private Panel animaltPanel;
        public frm_foForm()
        {

            InitializeComponent();

            tmr_almenuAnimacio.Interval = 10;
            AlmenuElrejt�s();
            this.AutoScaleMode = AutoScaleMode.None;
            elemekAtrendezese();

        }
        private void elemekAtrendezese()
        {
            // Panelek 
            pnl_bejelentkezes.Location = new Point(
                (pnl_fopanel.Width - pnl_bejelentkezes.Width) / 2,
                (pnl_fopanel.Height - pnl_bejelentkezes.Height) / 2
            );

            pnl_bejelentkezve.Location = new Point(
                (pnl_fopanel.Width - pnl_bejelentkezve.Width) / 2,
                (pnl_fopanel.Height - pnl_bejelentkezve.Height) / 2
            );

            // C�mk�k 
            lbl_udvozlet.Location = new Point(
                (pnl_bejelentkezve.Width - lbl_udvozlet.Width) / 2,
                lbl_udvozlet.Location.Y
            );

            lbl_nev.Location = new Point(
                (pnl_bejelentkezve.Width - lbl_nev.Width) / 2,
                lbl_nev.Location.Y
            );

            lbl_hozzaferes.Location = new Point(
                (pnl_bejelentkezve.Width - lbl_hozzaferes.Width) / 2,
                lbl_hozzaferes.Location.Y
            );

            lbl_pkeszenall.Location = new Point(
                (pnl_bejelentkezve.Width - lbl_pkeszenall.Width) / 2,
                lbl_pkeszenall.Location.Y
            );

            // �dv�zl� 
            lbl_udvozlet.Text = NapszakosUdvozles();
        }

        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_fejlec_MouseDown(object sender, MouseEventArgs e)
        {
            mozgatas_egerrel = true;
            mozgatasi_pont = Cursor.Position;
            form_mozgatasi_pont = this.Location;
        }

        private void pnl_fejlec_MouseMove(object sender, MouseEventArgs e)
        {
            if (mozgatas_egerrel)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(mozgatasi_pont));
                this.Location = Point.Add(form_mozgatasi_pont, new Size(diff));
            }
        }

        private void pnl_fejlec_MouseUp(object sender, MouseEventArgs e)
        {
            mozgatas_egerrel = false;
        }

        private void btn_ablakmeret_valto_Click(object sender, EventArgs e)
        {
            ///a form �llapot�nak vizsg�lata
            switch (((int)this.WindowState))
            {
                case 0:
                    this.WindowState = FormWindowState.Maximized;
                    break;
                case 2:
                    this.WindowState = FormWindowState.Normal;
                    break;
            }
        }
        public void GyermekFormMegnyitas(Form form_gyermek, object kuldo_gomb)
        {
            bejelentkezesElrejtes();
            if (aktivForm != null)
                aktivForm.Close();
            aktivForm = form_gyermek; //aktiv�lt form �tad�sa
            form_gyermek.TopLevel = false;  ///ablak be�gyazhat�s�g be�ll�t�sa
            form_gyermek.FormBorderStyle = FormBorderStyle.None;  // ne legyen bel�l keret
            form_gyermek.Dock = DockStyle.Fill; // form beilleszt�skor teljesen t�ltse ki a teret
            this.pnl_fopanel.Controls.Add(form_gyermek); //fopanelhez adjuk a kiv�lasztott formot
            form_gyermek.Show();  // kiv�lasztott form el�hoz�sa
        }

        private void btn_utazasok_Click(object sender, EventArgs e)
        {
            AlmenuElrejt�s();
            AlmenuElohivas(pnl_UtazasokAlmenu);
        }

        private void btn_utasok_Click(object sender, EventArgs e)
        {
            AlmenuElrejt�s();
            AlmenuElohivas(pnl_UtasokAlmenu);
        }

        private void btn_minimalizalas_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // ablak minimaliz�l�sa
        }

        private void AlmenuElrejt�s()  ///almen�k elrej�se 
        {
            List<Panel> almenuk = new List<Panel> { pnl_UtazasokAlmenu, pnl_UtasokAlmenu };
            foreach (var pnl in almenuk)
            {
                pnl.Height = 0;
            }
        }

        private void AlmenuElohivas(Panel pnl)
        {
            animaltPanel = pnl;
            animacioKezdoMagassag = pnl.Height;

            // Pontosan sz�moljuk ki a c�lmagass�got, DPI-f�ggetlen�l
            animacioCelMagassag = pnl.Controls
                .OfType<KerekitettGomb>() // vagy .OfType<KerekitettGomb>() ha biztos vagy benne
                .Sum(ctrl => ctrl.Height + ctrl.Margin.Top + ctrl.Margin.Bottom);

            animacioStopper.Restart();
            tmr_almenuAnimacio.Start();
        }
        private void bejelentkezesElrejtes()
        {
            pnl_bejelentkezes.Visible = false;

            pnl_bejelentkezve.Visible = false;
        }
        private void btn_statisztika_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new Frm_Statisztika(), sender); //utaz�sok form be�gyaz�sa
            AlmenuElrejt�s();
        }

        private void btn_utazasokmegtekintese_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new Frm_UtazasokMegtekintese(), sender); //utaz�sok form be�gyaz�sa
            AlmenuElrejt�s();
        }

        private void btn_utasokMegtekintese_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new Frm_UtasokMegtekintese(), sender); //utasok form be�gyaz�sa
            AlmenuElrejt�s();
        }

        private void tmr_almenuAnimacio_Tick(object sender, EventArgs e) ///almen�k cs�sztat�sa
        {
            double elteltMs = animacioStopper.Elapsed.TotalMilliseconds;
            double progress = Math.Min(1.0, elteltMs / animacioIdotartam);


            double easedProgress = 1 - Math.Pow(1 - progress, 3);

            int aktualisMagassag = animacioKezdoMagassag +
                (int)((animacioCelMagassag - animacioKezdoMagassag) * easedProgress);

            animaltPanel.Height = aktualisMagassag;

            if (progress >= 1.0)
            {
                animaltPanel.Height = animacioCelMagassag;
                tmr_almenuAnimacio.Stop();
            }

        }

        private void btn_utazasokHozzaadasa_Click(object sender, EventArgs e)
        {

            GyermekFormMegnyitas(new frm_UtazasokHozzaadasa(), sender); //utaz�sok form be�gyaz�sa
            AlmenuElrejt�s();
        }

        private void btn_utasokHozzadasa_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new frm_UtasokHozzaadasa(), sender);
            AlmenuElrejt�s();
        }

        private void kg_belepes_Click(object sender, EventArgs e)
        {
            string felhasznalo = kszm_felhasznalo.Texts.Trim();
            string jelszo = kszm_jelszo.Texts.Trim();

            // Jelsz� hashel�se a bejelentkez�shez
            string hasheltJelszo = bejelentkezesSeged.GetSha256Hash(jelszo);

            try
            {
                using (var conn = new MySqlConnection("server=localhost;database=utazast_kezelo;uid=utazast_kezelo;pwd=utazast_kezelo1234;"))
                {
                    conn.Open();
                    // A lek�rdez�sben a hashelt jelsz�t haszn�ljuk
                    string sql = "SELECT id, felhasznalonev, jogosultsag FROM felhasznalok WHERE felhasznalonev = @nev AND jelszo = @jelszo";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev", felhasznalo);
                        cmd.Parameters.AddWithValue("@jelszo", hasheltJelszo); // Itt a hashelt jelsz�

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                int jog = reader.GetInt32("jogosultsag");



                                // A f�jlba  titkos�tott form�ban.
                                bejelentkezes.bejelentkezes.Beallit(id, felhasznalo, jelszo, jog);

                                pnl_bejelentkezes.Visible = false;
                                pnl_bejelentkezve.Visible = true;
                                lbl_nev.Text = felhasznalo;

                                lbl_nev.Location = new Point(
                                    (pnl_bejelentkezve.Width - lbl_nev.Width) / 2,
                                    lbl_nev.Location.Y
                                );
                                if (bejelentkezes.bejelentkezes.Jogosultsag == 0)
                                    lbl_hozzaferes.Text = "�nnek korl�tozott hozz�f�r�se van.";
                                else
                                    lbl_hozzaferes.Text = "Teljes �rt�k� hozz�f�r�se van.";

                                var adatok = new bejelentkezesiAdatok
                                {
                                    Id = id,
                                    Felhasznalonev = felhasznalo,
                                    Jelszo = TitkositasSeged.Titkosit(jelszo), // Itt a sima jelsz�t titkos�tjuk f�jlba ment�shez
                                    Jogosultsag = jog,
                                    MaradBejelentkezve = kg_bejelentkezvemarad.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be
                                };
                                bejelentkezesSeged.Mentes(adatok);
                                lbl_hozzaferes.Location = new Point(
                                      (pnl_bejelentkezve.Width - lbl_hozzaferes.Width) / 2,
                                      lbl_hozzaferes.Location.Y
                                  );
                                ertesitesek();
                            }
                            else
                            {
                                MessageBox.Show("Hib�s felhaszn�l�n�v vagy jelsz�!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem siker�lt kapcsol�dni az adatb�zishoz.", "Adatb�zis el�r�s");
                else
                    MessageBox.Show(ex.Message);
            }
        }
        private void kg_kilepes_Click(object sender, EventArgs e)
        {
            bejelentkezes.bejelentkezes.Kijelentkezes();
            lbl_nev.Text = "";
            pnl_bejelentkezve.Visible = false;
            pnl_bejelentkezes.Visible = true;
            kszm_jelszo.Texts = "";
            // a jsont t�rl�s
            bejelentkezesSeged.Torles();
        }

        private void pnl_fopanel_Resize(object sender, EventArgs e)
        {
            elemekAtrendezese();
        }



        private void ertesitesek()
        {


            int lejaroDb = 0;
            int erdeklodikDb = 0;

            string connStr = "server=localhost;database=utazast_kezelo;uid=utazast_kezelo;pwd=utazast_kezelo1234;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // 1. lejaro_okmanyok sorok sz�ma
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM lejaro_okmanyok;", conn))
                {
                    lejaroDb = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // 2. elofoglalas �rdekl�dik sorok sz�ma
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM elofoglalas WHERE allapot = '�rdekl�dik';", conn))
                {
                    erdeklodikDb = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            // 3. �rtes�t�s be�ll�t�sa a gombon
            btn_ertesitesek.ErtesitesMutatasa = true;
            btn_ertesitesek.ErtesitesSzam = lejaroDb + erdeklodikDb;
        }

        private void frm_foForm_Load(object sender, EventArgs e)
        {

            var adatok = bejelentkezesSeged.Betoltes(); // bet�lti json f�jlb�l a t�rolt adatot

            if (adatok != null && adatok.MaradBejelentkezve)
            {
                // A f�jlb�l visszafejtett jelsz�t hashelj�k az adatb�zis ellen�rz�s�hez
                string visszafejtettJelszo = TitkositasSeged.Visszafejt(adatok.Jelszo);
                string hasheltJelszoEllenorzesre = bejelentkezesSeged.GetSha256Hash(visszafejtettJelszo);

                try
                {
                    using (var conn = new MySqlConnection("server=localhost;database=utazast_kezelo;uid=utazast_kezelo;pwd=utazast_kezelo1234;"))
                    {
                        conn.Open();
                        // A lek�rdez�sben a hashelt jelsz�t haszn�ljuk
                        string sql = "SELECT id, jogosultsag FROM felhasznalok WHERE felhasznalonev = @nev AND jelszo = @jelszo";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@nev", adatok.Felhasznalonev);
                            cmd.Parameters.AddWithValue("@jelszo", hasheltJelszoEllenorzesre); // Itt a hashelt jelsz�

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int id = reader.GetInt32("id");
                                    int jog = reader.GetInt32("jogosultsag");

                                    // A bejelentkezett felhaszn�l� adatait t�rolhatjuk a visszafejtett jelsz�val, ha sz�ks�ges
                                    bejelentkezes.bejelentkezes.Beallit(id, adatok.Felhasznalonev, visszafejtettJelszo, jog);

                                    pnl_bejelentkezve.Visible = true;
                                    pnl_bejelentkezes.Visible = false;


                                    lbl_nev.Text = adatok.Felhasznalonev;
                                    lbl_hozzaferes.Text = jog == 0
                                        ? "�nnek korl�tozott hozz�f�r�se van."
                                        : "Teljes �rt�k� hozz�f�r�se van.";
                                    elemekAtrendezese();
                                }
                                else
                                {
                                    // Hib�s jelsz� vagy felhaszn�l�, nem jelentkez�nk be automatikusan
                                    bejelentkezesSeged.Torles();
                                    MessageBox.Show("A mentett bejelentkez�si adatok �rv�nytelenek. K�rlek jelentkezz be �jra.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    pnl_bejelentkezes.Visible = true;
                                }
                            }
                        }
                    }
                    ertesitesek();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba t�rt�nt az automatikus bejelentkez�s sor�n:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string NapszakosUdvozles()
        {
            int ora = DateTime.Now.Hour;

            if (ora >= 5 && ora < 10)
            {
                return "J� reggelt";
            }
            else if (ora >= 10 && ora < 18)
            {
                return "Sz�p napot";
            }
            else
            {
                return "Sz�p est�t k�v�nok";
            }
        }

        private void lbl_utazas_kezelo_Click(object sender, EventArgs e)
        {
            if (aktivForm != null)
            {
                aktivForm.Close();
                aktivForm = null;
            }

            if (bejelentkezes.bejelentkezes.Felhasznalonev != null)
                pnl_bejelentkezve.Visible = true;
            else
                pnl_bejelentkezes.Visible = true;
        }

        private void kszm_vissza_Click(object sender, EventArgs e)
        {

            pnl_bejelentkezes.Visible = true;
        }

        private void pnl_fopanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            Control eltavolitottControl = e.Control;//ha bez�r�dik a ment�s az utas hozz�ad�s ut�n ne �res k�perny� fogadja a felhaszn�l�t
                                                    // Csak akkor mutasd �jra a bejelentkezett panelt, ha nem ker�lt be �j vez�rl�/form
            if (eltavolitottControl.GetType() == typeof(frm_UtasokHozzaadasa))
            {
                // Ha nincs t�bb control a fopanelen, akkor jelen�ts�k meg �jra a bejelentkez�s ut�ni panelt
                if (pnl_fopanel.Controls.Count <= 3)
                {
                    pnl_bejelentkezve.Visible = true;
                }
            }

        }

        private void pnl_fopanel_ControlAdded(object sender, ControlEventArgs e)
        {
            pnl_bejelentkezve.Visible = false;
        }

        private void btn_elofoglalasok_Click(object sender, EventArgs e)
        {
            var elofoglalasForm = new frm_Elofoglalasok();
            elofoglalasForm.FoForm = this; // �tadjuk a hivatkoz�st a f�formra
            GyermekFormMegnyitas(elofoglalasForm, sender); // <-- EZT kell �tadni
            AlmenuElrejt�s();
        }

        private void btn_ertesitesek_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new frm_ertesitesek(), sender); //utaz�sok form be�gyaz�sa
            AlmenuElrejt�s();
        }
        private string GetMySqlDumpPath()
        {
            // Ha van elmentett �tvonal, �s l�tezik a f�jl, azt haszn�ljuk
            if (File.Exists(configFile))
            {
                string savedPath = File.ReadAllText(configFile).Trim();
                if (File.Exists(savedPath))
                    return savedPath;
            }

            // 1. Megpr�b�ljuk registryb�l kiolvasni WAMP telep�t�si mapp�j�t
            string wampPath = null;
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WampServer"))
            {
                if (key != null)
                    wampPath = key.GetValue("InstallDir") as string;
            }
            if (string.IsNullOrEmpty(wampPath))
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\WampServer"))
                {
                    if (key != null)
                        wampPath = key.GetValue("InstallDir") as string;
                }
            }

            // 2. Ha van WAMP path, megkeress�k a mysql k�nyvt�rat
            if (!string.IsNullOrEmpty(wampPath))
            {
                string mysqlBinFolder = Path.Combine(wampPath, "bin", "mysql");
                if (Directory.Exists(mysqlBinFolder))
                {
                    string[] mysqlDirs = Directory.GetDirectories(mysqlBinFolder);
                    if (mysqlDirs.Length > 0)
                    {
                        string mysqldumpPath = Path.Combine(mysqlDirs[0], "bin", "mysqldump.exe");
                        if (File.Exists(mysqldumpPath))
                        {
                            File.WriteAllText(configFile, mysqldumpPath); // elmentj�k
                            return mysqldumpPath;
                        }
                    }
                }
            }

            // 3. Ha semmit nem tal�ltunk, felhaszn�l�t�l k�r�nk be �tvonalat
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Keresd meg a mysqldump.exe f�jlt";
                ofd.Filter = "mysqldump.exe|mysqldump.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(configFile, ofd.FileName);
                    return ofd.FileName;
                }
            }

            return null;
        }
        private void btn_biztonsagiMentes_Click(object sender, EventArgs e)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show("A ment�shez el�bb be kell jelentkeznie a f�oldalon.",
                                "Bejelentkez�s sz�ks�ges",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 1)
            {
                AdatbazisMentes();

            }
            else
                MessageBox.Show(
        "�n oper�tor jogosults�ggal van bejelentkezve.\n" +
        "Az el�foglal�sok m�dos�t�sa �s t�rl�se csak adminisztr�tor sz�m�ra enged�lyezett.",
        "�r�si jog megtagadva",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
    );


        }
        public void AdatbazisMentes()
        {
            string mysqldumpPath = GetMySqlDumpPath();
            if (mysqldumpPath == null)
            {
                MessageBox.Show("Nem tal�lhat� a mysqldump.exe. Add meg manu�lisan!",
                                "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "SQL f�jl (*.sql)|*.sql";
                sfd.Title = "Biztons�gi ment�s hely�nek kiv�laszt�sa";
                sfd.FileName = "adatbazis_mentes_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".sql";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fajlnev = sfd.FileName;

                    try
                    {
                        string szerver = "localhost";
                        string felhasznalo = "utazast_kezelo";
                        string jelszo = "utazast_kezelo1234";  // ha nincs jelsz�, �resen hagyhat�
                        string adatbazis = "utazast_kezelo";

                        // FONTOS: adjuk meg a karakterk�dol�st is!
                        string arguments = $"--default-character-set=utf8 -h {szerver} -u {felhasznalo} -p{jelszo} {adatbazis}";

                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = mysqldumpPath,
                            Arguments = arguments,
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            StandardOutputEncoding = Encoding.UTF8 // Ez a kulcs!
                        };

                        using (Process process = Process.Start(psi))
                        using (StreamReader reader = process.StandardOutput)
                        using (StreamWriter writer = new StreamWriter(fajlnev, false, Encoding.UTF8))
                        {
                            string output = reader.ReadToEnd();
                            writer.Write(output);
                        }

                        MessageBox.Show("Biztons�gi ment�s elk�sz�lt:\n" + fajlnev,
                                        "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba t�rt�nt a ment�s sor�n:\n" + ex.Message,
                                        "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void kg_segitseg_Click(object sender, EventArgs e)
        {

            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show("A megtekint�s�hez el�bb be kell jelentkeznie a f�oldalon.",
                                "Bejelentkez�s sz�ks�ges",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            try
            {
                string pdfPath = Path.Combine(Application.StartupPath, "hasznalati_utmutato.pdf");

                if (File.Exists(pdfPath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = pdfPath,
                        UseShellExecute = true // �gy az alap�rtelmezett PDF olvas�val ny�lik meg
                    });
                }
                else
                {
                    MessageBox.Show("A PDF f�jl nem tal�lhat�:\n" + pdfPath,
                                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem siker�lt megnyitni a PDF-et:\n" + ex.Message,
                                "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_utazas_kezelo_MouseEnter(object sender, EventArgs e)
        {
            lbl_utazas_kezelo.ForeColor = Color.DarkViolet;
        }

        private void lbl_utazas_kezelo_MouseLeave(object sender, EventArgs e)
        {
            lbl_utazas_kezelo.ForeColor = Color.Black;
        }
    }
}