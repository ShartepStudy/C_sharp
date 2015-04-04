using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            public void Xor(- применяет XOR операцию по отношению к региону и прямоугольнику.
                       Rectangle rect
                    );
            */
            Rectangle r = new Rectangle(70, 70, 170, 170);
            Region rgn = new Region(new Rectangle(0, 0, 100, 100));
            rgn.Xor(r);
            this.Region = rgn;
            this.BackColor = Color.Red;
        }
    }
}