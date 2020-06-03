using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

           
            galeryCircle1.galery.Add(new Note(new Bitmap(Properties.Resources.w34r), "1"));
            galeryCircle1.galery.Add(new Note(new Bitmap(Properties.Resources.DSCF0269), "2"));
            galeryCircle1.galery.Add(new Note(new Bitmap(Properties.Resources.DSCF0349), "3"));
           

            galery1.galery.Add(new Note(new Bitmap(Properties.Resources.DSCF0352), "1.1"));
            galery1.galery.Add(new Note(new Bitmap(Properties.Resources.DSCF0362), "1.2"));
            galery1.galery.Add(new Note(new Bitmap(Properties.Resources.DSCF0397), "1.3"));
            galery1.galery.Add(new Note(new Bitmap(Properties.Resources.DSCF0408), "1.4"));
            galery1.galery.Add(new Note(new Bitmap(Properties.Resources.DSCF0410), "1.5"));

        }

      
    }
}
