using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2011._10._31___Tetris
{
    public partial class FSettings : Form
    {
        public int _width;
        public int _height;
        public int _iSpeed;

        public FSettings(Point width, Point height)
        {
            InitializeComponent();
            this.AcceptButton = button1;
            this.CancelButton = button2;
            numericUpDown1.Minimum = width.X;
            numericUpDown1.Maximum = width.Y;
            numericUpDown2.Minimum = height.X;
            numericUpDown2.Maximum = height.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _width = (int)numericUpDown1.Value;
            _height = (int)numericUpDown2.Value;
            _iSpeed = (int)numericUpDown3.Value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
