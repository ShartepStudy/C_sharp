using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawingCombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // http://msdn.microsoft.com/en-us/library/system.windows.forms.combobox.drawitem.aspx
           e.DrawBackground(); // рисует фон для выбранного элемента
           // ForeColor - возвращает основной цвет для изображаемого элемента.
            using (Pen p = new Pen(e.ForeColor, 2))
            {
                p.DashStyle = (DashStyle)e.Index;
                // Bounds - возвращает прямоугольник, представляющий собой границы изображаемого элемента.
                int y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
                e.Graphics.DrawLine(p, e.Bounds.Left, y, e.Bounds.Right, y);
            }
            e.DrawFocusRectangle(); // Рисует прямоугольник фокуса
        }
    }
}
