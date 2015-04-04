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

        Rectangle rect = new Rectangle(0, 0, 100, 50);
        Brush br1 = new SolidBrush(Color.FromArgb(150, 100, 200, 100));
        Brush br2 = new SolidBrush(Color.FromArgb(150, 200, 200, 100));
        Brush br3 = new SolidBrush(Color.FromArgb(150, 100, 200, 0));
        Brush br4 = new SolidBrush(Color.FromArgb(150, 100, 200, 200));

        public ContainerForm()
        {
            this.Paint += new PaintEventHandler(ContainerForm_Paint);
        }

        void ContainerForm_Paint(object sender, PaintEventArgs e)
        {
            Matrix transform = new Matrix();
            transform.Translate(150, 150);
            e.Graphics.Transform = transform;
            e.Graphics.FillRectangle(br1, rect);

            transform.Reset();
            transform.Translate(150, 150);
            transform.Rotate(45);
            e.Graphics.Transform = transform;
            e.Graphics.FillRectangle(br2, rect);

            transform.Reset();
            transform.Translate(150, 150);
            transform.Scale(.5f, -2);
            e.Graphics.Transform = transform;
            e.Graphics.FillRectangle(br3, rect);

            transform.Reset();
            transform.Translate(150, 150);
            transform.Shear(0, -1);
            e.Graphics.Transform = transform;
            e.Graphics.FillRectangle(br4, rect);
        }
    }
}
