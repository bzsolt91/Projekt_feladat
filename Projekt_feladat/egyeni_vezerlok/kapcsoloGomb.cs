using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Projekt_feladat.egyeni_vezerlok
{
    public partial class KapcsoloGomb : UserControl
    {
        public enum KapcsoloAllas { Ki, Kozep, Be }

        private Color bekapcsoltHatterSzine = Color.MediumSlateBlue;
        private Color bekapcsoltKapcsoloSzine = Color.WhiteSmoke;
        private Color kikapcsoltHatterSzine = Color.Gray;
        private Color kikapcsoltKapcsoloSzine = Color.Gainsboro;
        private Color kozepsoHatterSzine = Color.Orange;
        private Color kozepsoKapcsoloSzine = Color.WhiteSmoke;
        private bool szilardStilusAktivalva = true;
        private KapcsoloAllas aktualisAllas = KapcsoloAllas.Ki;
        private bool ketAllasuModAktiv = false;
        private Color? hatterKitoltoSzin = null;
        private Timer animacioIdozito;
        private int aktualisPozicio;
        private int celPozicio;
        private const int animacioLepesMeret = 4;

        private bool egerFelettVan = false;

        public KapcsoloGomb()
        {
            this.MinimumSize = new Size(70, 22);
            this.DoubleBuffered = true;

            // Animáció időzítő
            animacioIdozito = new Timer();
            animacioIdozito.Interval = 15;
            animacioIdozito.Tick += AnimacioIdozito_Tick;

            aktualisPozicio = SzamoljPoziciot(aktualisAllas);
            celPozicio = aktualisPozicio;

            // Hover események
            this.MouseEnter += (s, e) => { egerFelettVan = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { egerFelettVan = false; this.Invalidate(); };
            this.Cursor = Cursors.Hand;
        }

        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        [DefaultValue(true)]
        public bool SzilardStilusAktivalva
        {
            get { return szilardStilusAktivalva; }
            set { szilardStilusAktivalva = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public Color? HatterKitoltoSzin
        {
            get => hatterKitoltoSzin;
            set { hatterKitoltoSzin = value; Invalidate(); }
        }

        [Category("Custom Properties")]
        public KapcsoloAllas AktualisAllas
        {
            get { return aktualisAllas; }
            set
            {
                if (aktualisAllas != value)
                {
                    aktualisPozicio = SzamoljPoziciot(aktualisAllas);
                    celPozicio = SzamoljPoziciot(value);
                    aktualisAllas = value;
                    animacioIdozito.Start();
                    OnKapcsoloAllasValtozott(EventArgs.Empty);
                }
            }
        }

        [Category("Custom Properties")]
        [DefaultValue(false)]
        public bool KetAllasuModAktiv
        {
            get { return ketAllasuModAktiv; }
            set
            {
                if (ketAllasuModAktiv != value)
                {
                    ketAllasuModAktiv = value;
                    if (ketAllasuModAktiv && aktualisAllas == KapcsoloAllas.Kozep)
                        AktualisAllas = KapcsoloAllas.Ki;

                    this.Invalidate();
                }
            }
        }

        public event EventHandler KapcsoloAllasValtozott;
        protected virtual void OnKapcsoloAllasValtozott(EventArgs e)
        {
            KapcsoloAllasValtozott?.Invoke(this, e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (KetAllasuModAktiv)
            {
                AktualisAllas = aktualisAllas == KapcsoloAllas.Ki ? KapcsoloAllas.Be : KapcsoloAllas.Ki;
            }
            else
            {
                AktualisAllas = aktualisAllas switch
                {
                    KapcsoloAllas.Ki => KapcsoloAllas.Kozep,
                    KapcsoloAllas.Kozep => KapcsoloAllas.Be,
                    KapcsoloAllas.Be => KapcsoloAllas.Ki,
                    _ => KapcsoloAllas.Ki
                };
            }
        }

        private void AnimacioIdozito_Tick(object sender, EventArgs e)
        {
            if (aktualisPozicio < celPozicio)
            {
                aktualisPozicio += animacioLepesMeret;
                if (aktualisPozicio >= celPozicio)
                {
                    aktualisPozicio = celPozicio;
                    animacioIdozito.Stop();
                }
            }
            else if (aktualisPozicio > celPozicio)
            {
                aktualisPozicio -= animacioLepesMeret;
                if (aktualisPozicio <= celPozicio)
                {
                    aktualisPozicio = celPozicio;
                    animacioIdozito.Stop();
                }
            }
            else
            {
                animacioIdozito.Stop();
            }

            this.Invalidate();
        }

        private int SzamoljPoziciot(KapcsoloAllas allas)
        {
            int kapcsoloMeret = this.Height - 5;
            return allas switch
            {
                KapcsoloAllas.Be => this.Width - this.Height + 1,
                KapcsoloAllas.Kozep => (this.Width / 2) - (kapcsoloMeret / 2),
                KapcsoloAllas.Ki => 2,
                _ => 2
            };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            int kapcsoloMeret = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // --- háttérszín meghatározása ---
            Color kitolto = hatterKitoltoSzin ?? this.Parent?.BackColor ?? SystemColors.Control;

            // Ha van kézzel megadott szín → töltsük ki a hátteret
            if (hatterKitoltoSzin.HasValue)
            {
                using (SolidBrush b = new SolidBrush(kitolto))
                {
                    pevent.Graphics.FillRectangle(b, this.ClientRectangle);
                }
            }
            // ha nincs → ne csináljunk Clear-t, hadd látszódjon át a szülő panel

            // --- állapot szerinti színek ---
            Color hatterSzine;
            Color kapcsoloSzine;

            switch (aktualisAllas)
            {
                case KapcsoloAllas.Be:
                    hatterSzine = bekapcsoltHatterSzine;
                    kapcsoloSzine = bekapcsoltKapcsoloSzine;
                    break;
                case KapcsoloAllas.Kozep:
                    hatterSzine = kozepsoHatterSzine;
                    kapcsoloSzine = kozepsoKapcsoloSzine;
                    break;
                case KapcsoloAllas.Ki:
                default:
                    hatterSzine = kikapcsoltHatterSzine;
                    kapcsoloSzine = kikapcsoltKapcsoloSzine;
                    break;
            }

            // Hover fényesítés
            if (egerFelettVan)
                hatterSzine = ControlPaint.Light(hatterSzine, 0.2f);

            // Kapcsoló hátterének rajzolása
            if (szilardStilusAktivalva)
                pevent.Graphics.FillPath(new SolidBrush(hatterSzine), HozzaLetreKapcsoloUtvonalat());
            else
                pevent.Graphics.DrawPath(new Pen(hatterSzine, 2), HozzaLetreKapcsoloUtvonalat());

            // Kapcsoló kör kirajzolása
            pevent.Graphics.FillEllipse(new SolidBrush(kapcsoloSzine),
                new Rectangle(aktualisPozicio, 2, kapcsoloMeret, kapcsoloMeret));
        }
        private GraphicsPath HozzaLetreKapcsoloUtvonalat()
        {
            int sarokMeret = this.Height - 1;
            Rectangle balSarok = new Rectangle(0, 0, sarokMeret, sarokMeret);
            Rectangle jobbSarok = new Rectangle(this.Width - sarokMeret - 2, 0, sarokMeret, sarokMeret);

            GraphicsPath utvonal = new GraphicsPath();
            utvonal.StartFigure();
            utvonal.AddArc(balSarok, 90, 180);
            utvonal.AddArc(jobbSarok, 270, 180);
            utvonal.CloseFigure();

            return utvonal;
        }
    }
}
