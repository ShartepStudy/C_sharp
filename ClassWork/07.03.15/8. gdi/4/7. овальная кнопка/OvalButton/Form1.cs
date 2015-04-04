using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();

            g.SmoothingMode = SmoothingMode.AntiAlias;

            // —оздадим новый пр€моугольник с размерами кнопки
            Rectangle smallRectangle = button1.ClientRectangle;

            // уменьшим размеры пр€моугольника
            smallRectangle.Inflate(-3, -3);

            // создадим эллипс, использу€ полученные размеры
            gp.AddEllipse(smallRectangle);
            button1.Region = new Region(gp);

            // рисуем окантовоку дл€ круглой кнопки
            g.DrawEllipse(new Pen(Color.Gray, 2),
                button1.Left + 1,
                button1.Top + 1,
                button1.Width - 3,
                button1.Height - 3);

            // освобождаем ресурсы
            g.Dispose();
        }
    }
}