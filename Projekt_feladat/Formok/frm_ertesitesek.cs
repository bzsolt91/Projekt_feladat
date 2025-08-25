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
        }

        private void frm_ertesitesek_Resize(object sender, EventArgs e)
        {
            ablakUjrarajzolas();
        }
    }
}
