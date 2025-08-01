using System;

using System.Drawing;

using System.Drawing.Drawing2D;

using System.Windows.Forms;

using System.ComponentModel; // Kell a DesignerSerializationVisibility-hez



namespace Projekt_feladat.egyeni_vezerlok;



public class SzinatmenetPanel : Panel

{

    private int sarkokLekerekitese = 40;

    private float szinatmenetSzog = 90F;

    private Color szinatmenetFelsoSzine = Color.DodgerBlue;

    private Color szinatmenetAlsoSzine = Color.CadetBlue;

    private Color keretSzin = Color.Black;

    private float keretVastagsag = 0f;



    [Category("Megjelenés")]

    public int SarkokLekerekitese

    {

        get => sarkokLekerekitese;

        set { sarkokLekerekitese = value; this.Invalidate(); }

    }



    [Category("Megjelenés")]

    public float SzinatmenetSzog

    {

        get => szinatmenetSzog;

        set { szinatmenetSzog = value; this.Invalidate(); }

    }



    [Category("Megjelenés")]

    public Color SzinatmenetFelsoSzine

    {

        get => szinatmenetFelsoSzine;

        set { szinatmenetFelsoSzine = value; this.Invalidate(); }

    }



    [Category("Megjelenés")]

    public Color SzinatmenetAlsoSzine

    {

        get => szinatmenetAlsoSzine;

        set { szinatmenetAlsoSzine = value; this.Invalidate(); }

    }



    [Category("Megjelenés")]

    public Color KeretSzin

    {

        get => keretSzin;

        set { keretSzin = value; this.Invalidate(); }

    }



    [Category("Megjelenés")]

    public float KeretVastagsag

    {

        get => keretVastagsag;

        set { keretVastagsag = value; this.Invalidate(); }

    }

    [Category("Megjelenés")]

    public override string Text

    {

        get => base.Text;

        set { base.Text = value; Invalidate(); }

    }



    public SzinatmenetPanel()

    {

        this.BackColor = Color.Transparent; // Átlátszó háttér

        this.ForeColor = Color.Black; // Tartalom színe

        this.Size = new Size(350, 200);



        // Rajzolási stílusok beállítása

        this.SetStyle(ControlStyles.UserPaint |

           ControlStyles.AllPaintingInWmPaint |

           ControlStyles.OptimizedDoubleBuffer |

           ControlStyles.ResizeRedraw, true);

        this.UpdateStyles();

    }



    // Segédmetódus a lekerekített (vagy sima téglalap) útvonal létrehozásához

    private GraphicsPath GetRoundedPath(RectangleF rect, float radius)

    {

        GraphicsPath path = new GraphicsPath();



        // Kezeljük az érvénytelen vagy üres téglalapot

        if (rect.Width <= 0 || rect.Height <= 0)

        {

            return path; // Üres GraphicsPath

        }



        float curveSize = radius * 2F;



        // Biztosítsuk, hogy a curveSize ne lépje túl a téglalap méretét, és pozitív legyen

        float maxCurveSize = Math.Min(rect.Width, rect.Height);

        if (curveSize > maxCurveSize) curveSize = maxCurveSize;

        if (curveSize < 0) curveSize = 0;



        // Ha a curveSize gyakorlatilag nulla (nagyon kicsi érték),

        // adjunk hozzá egy sima téglalap útvonalat az ívek helyett

        // Használjunk egy kis tűrést a lebegőpontos összehasonlításhoz

        if (curveSize < 0.1f) // Tűrés

        {

            path.AddRectangle(rect); // Sima téglalap hozzáadása

        }

        else // Folytassuk a lekerekített sarkokkal

        {

            path.StartFigure();

            // Ívek hozzáadása minden sarokhoz

            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); // Bal felső

            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); // Jobb felső

            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); // Jobb alsó

            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bal alsó

            path.CloseFigure();

        }



        return path;

    }



    // Rajzolás felülbírálása

    protected override void OnPaint(PaintEventArgs e)

    {

        RectangleF rect = ClientRectangle;



        if (rect.Width <= 0 || rect.Height <= 0)

            return;



        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;



        // Hozzuk létre egy belső téglalapot, hogy a keret ne lógjon ki

        float felKeretVastagsag = KeretVastagsag / 2f;

        rect = new RectangleF(

          rect.X + felKeretVastagsag - 1,

          rect.Y + felKeretVastagsag - 1,

          rect.Width - KeretVastagsag,

          rect.Height - KeretVastagsag

        );



        // Innentől a path és az ecset is ezzel az új rect-tel dolgozik

        using GraphicsPath path = GetRoundedPath(rect, SarkokLekerekitese);



        // Ellenőrizzük, hogy az útvonal érvényes (nem üres)

        if (path.PointCount > 0)

        {

            // Hozzuk létre a színátmenetes ecsetet a vezérlő határain

            using var ecset = new LinearGradientBrush(rect, this.SzinatmenetFelsoSzine, this.SzinatmenetAlsoSzine, this.SzinatmenetSzog);



            // Töltsük ki az útvonal által definiált alakzatot az ecsettel

            // Ez a legszabványosabb módja egy adott forma kitöltésének

            e.Graphics.FillPath(ecset, path);



            // Rajzoljuk meg a keretet az útvonal körvonalára, ha a vastagság > 0

            if (KeretVastagsag > 0)

            {

                using Pen keretToll = new Pen(KeretSzin, KeretVastagsag);

                // A toll igazítása középre az útvonalon

                keretToll.Alignment = PenAlignment.Center;

                e.Graphics.DrawPath(keretToll, path);

            }

        }

        //szöveg írás a panelra

        if (!string.IsNullOrEmpty(this.Text))

        {

            using var font = new Font("Segoe UI", 14.25F, FontStyle.Regular);

            using var brush = new SolidBrush(this.ForeColor);



            var format = new StringFormat

            {

                Alignment = StringAlignment.Near,

                LineAlignment = StringAlignment.Center

            };



            int left = 0, right = 0;



            // vezérlő a combo boxhoz

            var bal = this.Controls.OfType<Control>().FirstOrDefault(c => c.Dock == DockStyle.Left);

            var jobb = this.Controls.OfType<Control>().FirstOrDefault(c => c.Dock == DockStyle.Right);



            if (bal != null)

                left = bal.Right + 5; // kicsi térköz



            if (jobb != null)

                right = this.Width - jobb.Left + 5;



            var textRect = new RectangleF(left, 0, this.Width - left - right, this.Height);



            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            e.Graphics.DrawString(this.Text, font, brush, textRect, format);

        }

    }

}