using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Projekt_feladat.egyeni_vezerlok;

public partial class KapcsoloGomb : CheckBox
{
    //Mezők
    private Color bekapcsoltHatterSzine = Color.MediumSlateBlue;
    private Color bekapcsoltKapcsoloSzine = Color.WhiteSmoke;
    private Color kikapcsoltHatterSzine = Color.Gray;
    private Color kikapcsoltKapcsoloSzine = Color.Gainsboro;
    private bool szilardStilusAktivalva = true;

    //Tulajdonságok
    public Color BekapcsoltHatterSzine
    {
        get
        {
            return bekapcsoltHatterSzine;
        }

        set
        {
            bekapcsoltHatterSzine = value;
            this.Invalidate();
        }
    }

    public Color BekapcsoltKapcsoloSzine
    {
        get
        {
            return bekapcsoltKapcsoloSzine;
        }

        set
        {
            bekapcsoltKapcsoloSzine = value;
            this.Invalidate();
        }
    }

    public Color KikapcsoltHatterSzine
    {
        get
        {
            return kikapcsoltHatterSzine;
        }

        set
        {
            kikapcsoltHatterSzine = value;
            this.Invalidate();
        }
    }

    public Color KikapcsoltKapcsoloSzine
    {
        get
        {
            return kikapcsoltKapcsoloSzine;
        }

        set
        {
            kikapcsoltKapcsoloSzine = value;
            this.Invalidate();
        }
    }

    [Browsable(false)]
    public override string Text
    {
        get
        {
            return base.Text;
        }

      
    }

    [DefaultValue(true)]
    public bool SzilardStilusAktivalva
    {
        get
        {
            return szilardStilusAktivalva;
        }

        set
        {
            szilardStilusAktivalva = value;
            this.Invalidate();
        }
    }

    //Konstruktor
    public KapcsoloGomb()
    {
        this.MinimumSize = new Size(45, 22);
    }

    //Függvények
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

    protected override void OnPaint(PaintEventArgs pevent)
    {
        int kapcsoloMeret = this.Height - 5;
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pevent.Graphics.Clear(this.Parent.BackColor);

        if (this.Checked) // BE
        {
            //A vezérlő felületének rajzolása
            if (szilardStilusAktivalva)
                pevent.Graphics.FillPath(new SolidBrush(bekapcsoltHatterSzine), HozzaLetreKapcsoloUtvonalat());
            else pevent.Graphics.DrawPath(new Pen(bekapcsoltHatterSzine, 2), HozzaLetreKapcsoloUtvonalat());
            //Kapcsoló rajzolása
            pevent.Graphics.FillEllipse(new SolidBrush(bekapcsoltKapcsoloSzine),
                new Rectangle(this.Width - this.Height + 1, 2, kapcsoloMeret, kapcsoloMeret));
        }
        else // KI
        {
            //A vezérlő felületének rajzolása
            if (szilardStilusAktivalva)
                pevent.Graphics.FillPath(new SolidBrush(kikapcsoltHatterSzine), HozzaLetreKapcsoloUtvonalat());
            else pevent.Graphics.DrawPath(new Pen(kikapcsoltHatterSzine, 2), HozzaLetreKapcsoloUtvonalat());
            //Kapcsoló rajzolása
            pevent.Graphics.FillEllipse(new SolidBrush(kikapcsoltKapcsoloSzine),
                new Rectangle(2, 2, kapcsoloMeret, kapcsoloMeret));
        }
    }
}
