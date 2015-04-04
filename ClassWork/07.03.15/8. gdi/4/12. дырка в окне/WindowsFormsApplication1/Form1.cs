using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ContainerForm : Form
    {
        Region rgn;
        public ContainerForm()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(50, 50, 100, 100);
            rgn = new Region(new Rectangle(0, 0, 300, 300));
            rgn.Union(new Rectangle(120, 130, 100, 100));
            rgn.Xor(path);
            path = new GraphicsPath();
            path.AddEllipse(70, 70, 200, 200);
            rgn.Exclude(path);
            this.Region = rgn;
            this.MouseClick += new MouseEventHandler(ContainerForm_MouseClick);
        }

        void ContainerForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (rgn != null)
            {
                if (rgn.IsVisible(e.X, e.Y))
                {
                    MessageBox.Show("!");
                }
            }
        }
    }
}
