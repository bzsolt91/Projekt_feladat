using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Projekt_feladat.egyeni_vezerlok
{
    public class KerekitettGomb : Button
    {
        //Fields
        private int keretMeret = 0;
        private int sarokSugar = 0;
        private Color keretSzine = Color.PaleVioletRed;
        private Color nyomottAllapotHatterSzine = Color.DarkSlateBlue;
        private Color egerTartasHatterSzine = Color.SlateBlue;
        private Color alapHatterSzine;

        //Properties
        [Category("Egyéni gomb")]
        public int KeretMeret
        {
            get { return keretMeret; }
            set { keretMeret = value; Invalidate(); }
        }

        [Category("Egyéni gomb")]
        public int SarokSugar
        {
            get { return sarokSugar; }
            set { sarokSugar = value; Invalidate(); }
        }

        [Category("Egyéni gomb")]
        public Color KeretSzine
        {
            get { return keretSzine; }
            set { keretSzine = value; Invalidate(); }
        }

        [Category("Egyéni gomb")]
        public Color HatterSzine
        {
            get { return BackColor; }
            set { BackColor = value; alapHatterSzine = value; }
        }

        [Category("Egyéni gomb")]
        public Color SzovegSzine
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        [Category("Egyéni gomb")]
        public Color NyomottAllapotHatterSzine
        {
            get { return nyomottAllapotHatterSzine; }
            set { nyomottAllapotHatterSzine = value; }
        }

        [Category("Egyéni gomb")]
        public Color EgerTartasHatterSzine
        {
            get { return egerTartasHatterSzine; }
            set { egerTartasHatterSzine = value; }
        }

        //Constructor
        public KerekitettGomb()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            HatterSzine = Color.MediumSlateBlue;
            alapHatterSzine = HatterSzine;
            ForeColor = Color.White;
            Resize += new EventHandler(Button_Resize);
            MouseDown += new MouseEventHandler(Button_MouseDown);
            MouseUp += new MouseEventHandler(Button_MouseUp);
            MouseEnter += new EventHandler(Button_MouseEnter);
            MouseLeave += new EventHandler(Button_MouseLeave);
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (sarokSugar > 2)
            {
                using (GraphicsPath path = GetFigurePath(ClientRectangle, sarokSugar))
                {
                    Region = new Region(path);
                }
            }
            else
            {
                Region = new Region(ClientRectangle);
            }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -keretMeret, -keretMeret);
            int smoothSize = keretMeret > 0 ? keretMeret : 2;

            if (sarokSugar > 2) //Lekerekített gomb
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, sarokSugar))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, sarokSugar - keretMeret))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(keretSzine, keretMeret))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (keretMeret >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normál gomb
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                Region = new Region(rectSurface);
                if (keretMeret >= 1)
                {
                    using (Pen penBorder = new Pen(keretSzine, keretMeret))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (sarokSugar > Height)
                sarokSugar = Height;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = nyomottAllapotHatterSzine;
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = alapHatterSzine;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            BackColor = egerTartasHatterSzine;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            BackColor = alapHatterSzine;
        }
    }
}