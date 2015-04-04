using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewEarthBrowser
{
    public partial class UserInput : Form
    {
        public delegate void FormAction(string s);
        public event FormAction Confirm;

        public UserInput(string name = null)
        {
            InitializeComponent();
            if (name != null)
                textBox1.Text = name;
            this.AcceptButton = button1;
            this.CancelButton = button2;
        }

        private void ConfirmName(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                Confirm(textBox1.Text);
                this.Close();
            }
        }

        private void UserInput_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
