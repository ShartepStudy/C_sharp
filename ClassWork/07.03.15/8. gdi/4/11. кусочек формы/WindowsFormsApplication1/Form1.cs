using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ContainerForm : Form
    {
        public ContainerForm()
        {
            this.Paint += new PaintEventHandler(ContainerForm_Paint);
            this.FormBorderStyle = FormBorderStyle.None;
            Button close = new Button() { Parent = this, Text = "Close" };
            close.Click += new EventHandler(close_Click);
            this.TransparencyKey = Color.Black;
        }

        void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ContainerForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPolygon(Brushes.Black, new Point[]
        	                       {
        	                       	new Point(20, 20),
        	                       	new Point(200, 20),
        	                       	new Point(this.Width, this.Height)
        	                       });
        }

    }
}
