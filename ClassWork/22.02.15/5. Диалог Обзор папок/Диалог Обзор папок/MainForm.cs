using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class MainForm :
        Form
    {
        private String m_path = @"C:\";

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClickBrowse(Object sender, EventArgs arguments)
        {
            var result = m_folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                m_path = m_folderBrowserDialog.SelectedPath;
            }
        }

        private void OnClickGetContent(Object sender, EventArgs arguments)
        {
            m_listBox.Items.Clear();

            var files = Directory.GetFiles(m_path);

            m_listBox.Items.Add(String.Format("Total number of files: {0}", files.Length));

            foreach (var file in files)
            {
                m_listBox.Items.Add(file);
            }
        }
    }
}