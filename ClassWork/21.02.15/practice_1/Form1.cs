using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_1
{
    public partial class Form1 : Form
    {
        private int mTop;
        public Form1()
        {
            InitializeComponent();
            mTop = button1.Top;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left < (Size.Width - button1.Size.Width*1.5f)) {
                button1.Left++;
                button1.Top = mTop + (int)(30 * Math.Sin(button1.Left*150));
            } else {
                timer1.Stop();
            }
        }
    }
}
