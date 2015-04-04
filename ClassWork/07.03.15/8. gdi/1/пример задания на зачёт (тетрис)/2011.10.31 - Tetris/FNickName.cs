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
    public partial class FNickName : Form
    {
        public string name;

        public FNickName(UInt32 sc)
        {
            InitializeComponent();
            this.AcceptButton = button1;
            this.CancelButton = button2;
            label1.Text = "Your score: " + sc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            name = textBox1.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FNickName_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
