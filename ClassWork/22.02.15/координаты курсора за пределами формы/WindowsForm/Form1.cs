using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 20;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }
        void t_Tick(object sender, EventArgs e)
        {
            string str = "X = " + MousePosition.X.ToString() + " " + "Y = " + MousePosition.Y.ToString();
            this.Text = str;
        }

    }
}
