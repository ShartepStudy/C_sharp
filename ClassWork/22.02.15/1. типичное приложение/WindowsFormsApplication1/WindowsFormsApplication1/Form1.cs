using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Hello WinForms World!";

            this.Click += new EventHandler(ClickHandler);

            // this.MouseClick
        }

        public void ClickHandler(Object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }
    }
}
