using System;
using System.Drawing;
using Timer = System.Windows.Forms.Timer;


namespace Projekt_feladat.egyeni_vezerlok
{
    public class MozgoLabel : UserControl
    {
        private readonly Panel pnl_clip;
        private readonly Label lbl_szoveg;
        private readonly Timer tmr_scroll;

        private int sebesseg = 1;
        public int Sebesseg
        {
            get => sebesseg;
            set => sebesseg = Math.Max(1, value);
        }

        private string szoveg = "";
        public string Szoveg
        {
            get => szoveg;
            set
            {
                szoveg = value;
                lbl_szoveg.Text = szoveg;
                // Itt frissítsd a label méretét is a szöveghez
                lbl_szoveg.Width = TextRenderer.MeasureText(lbl_szoveg.Text, lbl_szoveg.Font).Width;
                FrissitScrollozas();
            }
        }

        public MozgoLabel()
        {
            pnl_clip = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = false,
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Padding = new Padding(0),
                Margin = new Padding(0)

            };

            lbl_szoveg = new Label
            {
                AutoSize = false, // Maradjon false
                Location = new Point(0, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "fdf",
                Font = new Font("Arial", 12, FontStyle.Bold), // Példa: Állítsd be a kívánt betűtípust és méretet
                ForeColor = Color.Black // Példa: Állítsd be a kívánt színt

            };

            tmr_scroll = new Timer { Interval = 30 };
            tmr_scroll.Tick += Tmr_scroll_Tick;

            pnl_clip.Controls.Add(lbl_szoveg);
            Controls.Add(pnl_clip);
        }

        private void Tmr_scroll_Tick(object? sender, EventArgs e)
        {
            lbl_szoveg.Left -= sebesseg;
            if (lbl_szoveg.Right < 0)
            {
                lbl_szoveg.Left = pnl_clip.Width;
            }
        }

        private void FrissitScrollozas()
        {
            int szovegSzelesseg = TextRenderer.MeasureText(lbl_szoveg.Text, lbl_szoveg.Font).Width;

            if (szovegSzelesseg > pnl_clip.Width)
            {
                lbl_szoveg.Left = pnl_clip.Width;
                tmr_scroll.Start();
            }
            else
            {
                tmr_scroll.Stop();
                lbl_szoveg.Left = 0;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            FrissitScrollozas();
        }
    }
}