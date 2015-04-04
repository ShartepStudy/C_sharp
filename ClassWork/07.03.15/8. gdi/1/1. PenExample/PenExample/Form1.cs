using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PenExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("paint event!");

            // Классы для рисования примитивов (линий, точек, геометрических фигур), находятся, главным образом,
            // в пространстве имен System.Drawing. Оно, в частности, содержит класс Graphics, в котором есть множество
            // методов для графического отображения геометрических примитивов.
            // Сам класс инкапсулирует поверхность рисования GDI+. Этот класс не наследуется.
            // http://msdn.microsoft.com/ru-ru/library/system.windows.forms.painteventargs.graphics.aspx

            Graphics g = e.Graphics;
            Pen pn = new Pen(Brushes.Blue, 5);
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            g.DrawEllipse(pn, 50, 100, 170, 40);

        }
    }
}
