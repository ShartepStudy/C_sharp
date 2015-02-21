using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardCaption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                StringBuilder str = new StringBuilder(Text.ToString());
                int len = str.Length;
                if (len > 0)
                {
                    str.Remove(len - 1, 1);
                    Text = str.ToString();
                }
               
            }
            else
            {
                Text = Text + "" + e.KeyChar.ToString();
            }
            
            
        }
    }
}
