using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5WinForm
{
    public class Note
    {
        public Bitmap bitmap { get; }

        public string visibleText { private set; get; }

        public string text = "";

        public Note() { }

        public Note(Bitmap bitmap, string visibleText)
        {
            this.bitmap = bitmap;
            this.visibleText = visibleText;
         
        }
    }
   

    

    class Galery : Form1
    {

        private int i = 0;

        public List<Note> galery = new List<Note>();
        protected Color color = Color.SkyBlue;
        protected StringFormat stringFormat;

        public Galery() : base()
        {
            ForeColor = Color.White;
            Font = new Font("Microsoft YaHei UI",
            20.25F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            0);
            Height = 150;
            Width = 150;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            galery[i].text = galery[i].visibleText; //текст становится видимым

        }


        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            galery[i].text = "";
  
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
           
            pevent.Graphics.DrawImage(galery[i].bitmap, 0, 0);
           
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            pevent.Graphics.DrawImage(galery[i].bitmap,0,0,700,400);

            pevent.Graphics.DrawString(galery[i].text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;

            if (i > galery.Count - 1)
                i = 0;
        }
    }
}

