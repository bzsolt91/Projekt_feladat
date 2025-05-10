using System.ComponentModel;
using System.Drawing.Drawing2D;
/*
 * Lekerrekíthető sarkakkal rendelkező TextBox
 * 
 * 
 * 
 * 
 * 
 */
namespace Projekt_feladat.egyeni_vezerlok
{
    [DefaultEvent("_SzovegValtoztatva")]
    public partial class kerekitettSzovegMezo : UserControl
    {
        #region -> Mezők
        //Fields
        private Color keretszin = Color.MediumSlateBlue;
        private Color fokuszkeretszin = Color.HotPink;
        private int keretmeret = 2;
        private bool aluhuzasszin = false;
        private bool fukuszalva = false;

        private int keretsugar = 0;
        private Color helyorzoszin = Color.DarkGray;
        private string helyorzoszoveg = "";
        private bool helyorzo_e = false;
        private bool jelszokarakter_e = false;

        //Events
        public event EventHandler _SzovegValtoztatva;

        #endregion

        //-> Constructor
        public kerekitettSzovegMezo()
        {
      
            InitializeComponent();
        }

        #region -> Jellemzők
        [Category("KerekitettTextBox")]
        public Color KeretSzin
        {
            get { return keretszin; }
            set
            {
                keretszin = value;
                this.Invalidate();
            }
        }

        [Category("KerekitettTextBox")]
        public Color FokuszKeretSzin
        {
            get { return fokuszkeretszin; }
            set { fokuszkeretszin = value; }
        }

        [Category("KerekitettTextBox")]
        public int KeretMeret
        {
            get { return keretmeret; }
            set
            {
                if (value >= 1)
                {
                    keretmeret = value;
                    this.Invalidate();
                }
            }
        }

        [Category("KerekitettTextBox")]
        public bool AlahuzottStilus
        {
            get { return aluhuzasszin; }
            set
            {
                aluhuzasszin = value;
                this.Invalidate();
            }
        }

        [Category("KerekitettTextBox")]
        public bool JelszoKarakter
        {
            get { return jelszokarakter_e; }
            set
            {
                jelszokarakter_e = value;
                if (!helyorzo_e)
                    tb_dizajn.UseSystemPasswordChar = value;
            }
        }

        [Category("KerekitettTextBox")]
        public bool TobbSor
        {
            get { return tb_dizajn.Multiline; }
            set { tb_dizajn.Multiline = value; }
        }

        [Category("KerekitettTextBox")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                tb_dizajn.BackColor = value;
            }
        }

        [Category("KerekitettTextBoxe")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                tb_dizajn.ForeColor = value;
            }
        }

        [Category("KerekitettTextBox")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                tb_dizajn.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("KerekitettTextBox")]
        public string Texts
        {
            get
            {
                if (helyorzo_e) return "";
                else return tb_dizajn.Text;
            }
            set
            {
                RemovePlaceholder();
                tb_dizajn.Text = value;
                SetPlaceholder();
            }
        }

        [Category("KerekitettTextBox")]
        public int KeretSugar
        {
            get { return keretsugar; }
            set
            {
                if (value >= 0)
                {
                    keretsugar = value;
                    this.Invalidate();//vezérlő újrarajzolása
                }
            }
        }

        [Category("KerekitettTextBox")]
        public Color HelyorzoSzin
        {
            get { return helyorzoszin; }
            set
            {
                helyorzoszin = value;
                if (helyorzo_e)
                    tb_dizajn.ForeColor = value;
            }
        }

        [Category("KerekitettTextBox")]
        public string HelyorzoSzoveg
        {
            get { return helyorzoszoveg; }
            set
            {
                helyorzoszoveg = value;
                tb_dizajn.Text = "";
                SetPlaceholder();
            }
        }
        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (keretsugar > 1)//kerekített
            {
                //-mezők
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -keretmeret, -keretmeret);
                int smoothSize = keretmeret > 0 ? keretmeret : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, keretsugar))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, keretsugar - keretmeret))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(keretszin, keretmeret))
                {
                    //-rajzolás
                    this.Region = new Region(pathBorderSmooth);//kerekitett régió
                    if (keretsugar > 15) SetTextBoxRoundedRegion();//
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (fukuszalva) penBorder.Color = fokuszkeretszin;

                    if (aluhuzasszin) //Line Style
                    {
                        //keret rajzolás simitás
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //keret rajzolás
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal stílus
                    {
                        //keret rajzolás simitás
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //keret rajzolás
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //kocka/Normal TextBox
            {
                //keret rajzolás
                using (Pen penBorder = new Pen(keretszin, keretmeret))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (fukuszalva) penBorder.Color = fokuszkeretszin;

                    if (aluhuzasszin) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal stílus
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        #endregion

        #region -> Private methods
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(tb_dizajn.Text) && helyorzoszoveg != "")
            {
                helyorzo_e = true;
                tb_dizajn.Text = helyorzoszoveg;
                tb_dizajn.ForeColor = helyorzoszin;
                if (helyorzo_e)
                    tb_dizajn.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (helyorzo_e && helyorzoszoveg != "")
            {
                helyorzo_e = false;
                tb_dizajn.Text = "";
                tb_dizajn.ForeColor = this.ForeColor;
                if (jelszokarakter_e)
                    tb_dizajn.UseSystemPasswordChar = true;
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Ha a radius túl kicsi, akkor legyen minimum 1
            if (radius < 1)
                radius = 1;

            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (TobbSor)
            {
                pathTxt = GetFigurePath(tb_dizajn.ClientRectangle, keretsugar - keretmeret);
                tb_dizajn.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(tb_dizajn.ClientRectangle, keretmeret * 2);
                tb_dizajn.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (tb_dizajn.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                tb_dizajn.Multiline = true;
                tb_dizajn.MinimumSize = new Size(0, txtHeight);
                tb_dizajn.Multiline = false;

                this.Height = tb_dizajn.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        #endregion

        #region -> TextBox events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_SzovegValtoztatva != null)
                _SzovegValtoztatva.Invoke(sender, e);
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            fukuszalva = true;
            this.Invalidate();
            RemovePlaceholder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            fukuszalva = false;
            this.Invalidate();
            SetPlaceholder();
        }
        ///::::+
        #endregion
    }
}