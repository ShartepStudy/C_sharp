using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scale frm = new Scale();
            frm.Show();
            AddOwnedForm(frm); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Translate frm = new Translate();
            frm.Show();
            AddOwnedForm(frm); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rotate frm = new Rotate();
            frm.Show();
            AddOwnedForm(frm); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rotate2 frm = new Rotate2();
            frm.Show();
            AddOwnedForm(frm); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shear frm = new Shear();
            frm.Show();
            AddOwnedForm(frm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shear2 frm = new Shear2();
            frm.Show();
            AddOwnedForm(frm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mioring frm = new mioring();
            frm.Show();
            AddOwnedForm(frm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Combine frm = new Combine();
            frm.Show();
            AddOwnedForm(frm);
        }

       

        
    }
}