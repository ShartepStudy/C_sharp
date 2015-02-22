using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Black;
        }

        private void red_ValueChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb((int)red.Value, (int)green.Value, (int)blue.Value);
        }
    }
}
