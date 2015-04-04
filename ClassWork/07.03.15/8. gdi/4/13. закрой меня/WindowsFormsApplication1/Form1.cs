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
        Region rgn = null;
        Color closeColor = Color.Black;
        public ContainerForm()
        {
            this.Width = 500;
            this.Height = 500;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 200, 200);
            this.Paint += new PaintEventHandler(ContainerForm_Paint);
            rgn = new Region(new Rectangle(100, 100, 500, 500));
            rgn.Exclude(path);
            path = new GraphicsPath();
            path.AddEllipse(0, 0, 190, 190);
            rgn.Union(path);

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = rgn;
            this.Paint += new PaintEventHandler(ContainerForm_Paint);

            this.MouseMove += new MouseEventHandler(ContainerForm_MouseMove);
            this.MouseClick += new MouseEventHandler(ContainerForm_MouseClick);

            // http://ru.wikipedia.org/wiki/%D0%94%D0%B2%D0%BE%D0%B9%D0%BD%D0%B0%D1%8F_%D0%B1%D1%83%D1%84%D0%B5%D1%80%D0%B8%D0%B7%D0%B0%D1%86%D0%B8%D1%8F
            this.DoubleBuffered = true;

        }

        void ContainerForm_MouseClick(object sender, MouseEventArgs e)
        {

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 190, 190);
            Region closeRgn = new Region(path);
            if (closeRgn.IsVisible(e.X, e.Y))
            {
                this.Close();
            }

        }

        void ContainerForm_MouseMove(object sender, MouseEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 190, 190);
            Region closeRgn = new Region(path);
            if (closeRgn.IsVisible(e.X, e.Y))
            {
                closeColor = Color.Red;
            }
            else
            {
                closeColor = Color.Black;
            }
            Invalidate(closeRgn);
        }



        void ContainerForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(closeColor), 0, 0, 190, 190);
            e.Graphics.DrawString("X",
                                  new Font(new FontFamily("Georgia"), 100, FontStyle.Regular, GraphicsUnit.Pixel),
                                 Brushes.White, new Point(40, 30));
        }
    }
}
