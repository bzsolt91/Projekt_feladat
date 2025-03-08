using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * A beállított vezérlő sarkait lekerekíti
 * 
 *
 *
 *
 * */

namespace Projekt_feladat.egyeni_vezerlok
{
    public class ellipszisVezerlo : Component
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRGn(int nL, int nT, int nR, int nB, int nWidthEllipse, int nHeightEllipse);

        private Control vezerlo;
        private int cornerRadius = 25;
        public Control TargetControl
        {
            get
            { return vezerlo; }
            set
            {
                vezerlo = value;
                vezerlo.SizeChanged += (sender, eventargs) => vezerlo.Region = Region.FromHrgn(CreateRoundRectRGn(0, 0, vezerlo.Width, vezerlo.Height, cornerRadius, cornerRadius));
            }
        }
        public int SarokSugar
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                if (vezerlo != null)
                    vezerlo.Region = Region.FromHrgn(CreateRoundRectRGn(0, 0, vezerlo.Width, vezerlo.Height, cornerRadius, cornerRadius));
            }
        }

    }
}