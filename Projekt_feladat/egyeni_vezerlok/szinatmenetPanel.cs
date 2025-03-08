using System.Drawing.Drawing2D;

namespace Projekt_feladat.egyeni_vezerlok;

public class SzinatmenetPanel : Panel
{
    private int sarkokLekerekitese = 40;
    private float szinatmenetSzog = 90F;
    private Color szinatmenetFelsoSzine = Color.DodgerBlue;
    private Color szinatmenetAlsoSzine = Color.CadetBlue;

    public SzinatmenetPanel()
    {
        this.BackColor = Color.White;
        this.ForeColor = Color.Black;
        this.Size = new Size(350, 200);
        this.Resize += (s, e) => this.Invalidate();
    }

    public int SarkokLekerekitese
    {
        get => sarkokLekerekitese;
        set { sarkokLekerekitese = value; this.Invalidate(); }
    }
    public float SzinatmenetSzog
    {
        get => szinatmenetSzog;
        set { szinatmenetSzog = value; this.Invalidate(); }
    }
    public Color SzinatmenetFelsoSzine
    {
        get => szinatmenetFelsoSzine;
        set { szinatmenetFelsoSzine = value; this.Invalidate(); }
    }
    public Color SzinatmenetAlsoSzine
    {
        get => szinatmenetAlsoSzine;
        set { szinatmenetAlsoSzine = value; this.Invalidate(); }
    }

    private GraphicsPath GetLekerekitettUgyfel(RectangleF rectangle, float radius)
    {
        GraphicsPath graphicsPath = new GraphicsPath();
        graphicsPath.StartFigure();
        graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
        graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
        graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
        graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
        graphicsPath.CloseFigure();

        return graphicsPath;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        LinearGradientBrush ecset = new LinearGradientBrush(this.ClientRectangle, this.SzinatmenetFelsoSzine, this.SzinatmenetAlsoSzine, this.SzinatmenetSzog);
        Graphics graphics = e.Graphics;
        graphics.FillRectangle(ecset, ClientRectangle);

        RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
        if (sarkokLekerekitese > 2)
        {
            using (GraphicsPath graphicsPath = GetLekerekitettUgyfel(rectangleF, SarkokLekerekitese))
            using (Pen toll = new Pen(Parent.BackColor, 0))
            {
                this.Region = new Region(graphicsPath);
                e.Graphics.DrawPath(toll, graphicsPath);
            }
        }
        else this.Region = new Region(rectangleF);
    }
}
