using Projekt_feladat.Properties.Formok;

namespace Projekt_feladat
{
    public partial class frm_foForm : Form
    {
        /************   Fejl�c mozgat�shoz sz�ks�ges v�ltoz�k    ************/
        private bool mozgatas_egerrel = false; //mozgat�si st�tusz r�gz�t�se
        private Point mozgatasi_pont; //a kurzor �j poz�ci�ja ahov� az ablak mozgat�dik
        private Point form_mozgatasi_pont; //
        /************************/

        private Form aktivForm;
        private Panel animaltPanel;
        public frm_foForm()
        {

            InitializeComponent();
            AlmenuElrejt�s();

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
            ///a form �llapot�nak vizsg�lata(maximaliz�lt minimaliz�lt)
            switch (((int)this.WindowState))
            {
                case 0:
                    this.WindowState = FormWindowState.Maximized; // ha norm�l akkor legyen maximaliz�lt
                    break;
                case 2:
                    this.WindowState = FormWindowState.Normal; // ha maximaliz�lt legyen norm�l
                    break;
            }
        }
        private void GyermekFormMegnyitas(Form form_gyermek, object kuldo_gomb)
        {
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

        private void roundedTextbox1_TextChanged(object sender, EventArgs e)
        {

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
            tmr_almenuAnimacio.Start();
        }

        private void btn_statisztika_Click(object sender, EventArgs e)
        {
            AlmenuElrejt�s();

        }

        private void btn_utazasokmegtekintese_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new Frm_Utazasok(), sender); //utaz�sok form be�gyaz�sa
            AlmenuElrejt�s();
        }

        private void btn_utasokMegtekintese_Click(object sender, EventArgs e)
        {
            GyermekFormMegnyitas(new Frm_Utasok(), sender); //utasok form be�gyaz�sa
            AlmenuElrejt�s();
        }

        private void tmr_almenuAnimacio_Tick(object sender, EventArgs e) ///almen�k cs�sztat�sa
        {
            for (int i = 0; i < animaltPanel.Controls.OfType<Button>().Count() * 41; i++)
                animaltPanel.Height = i;
            tmr_almenuAnimacio.Stop();

        }
    }
}
