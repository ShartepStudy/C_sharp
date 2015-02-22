using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_0
{
    public partial class Parent : Form
    {
        private readonly Parent mReciver = null;
        public string mText
        {
            set { textBox1.Text = value; }
        }

        public Parent()
        {
            InitializeComponent();

            mReciver = new Parent(this);
            mReciver.Show();
        }

        public Parent(Parent p)
        {
            InitializeComponent();

            Text = "Child";
            mReciver = p;
        }

        private void send_Click(object sender, EventArgs e)
        {
            mReciver.mText = textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            mReciver.mText = textBox1.Text;
        }
    }
}
