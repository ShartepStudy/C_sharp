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

        // public Type GetType() - ���������� ������ Type ��� �������� ����������.

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap pic1 = new Bitmap(this.GetType(), "p_cat2s.jpg"); // ����������� �������� � �������� ����������
            this.button1.BackgroundImage = pic1;
            Bitmap pic2 = new Bitmap(this.GetType(), "s109.jpg");
            this.pictureBox1.BackgroundImage = pic2;
        }
    }
}