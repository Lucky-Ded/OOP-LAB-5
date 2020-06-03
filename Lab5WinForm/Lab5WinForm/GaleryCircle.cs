using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5WinForm
{
    class GaleryCircle : Galery
    {
        private Bitmap bitmap = new Bitmap(Properties.Resources.DSCF0257);

        public GaleryCircle() : base()
        {
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);
        }
    }
}
