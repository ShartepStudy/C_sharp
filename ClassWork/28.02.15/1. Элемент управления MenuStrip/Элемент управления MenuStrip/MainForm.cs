using System;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class MainForm :
        Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClickExit(Object sender, EventArgs arguments)
        {
            var item = sender as ToolStripMenuItem;
            MessageBox.Show(item.Text);

            Close();
        }

        private void OnClickNew(Object sender, EventArgs arguments)
        {
            var item = sender as ToolStripMenuItem;
            MessageBox.Show(item.Text);
        }

        private void OnClickOpen(Object sender, EventArgs arguments)
        {
            var item = sender as ToolStripMenuItem;
            MessageBox.Show(item.Text);
        }

        private void OnClickSave(Object sender, EventArgs arguments)
        {
            var item = sender as ToolStripMenuItem;
            MessageBox.Show(item.Text);
        }

        private void OnClickSaveAs(Object sender, EventArgs arguments)
        {
            var item = sender as ToolStripMenuItem;
            MessageBox.Show(item.Text);
        }
    }
}