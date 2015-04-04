using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DragNDropExample
{
    public partial class Form1 : Form
    {
        string some_text;
        public Form1()
        {
            InitializeComponent();
            some_text = "";
            listBox1.AllowDrop = true;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            some_text = "";
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (some_text != "")
                textBox2.DoDragDrop(some_text, DragDropEffects.Copy);
        }

        private void textBox2_MouseUp_1(object sender, MouseEventArgs e)
        {
            some_text = textBox2.SelectedText;
        }
    }
}