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

        string text = "C#  GDI+  3DText";

        private void button2_Click(object sender, EventArgs e)
        {
            // ������ ���������� �����
            SolidBrush solBrush = new SolidBrush(Color.Gray);
            Font f = new Font("Tahoma", 48, FontStyle.Bold);
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            g.DrawString(text, f, solBrush, 10, 10);
            solBrush.Color = Color.White;
            // ������� ������ ���� ���� � ������
            g.DrawString(text, f, solBrush, 12, 11);
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������ �������� �����
            SolidBrush solBrush = new SolidBrush(Color.Gray);
            Font f = new Font("Tahoma", 48, FontStyle.Bold);
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            g.DrawString(text, f, solBrush, 10, 10);
            solBrush.Color = Color.White;
            // ������� ������ ���� ���� � �����
            g.DrawString(text, f, solBrush, 8, 8);

            Brush br = new HatchBrush(HatchStyle.Cross, Color.Red);
			Font f1 = this.Font;
			g.DrawString("Font from form font", f1, br, new Point(10, 85));
			
			Font f2 = new Font(this.Font, FontStyle.Underline);
			g.DrawString("Font based on another", f2, br, new Point(10, 110));
			
			FontFamily family = new FontFamily("Georgia");
			Font f3 = new Font(family, 30, FontStyle.Italic, GraphicsUnit.Pixel);
			g.DrawString("Font based on custom family", f3, br, new Point(10, 130));

            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ������� ������� ������
            GraphicsPath pth = new GraphicsPath();
            // ��������� �������
            pth.AddString(text, new FontFamily("Calibri"),
                0, 75, new Point(15, 15), StringFormat.GenericTypographic);

            // ������� ����� ����
            Pen p = new Pen(Color.Orange, 2);

            // ������� ��������� �����
            Graphics g = CreateGraphics();
            g.Clear(Color.Black);

            // �����������
            // http://msdn.microsoft.com/ru-ru/library/9t6sa8s9.aspx

            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawPath(p, pth);

            pth.Dispose();
            g.Dispose();
        }
    }
}