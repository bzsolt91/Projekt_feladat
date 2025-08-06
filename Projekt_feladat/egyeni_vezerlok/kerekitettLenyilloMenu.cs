using Projekt_feladat.Properties;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using Timer = System.Windows.Forms.Timer;
using ToolTip = System.Windows.Forms.ToolTip;

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
        public event EventHandler TimerStopped;
        private int celMagassag;
        private int animacioLepes = 10;
        private bool nyilForgatva = false;
        private ToolTip pnl_tooltip;

        // Beállítjuk a toolTip szövegét a pnl_title panelhez

        /*kattintási eseménsy*/
        public class ElemKivalasztvaEventArgs : EventArgs
        {
            public string Ertek { get; }
            public int Index { get; }
            public object? Tag { get; } // opcionálisan használható extra adat
            private Image eredetiNyil;
            public ElemKivalasztvaEventArgs(string ertek, int index, object? tag = null)
            {
                Ertek = ertek;
                Index = index;
                Tag = tag;
            }
        }

        public event EventHandler<ElemKivalasztvaEventArgs>? ElemKivalasztva;
        /*********/
        private Color egerTartasSzin = Color.LightGray;
        public Color EgerTrartasSzin
        {
            get => egerTartasSzin;
            set
            {
                egerTartasSzin = value;
                Invalidate();
            }
        }
        private void SetLabelStyles(Label label)
        {
            var methodInfo = typeof(Control).GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (methodInfo != null)
            {
                methodInfo.Invoke(label, new object[] { ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true });
            }
        }
        public string[] adatForras
        {
            get => adat;
            set
            {
                if (value == null)
                    value = Array.Empty<string>(); // 
                flp_items.Controls.Clear();
           //     flp_items.BackColor = Color.Transparent;
                foreach (var item in value)
                {
                    Label label = new()
                    {
                        Text = item,
                        ForeColor = Color.Black,
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Height = 25,
                        Width = flp_items.Width
                    };

                    label.MouseClick += Label_selected;
                    label.Paint += Label_Paint;
                    SetLabelStyles(label);

                    // Új eseménykezelők a hover effekthez
                    label.MouseEnter += (s, e) =>
                    {
                        Label lbl = (Label)s;
                        if (lbl != kivalasztottLabel) // 
                        {
                            lbl.ForeColor = Color.White;
                            lbl.BackColor = Color.Transparent;
                            lbl.Invalidate(); // Azonnal frissítjük a kinézetet
                        }
                    };

                    label.MouseLeave += (s, e) =>
                    {
                        Label lbl = (Label)s;
                        if (lbl != kivalasztottLabel) // Csak akkor állítsuk vissza, ha nincs kiválasztva
                        {
                            lbl.ForeColor = Color.White;
                            lbl.BackColor = Color.Transparent;
                            lbl.Invalidate(); // Azonnal frissítjük a kinézetet
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

        private Color kivalasztottElemSzin = Color.BlueViolet;
        public Color KivalasztottElemSzin
        {
            get => kivalasztottElemSzin;
            set
            {
                kivalasztottElemSzin = value;
                Invalidate();
            }
        }
        public string ComboText
        {
            get => pnl_title.Text;
            set
            {
                pnl_title.Text = value;
            
                Invalidate();
                if (pnl_title.Text != null)
                    pnl_tooltip.SetToolTip(pnl_title, value);
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
        public Color ItemHatterSzin
        {
            get => flp_items.BackColor;
            set
            {
                flp_items.BackColor = value;

                // 💡 Frissítsd a már létező itemek háttérszínét is
                foreach (Control ctrl in flp_items.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        lbl.BackColor = value;
                        lbl.Invalidate(); // újrarajzolás
                    }
                }

                Invalidate();
            }
        }

        public Color TitleLabelSzin
        {
            get => pnl_title.ForeColor;
            set
            {
                pnl_title.ForeColor = value;
            

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

        public int LenyiloMagassag { get; set; } = 300;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
       
        }
        private void Label_selected(object? sender, MouseEventArgs e)
        {

            Label? elozoKivalasztott = kivalasztottLabel;
            Label label = (Label)sender;

            kivalasztottLabel = label;

            // Frissítsük a régi és az új kijelölt elemet
            elozoKivalasztott?.Invalidate();
            kivalasztottLabel.Invalidate();

            // A pnl_title frissítése
            pnl_title.Text = label.Text;
            if (label.Text != null)
                pnl_tooltip.SetToolTip(this.pnl_title, label.Text);

            // Kattintott labelt beállítjuk kiválasztottnak
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.White;
            kivalasztottLabel = label;

            pnl_title.Text = label.Text;

            if (label.Text != null)
                pnl_tooltip.SetToolTip(this.pnl_title, label.Text);
            i = 0;
            

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
            celMagassag = nyitva ? this.LenyiloMagassag : 61; 
            animacioTimer.Start();
            pnl_item.Visible = true;

            if (nyitva)
            {
                clickOutsideFilter = new ClickOutsideMessageFilter(this, () =>
                {
                    nyitva = false;
                    celMagassag = 61;
                    animacioTimer.Start();
                 
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
             flp_items.AutoScroll = false;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            animacioTimer.Interval = 5;
            animacioTimer.Tick += AnimacioFrissitese;
           
            BackColor = Color.Transparent;
            CimPanelAlsoSzin = Color.White;
            CimPanelFelsoSzin = Color.White;
            pnl_title.Text = "Text";
            ForeColor = Color.White;
            this.ItemHatterSzin = Color.WhiteSmoke;
            ItemPanelAlosSzin = Color.WhiteSmoke;
            ItemPanelFelsoSzin = Color.WhiteSmoke;
            KeretSzin = Color.RoyalBlue;
            KeretVastagsag = 2F;
            Location = new Point(322, 518);
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(150, 0);
            Name = "kerekitettLenyilloMenu1";
            Radius = 30;
            Size = new Size(482, 68);
            TabIndex = 2;
            pnl_title.ForeColor = Color.Gray;
            pnl_tooltip = new ToolTip();
            pnl_tooltip.OwnerDraw = true;
            pnl_tooltip.Draw += EgyeniTooltip_Draw; // Feliratkozás a Draw eseményre
            pnl_tooltip.Popup += EgyeniTooltip_Popup;

        }

 

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            this.Invalidate();
        }

        public void StopTimer()
        {
            if (animacioTimer.Enabled)
            {
                animacioTimer.Stop();
                TimerStopped?.Invoke(this, EventArgs.Empty);
            }

            int keret = this.Padding.Top + this.Padding.Bottom;

            if (!nyitva)
            {
                pnl_item.Visible = false;
                this.Height = pnl_title.Height + keret;
            }
            else
            {
                this.Height = pnl_title.Height + celMagassag + keret;
            }

            pnl_item.Height = this.Height - pnl_title.Height - keret;
        }

        private void AnimacioFrissitese(object? sender, EventArgs e)
        {
           
            int keret = this.Padding.Top + this.Padding.Bottom;
            int celTeljesMagassag = pnl_title.Height + celMagassag + keret;
            int kulonbseg = Math.Abs(this.Height - celTeljesMagassag);
            int lepes = Math.Max(2, kulonbseg / 2);

            if (nyitva)
            {
                if (this.Height < celTeljesMagassag)
                {
                    this.Height = Math.Min(this.Height + lepes, celTeljesMagassag);
                }
                else
                {
                    this.Height = celTeljesMagassag;
                    StopTimer();
                    kepforgatas();
                }
            }
            else
            {
                int zartMagassag = pnl_title.Height + keret + 10;

                if (this.Height > zartMagassag)
                {
                    this.Height = Math.Max(this.Height - lepes, zartMagassag);
                }
                else
                {
                    this.Height = zartMagassag;
                    pnl_item.Visible = false;
                    StopTimer();
                    kepforgatas();
                }
              
            }

            // Ez mindig frissíti a lenyíló rész magasságát pontosan
            pnl_item.Height = this.Height - pnl_title.Height - keret;

            pnl_item.SarkokLekerekitese = 25;
        }


        private void AnimacioStop(object? sender, EventArgs e)
        {

            if (!nyitva)
            {
                pnl_item.Visible = false;
                
            }
            }
        private void kepforgatas()
        {
            if (nyilForgatva)
            {
                pcb_nyil.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                nyilForgatva = false;
            }
            else
            {
                pcb_nyil.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                nyilForgatva = true;
            }

            pcb_nyil.Invalidate(); // biztos újrarajzolás
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
        ///tooltip cuccai
        ///
        private void EgyeniTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font font = new Font("Segoe UI", 18);
            using (LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.BlueViolet, Color.BlueViolet, 90f))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            e.Graphics.DrawRectangle(Pens.DarkViolet, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
            TextRenderer.DrawText(e.Graphics, e.ToolTipText, font, e.Bounds, Color.White, TextFormatFlags.WordBreak);
        }

        private void EgyeniTooltip_Popup(object sender, PopupEventArgs e)
        {
            Font font = new Font("Segoe UI", 18);

            // Itt a 'sender' a ToolTip objektum, tehát le tudjuk kérni belőle a szöveget
            ToolTip tooltip = (ToolTip)sender;
            string szoveg = tooltip.GetToolTip(e.AssociatedControl);

            Size meret = TextRenderer.MeasureText(szoveg, font, new Size(1000, 0), TextFormatFlags.WordBreak);
            e.ToolTipSize = new Size(meret.Width + 10, meret.Height + 10);
        }
        private void Label_Paint(object? sender, PaintEventArgs e)
        {
            Label label = (Label)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, label.Width - 1, label.Height - 1);
            int radius = 10;

            Color fillColor;

            if (label == kivalasztottLabel)
            {
                fillColor = this.KivalasztottElemSzin;
                label.ForeColor = Color.White;
            }
            else if (label.ClientRectangle.Contains(label.PointToClient(Cursor.Position)))
            {
                fillColor = this.EgerTrartasSzin;
                label.ForeColor = Color.Black;
            }
            else
            {
                fillColor = this.ItemHatterSzin;
                label.ForeColor = Color.Black;
            }

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            TextRenderer.DrawText(e.Graphics, label.Text, label.Font, rect, label.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Felszabadítjuk a ToolTip komponenst, ha létezik
                if (pnl_tooltip != null)
                {
                    pnl_tooltip.RemoveAll();
                    pnl_tooltip.Dispose();
                    pnl_tooltip = null;
                }

                // Felszabadítjuk az animáció timert is
                if (animacioTimer != null)
                {
                    animacioTimer.Stop();
                    animacioTimer.Dispose();
                    animacioTimer = null;
                }

                // Felszabadítjuk a ClickOutsideMessageFilter-t is, ha létezik
                if (clickOutsideFilter != null)
                {
                    Application.RemoveMessageFilter(clickOutsideFilter);
                    clickOutsideFilter = null;
                }

                // Felszabadítjuk azokat a kontrollokat, amiket a designer hozott létre
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        ////


    }
}