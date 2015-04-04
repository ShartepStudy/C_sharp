using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 1024;
            numericUpDown2.Maximum = 768;
        }
        public int Width {
            get { return (int)numericUpDown1.Value; }
        }
        public int Height
        {
            get { return (int)numericUpDown2.Value; }
        }
    }
}
