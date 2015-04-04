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
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            SolidBrush solBrush = new SolidBrush(Color.Green);
            Font f = new Font("Tahoma", 32, FontStyle.Bold);

            // Разворачиваем текст на 180 градусов
            g.RotateTransform(180);
            g.DrawString("C# Forever!!!", f, solBrush, -300, -250);
            // Восстанавливаем преобразовние
            g.ResetTransform();
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            SolidBrush solBrush = new SolidBrush(Color.Gray);
            Font f = new Font("Tahoma", 26, FontStyle.Bold);

            // Разворачиваем текст на 30 градусов
            g.RotateTransform(30);
            g.DrawString("C# Forever!!!", f, solBrush, 40, 10);
            // Восстанавливаем преобразовние
            g.ResetTransform();
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(BackColor);

            // Находим центр формы
            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;

            // Перемещаемся в заданную точку отчета
            g.TranslateTransform(cx, cy);
            g.FillEllipse(Brushes.Yellow, -45, -45, 90, 90);


            SolidBrush solBrush = new SolidBrush(Color.YellowGreen);
            Font f = new Font("Tahoma", 24, FontStyle.Bold);

            // Рисуем солнышко
            int counter = 0;
            for (counter = 0; counter < 20; counter++)
            {
                g.DrawString("C# Forever!!!", f, solBrush, 50, 0);
                g.RotateTransform(20);
            }

            // Восстанавливаем преобразовние
            g.ResetTransform();
            g.Dispose();
        }

        Color startColor = Color.Green;
        Color endColor = Color.Gold;
        string scrollText = "C# Forever!!!        ";

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = flag;
            flag = !flag;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scrollText = scrollText.Substring(1,
                    (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush grBrush = new LinearGradientBrush(this.ClientRectangle,
                startColor, endColor, 10);
            Font f = new Font(Font.Name, 60, Font.Style, GraphicsUnit.Pixel);
            e.Graphics.DrawString(scrollText, f, grBrush, 0, 100);
            grBrush.Dispose();
            f.Dispose();
        }
    }
}