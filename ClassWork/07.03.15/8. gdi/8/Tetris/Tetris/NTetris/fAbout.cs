using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NTetris
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {
            String str = "Программа \"Тетрис\"\r\nВыполнил:\r\nАлександр Соловьёв";
            label1.Text = str;
        }

       
    }
}
