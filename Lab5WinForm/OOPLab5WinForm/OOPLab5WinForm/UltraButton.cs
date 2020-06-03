using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab5WinForm
{
    class UltraButton : Button
    {

        public UltraButton(): base()
        {
            ForeColor = Color.White;
            Font = new Font("Microsoft YaHei UI",
            20.25F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            0);
        }
    }
}
