using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Label l = new Label();

        public Form1()
        {
            l.Text = "Статик";
            l.Parent = this;
            l.Location = new Point(10, 10); // Location – позиция левого верхнего угла
            // l.AutoSize = true; //подстройка размера статика под содержимое
            l.MouseMove += new MouseEventHandler(StaticMove); // обработчик события Mousemove на статике
            Width = 500; // ширина форма
            Height = 500; // Высота формы
            l.Width = 200; // ширина статика
            l.Height = 200; // высота статика
            l.BorderStyle = BorderStyle.Fixed3D; // трёхмерный стиль границ
            BackColor = Color.AliceBlue; // цвет фона формы
            l.BackColor = Color.Orange; // цвет фона статика
            l.ForeColor = Color.FromArgb(255, 0, 0); // цвет текста на статике
            l.Cursor = Cursors.Hand; // тип курсора
            Opacity = 0.8; // Степень прозрачности формы
        }

        public void StaticMove(Object sender, MouseEventArgs e)
        {
            Label l = (Label) sender;
            l.Text = String.Format("X = {0}  Y = {1}", e.X, e.Y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Text = String.Format("X = {0}  Y = {1}", e.X, e.Y);
        }
    }

}