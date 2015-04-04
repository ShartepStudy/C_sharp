using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Single y_vert;
        Single x_horiz;

        Graphics g;
        Font f;
        string scrollText = "C# Foreva";

        float speed = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbHoriz.Checked)
            {
                g.Clear(this.BackColor);
                g.DrawString(scrollText, f, Brushes.Black, x_horiz, y_vert);
                if (x_horiz <= -200)
                {
                    x_horiz = this.Width;
                }
                else
                {
                    x_horiz -= speed;
                }
            }
            else
            {
                g.Clear(this.BackColor);
                g.DrawString(scrollText, f, Brushes.Black, x_horiz, y_vert);
                if (y_vert <= -100)
                {
                    y_vert = this.Height;
                }
                else
                {
                    y_vert -= speed;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            y_vert = this.Height;
            x_horiz = this.Width - 400;

            timer1.Interval = 30;
            timer1.Start();
            f = new Font("Calibri", 30, FontStyle.Bold, GraphicsUnit.Point);
        }

    }
}