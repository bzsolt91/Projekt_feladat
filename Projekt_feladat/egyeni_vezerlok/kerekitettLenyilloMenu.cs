using Projekt_feladat.Properties;
using Label = System.Windows.Forms.Label;

/*
 * Modernebb dizájnt alkalmazó ComboBox vezérlő
 * 
 * -lekerekíthető
 * -animált
 * 
 * 
 * 
 * */


namespace Projekt_feladat.egyeni_vezerlok
{
    public partial class kerekitettLenyilloMenu : UserControl
    {

        int i = 0;
        public string[] adat;
        public string[] adatForras
        {
            get => adat;
            set
            {

                foreach (var item in value)
                {
                    Label label = new();
                    label.Text = item;
                    label.ForeColor = Color.White;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Height = 25;
                    label.Width = flp_items.Width;
                    label.MouseClick += new MouseEventHandler(Label_selected);
                    flp_items.Controls.Add(label);
                }

                adat = value;
                Invalidate();
            }

        }
        public class ModositottFLPanel : FlowLayoutPanel
        {
            protected override System.Windows.Forms.CreateParams CreateParams
            {
                get
                {
                    var cp = base.CreateParams;
                    cp.Style &= ~0x100000; // WS_HSCROLL eltávolítása
                    return cp;
                }
            }
            protected override void OnLayout(LayoutEventArgs levent)
            {
                base.OnLayout(levent);
                this.HorizontalScroll.Maximum = 0;
                this.AutoScroll = false;  // Megakadályozzuk az automatikus vízszintes görgetést
                this.VerticalScroll.Enabled = true;  // Csak a függőleges görgetés maradjon
                this.AutoScroll = true;  // Visszakapcsoljuk az automatikus görgetést, de csak függőleges irányban
            }
        }


        public string ComboText
        {
            get => lb_text.Text;
            set
            {
                lb_text.Text = value;
                Invalidate();
            }
        }



        public int Radius
        {
            get => pnl_title.SarkokLekerekitese;
            set
            {
                pnl_title.SarkokLekerekitese = value;
                Invalidate();
            }
        }


        public Color TitlePanelFelsoSzin
        {
            get => pnl_title.SzinatmenetFelsoSzine;
            set
            {
                pnl_title.SzinatmenetFelsoSzine = value;
                Invalidate();
            }
        }
        public Color TitlePanelAlsoSzin
        {
            get => pnl_title.SzinatmenetAlsoSzine;
            set
            {
                pnl_title.SzinatmenetAlsoSzine = value;
                Invalidate();
            }
        }

        public Color ItemPanelFelsoSzin
        {
            get => pnl_item.SzinatmenetFelsoSzine;
            set
            {
                pnl_item.SzinatmenetFelsoSzine = value;
                Invalidate();
            }
        }
        public Color ItemPanelAlosSzin
        {
            get => pnl_item.SzinatmenetAlsoSzine;
            set
            {
                pnl_item.SzinatmenetAlsoSzine = value;
                Invalidate();
            }
        }
        public Color TitleLabelSzin
        {
            get => lb_text.ForeColor;
            set
            {
                lb_text.ForeColor = value;
                lb_diszcsik.BackColor = value;
                Invalidate();
            }
        }
        private void Label_selected(object? sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            foreach (var item in flp_items.Controls.OfType<Label>())
            {
                item.BackColor = Color.FromArgb(30, 32, 34);
                label.BackColor = Color.FromArgb(46, 239, 221);
                lb_text.Text = label.Text;
                i = 0;
                timer2.Start();
            }


        }

        public kerekitettLenyilloMenu()
        {

            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

        }



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private void picbtn_nyil_Click(object sender, EventArgs e)
        {
            i = 0;
            if (Height <= 60)
            {
                timer1.Start();
            }
            else timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picbtn_nyil.Image = Resources.up_arrow;
            if (Height < 269)
            {
                Height = Height + i;
                i += 1;
            }
            else timer1.Stop();
            pnl_item.SarkokLekerekitese = 30;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picbtn_nyil.Image = Resources.arrow_down;
            if (Height > 61)
            {
                Height = Height - i;
                i += 1;
            }
            else timer2.Stop();
            pnl_item.SarkokLekerekitese = 30;
        }


    }
}