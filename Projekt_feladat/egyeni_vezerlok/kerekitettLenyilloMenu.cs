using Projekt_feladat.Properties;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using Timer = System.Windows.Forms.Timer;

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



        private ClickOutsideMessageFilter? clickOutsideFilter;
        private Label kivalasztottLabel = null!;
        int i = 0;
        public string[] adat;

        private bool nyitva = false;
        private Timer animacioTimer = new Timer();
        private int celMagassag;
        private int animacioLepes = 10;
        /*kattintási eseménsy*/
        public class ElemKivalasztvaEventArgs : EventArgs
        {
            public string Ertek { get; }
            public int Index { get; }
            public object? Tag { get; } // opcionálisan használható extra adat

            public ElemKivalasztvaEventArgs(string ertek, int index, object? tag = null)
            {
                Ertek = ertek;
                Index = index;
                Tag = tag;
            }
        }

        public event EventHandler<ElemKivalasztvaEventArgs>? ElemKivalasztva;
        /*********/
        public string[] adatForras
        {
            get => adat;
            set
            {
                flp_items.BackColor = Color.WhiteSmoke;
                pnl_item.BackColor = Color.WhiteSmoke; // ha maga 
                foreach (var item in value)
                {
                    Label label = new();
                    label.Text = item;
                    label.ForeColor = Color.Black; // <<< Szöveg legyen fekete
                    label.BackColor = Color.Transparent; // <<< Háttér legyen átlátszó
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Height = 25;
                    label.Width = flp_items.Width;
                    label.MouseClick += new MouseEventHandler(Label_selected);

                    label.MouseEnter += (s, e) =>
                    {
                        label.BackColor = Color.LightGray;
                    };

                    label.MouseLeave += (s, e) =>
                    {
                        if (label != kivalasztottLabel)
                        {
                            label.BackColor = Color.WhiteSmoke;
                        }
                        else
                        {
                            label.BackColor = Color.BlueViolet;
                        }
                    };

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
                    cp.Style &= ~0x100000; // WS_HSCROLL kikapcsolása
                    return cp;
                }
            }
            protected override void OnLayout(LayoutEventArgs levent)
            {
                base.OnLayout(levent);
                this.HorizontalScroll.Maximum = 0;
                this.HorizontalScroll.Visible = false; // <<< FONTOS!
                this.HorizontalScroll.Enabled = false; // <<< FONTOS!
                this.AutoScroll = false;
                this.VerticalScroll.Visible = true;
                this.VerticalScroll.Enabled = true;
                this.AutoScroll = true;
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


        public Color CimPanelFelsoSzin
        {
            get => pnl_title.SzinatmenetFelsoSzine;
            set
            {
                pnl_title.SzinatmenetFelsoSzine = value;
                Invalidate();
            }
        }
        public Color CimPanelAlsoSzin
        {
            get => pnl_title.SzinatmenetAlsoSzine;
            set
            {
                pnl_title.SzinatmenetAlsoSzine = value;
                Invalidate();
            }
        }

        public float KeretVastagsag
        {
            get => pnl_title.KeretVastagsag;
            set { pnl_title.KeretVastagsag = value; this.Invalidate(); }
        }



        public Color KeretSzin
        {
            get => pnl_title.KeretSzin;
            set { pnl_title.KeretSzin = value; this.Invalidate(); }
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
                // lb_emojy.ForeColor = value;

                Invalidate();
            }
        }
        public Image Ikon
        {
            get => picbtn_nyil.BackgroundImage;
            set
            {
                picbtn_nyil.BackgroundImage = value;
                picbtn_nyil.Invalidate(); // Invalidate the PictureBox
                this.Invalidate(); // Keep the UserControl invalidate as well
            }
        }
        public bool Nyil
        {

            set
            {
                // picbtn_nyil.BackgroundImage = value;
                picbtn_nyil.Invalidate(); // Invalidate the PictureBox
                this.Invalidate(); // Keep the UserControl invalidate as well
                value = true;
            }
        }
        private void Label_selected(object? sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            foreach (var item in flp_items.Controls.OfType<Label>())
            {
                item.BackColor = Color.WhiteSmoke; // Minden elem visszafehérítése
                item.ForeColor = Color.Black; // Szövegszín vissza feketére
            }

            // Kattintott labelt beállítjuk kiválasztottnak
            label.BackColor = Color.BlueViolet;
            label.ForeColor = Color.White;
            kivalasztottLabel = label;

            lb_text.Text = label.Text;
            i = 0;
          //  int index = (int)label.Tag;

            ElemKivalasztva?.Invoke(this,
                new ElemKivalasztvaEventArgs(label.Text, 0));

            // === Panel bezárása kattintás után ===
            if (nyitva)
            {
                nyitva = false;
                celMagassag = 61;
                animacioTimer.Start();

                if (clickOutsideFilter != null)
                {
                    Application.RemoveMessageFilter(clickOutsideFilter);
                    clickOutsideFilter = null;
                }
            }
        }
        private void FormMouseDownHandler(object sender, MouseEventArgs e)
        {
            // Ellenőrizzük, hogy a kattintás nem a lenyílóban történt
            if (!this.Bounds.Contains(this.Parent.PointToClient(Cursor.Position)))
            {
                if (nyitva)
                {
                    nyitva = false;
                    celMagassag = 61; // zárt magasság
                    animacioTimer.Start();
                    pnl_item.Visible = false;

                    // Esemény leiratkozás, hogy ne hallgassuk feleslegesen tovább
                    if (this.FindForm() != null)
                        this.FindForm().MouseDown -= FormMouseDownHandler;
                }
            }
        }
        private void Click(object sender, EventArgs e)
        {
            nyitva = !nyitva;
            celMagassag = nyitva ? 269 : 61;
            animacioTimer.Start();
            pnl_item.Visible = true;

            if (nyitva)
            {
                clickOutsideFilter = new ClickOutsideMessageFilter(this, () =>
                {
                    nyitva = false;
                    celMagassag = 61;
                    animacioTimer.Start();
                    pnl_item.Visible = false;
                    if (clickOutsideFilter != null)
                    {
                        Application.RemoveMessageFilter(clickOutsideFilter);
                        clickOutsideFilter = null;
                    }
                });
                Application.AddMessageFilter(clickOutsideFilter);
            }
            else
            {
                if (clickOutsideFilter != null)
                {
                    Application.RemoveMessageFilter(clickOutsideFilter);
                    clickOutsideFilter = null;
                }
            }
        }




        public kerekitettLenyilloMenu()
        {

            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            animacioTimer.Interval = 5;
            animacioTimer.Tick += AnimacioFrissitese;

        }



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            this.Invalidate();
        }




        private void AnimacioFrissitese(object? sender, EventArgs e)
        {
            int kulonbseg = Math.Abs(celMagassag - Height);
            int lepes = Math.Max(2, kulonbseg / 5); // a távolság 1/5-ét lépjük, minimum 2 px

            if (nyitva)
            {
                if (Height < celMagassag)
                {
                    Height = Math.Min(Height + lepes, celMagassag+5);
                }
                else
                {
                    animacioTimer.Stop();

                    kepforgatas(180);

                }
            }
            else
            {
                if (Height > celMagassag)
                {
                    Height = Math.Max(Height - lepes, celMagassag+5);
                }
                else
                {
                    animacioTimer.Stop();

                    kepforgatas(0);
                    pnl_item.Visible = false;
                }
            }

            pnl_item.SarkokLekerekitese = 25;
        }
        private void kepforgatas(int fok)
        {
            if (fok == 0)
            {
                // Lemásoljuk az eredeti képet
                Image img = pcb_nyil.Image;
                img.RotateFlip(RotateFlipType.Rotate180FlipX);

                // Frissítjük a PictureBox képét
                pcb_nyil.Image = img;
            }
            else
            {

                Image img = pcb_nyil.Image;
                img.RotateFlip(RotateFlipType.RotateNoneFlipY);


                pcb_nyil.Image = img;
            }

        }
        private class ClickOutsideMessageFilter : IMessageFilter //kezeli a félrekattintást aés záródik a combo list
        {
            private readonly Control targetControl;
            private readonly Action clickOutsideAction;

            public ClickOutsideMessageFilter(Control targetControl, Action clickOutsideAction)
            {
                this.targetControl = targetControl;
                this.clickOutsideAction = clickOutsideAction;
            }

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == 0x201) // WM_LBUTTONDOWN (bal egérgomb lenyomás)
                {
                    Point cursorPos = Control.MousePosition;
                    if (!targetControl.RectangleToScreen(targetControl.ClientRectangle).Contains(cursorPos))
                    {
                        clickOutsideAction?.Invoke();
                    }
                }
                return false;
            }
        }


    }
}