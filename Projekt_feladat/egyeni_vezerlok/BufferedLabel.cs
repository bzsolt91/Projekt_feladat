
namespace Projekt_feladat.egyeni_vezerlok
{

    public class BufferedLabel : Label
    {
        public BufferedLabel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
    }
}