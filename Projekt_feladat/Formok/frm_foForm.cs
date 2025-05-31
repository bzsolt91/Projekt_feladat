using Projekt_feladat.Formok;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace Projekt_feladat
{
    public partial class frm_foForm : Form
    {





        /************   Fejléc mozgatáshoz szükséges változók    ************/
        private bool mozgatas_egerrel = false; //mozgatási státusz rögzítése
        private Point mozgatasi_pont; //a kurzor új pozíciója ahová az ablak mozgatódik
        private Point form_mozgatasi_pont; //
        /************************/

        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);
        private int celMagassag = 0;
        private int lepes = 2;

        private Stopwatch animacioStopper = new Stopwatch();
        private int animacioKezdoMagassag;
        private int animacioCelMagassag;
        private int animacioIdotartam = 200; // animáció idõtartama ms-ban
    

        private Form aktivForm;
        private Panel animaltPanel;
        public frm_foForm()
        {

            InitializeComponent();
            tmr_almenuAnimacio.Interval = 10;
            AlmenuElrejtés();
            this.AutoScaleMode = AutoScaleMode.None;


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
            ///a form állapotának vizsgálata(maximalizált minimalizált)
            switch (((int)this.WindowState))
            {
                case 0:
                    this.WindowState = FormWindowState.Maximized; // ha normál akkor legyen maximalizált
                    break;
                case 2:
                    this.WindowState = FormWindowState.Normal; // ha maximalizált legyen normál
                    break;
            }
        }
        private void GyermekFormMegnyitas(Form form_gyermek, object kuldo_gomb)
        {
            if (aktivForm != null)
                aktivForm.Close();
            aktivForm = form_gyermek; //aktivált form átadása
            form_gyermek.TopLevel = false;  ///ablak beágyazhatóság beállítása
            form_gyermek.FormBorderStyle = FormBorderStyle.None;  // ne legyen belül keret
            form_gyermek.Dock = DockStyle.Fill; // form beillesztéskor teljesen töltse ki a teret
            this.pnl_fopanel.Controls.Add(form_gyermek); //fopanelhez adjuk a kiválasztott formot
            form_gyermek.Show();  // kiválasztott form elõhozása

        }

        private void btn_utazasok_Click(object sender, EventArgs e)
        {
            AlmenuElrejtés();
            AlmenuElohivas(pnl_UtazasokAlmenu);

        }

        private void btn_utasok_Click(object sender, EventArgs e)
        {
            AlmenuElrejtés();
            AlmenuElohivas(pnl_UtasokAlmenu);

        }

        private void btn_minimalizalas_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // ablak minimalizálása
        }

        private void roundedTextbox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AlmenuElrejtés()  ///almenük elrejése 
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
            animacioCelMagassag = pnl.Controls.OfType<Button>().Count() * 54;
            animacioStopper.Restart();
            tmr_almenuAnimacio.Start();
        }




        private void btn_statisztika_Click(object sender, EventArgs e)
        {
            AlmenuElrejtés();

        }

        private void btn_utazasokmegtekintese_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new Frm_UtazasokMegtekintese(), sender); //utazások form beágyazása
            AlmenuElrejtés();
        }

        private void btn_utasokMegtekintese_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new Frm_UtasokMegtekintese(), sender); //utasok form beágyazása
            AlmenuElrejtés();
        }

        private void tmr_almenuAnimacio_Tick(object sender, EventArgs e) ///almenük csúsztatása
        {
           


            double elteltMs = animacioStopper.Elapsed.TotalMilliseconds;
            double progress = Math.Min(1.0, elteltMs / animacioIdotartam);

           
            double easedProgress = 1 - Math.Pow(1 - progress, 3);

            int aktualisMagassag = animacioKezdoMagassag +
                (int)((animacioCelMagassag - animacioKezdoMagassag) * easedProgress);

            animaltPanel.Height = aktualisMagassag;

            if (progress >= 1.0)
            {
                tmr_almenuAnimacio.Stop();
            }

        }
    }
}