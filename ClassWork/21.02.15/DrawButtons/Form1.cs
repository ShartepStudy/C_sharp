using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawButtons
{
    public partial class Form1 : Form
    {
        private int x_mouse_down;
        private int y_mouse_down;
        int x1, y1;
        private bool flag_lbtn_down = false;
        private bool flag_create_wnd = false;
        private bool flag_lbtn_move_caption = true;
        private int width;
        private int height;
        int x;
        int y;
        private int count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flag_create_wnd = false;
            flag_lbtn_move_caption = false;
            x_mouse_down = e.X;
            y_mouse_down = e.Y;
            x = e.X;
            y = e.Y;
            flag_lbtn_down = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag_lbtn_down = false;
            flag_create_wnd = false;

            x1 = e.X;
            y1 = e.Y;
            width = x1 - x_mouse_down;
            height = y1 - y_mouse_down;
            count++;

            if (width > 0 && height > 0)
            {

            }
            else if (width > 0 && height < 0)
            {
                y = y1;
                height = Math.Abs(height);
            }
            else if (width < 0 && height > 0)
            {
                x = x1;
                width = Math.Abs(width);
            }
            else if (width < 0 && height < 0)
            {
                x = x1;
                y = y1;
                height = Math.Abs(height);
                width = Math.Abs(width);
            }
            if (width < 10 || height < 10)
            {
                MessageBox.Show("Маленький размер");
            }
            else
            {
                Button but = new Button();
                but.SuspendLayout();
                but.Location = new System.Drawing.Point(x, y);
                but.Size = new System.Drawing.Size(width, height);
                but.Name = "button";
                but.Text = "Go " + count.ToString();
                but.TabIndex = 0;
                but.UseVisualStyleBackColor = true;
                this.Controls.Add(but);
            }
        }
    }
}
