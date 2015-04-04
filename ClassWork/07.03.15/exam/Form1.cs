using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form1 : Form
    {
        string mStartFolder = @"\\fs\Преподаватели\Загоруйко А\Public";

        public Form1()
        {
            InitializeComponent();
            textBox_target_path.Text = mStartFolder;
            fBD_open.SelectedPath = mStartFolder;

        }

        private void button_chose_folder_Click(object sender, EventArgs e)
        {
            if (fBD_open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mStartFolder = fBD_open.SelectedPath;
                textBox_target_path.Text = mStartFolder;
            }
        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            DirectoryInfo dInfo = new DirectoryInfo(mStartFolder);
            TreeNode nodeDir = new TreeNode(dInfo.FullName);
            treeView.Nodes.Add(nodeDir);
            nodeDir.Expand();

            AddDirectories(nodeDir);
            AddFiles(nodeDir);
        }
        void AddDirectories(TreeNode parentDir)
        {
            var dirInfo = new DirectoryInfo(parentDir.FullPath);
            DirectoryInfo[] arrayDirInfo = null;
            try
            {
                arrayDirInfo = dirInfo.GetDirectories();
            }
            catch
            { 
                return;
            }

            foreach (DirectoryInfo dir in arrayDirInfo)
            {
                TreeNode nodeDir = new TreeNode(dir.Name);
                parentDir.Nodes.Add(nodeDir);

                if (dir.GetDirectories().Length > 0 || dir.GetFiles().Length > 0)
                {
                    AddDirectories(nodeDir);
                    AddFiles(nodeDir);
                }
            }
        }

        void AddFiles(TreeNode parentDir)
        {
            var dirInfo = new DirectoryInfo(parentDir.FullPath);

            FileInfo[] arrayFileInfo = null;
            try
            {
                arrayFileInfo = dirInfo.GetFiles();
            }
            catch
            { 
                return;
            }

            foreach (FileInfo file in arrayFileInfo)
            {
                FileAttributes fileAttributes = File.GetAttributes(file.FullName);
                if (fileAttributes == FileAttributes.Hidden)
                {
                    TreeNode nodeFile = new TreeNode(file.Name);
                    parentDir.Nodes.Add(nodeFile);
                }
            }
        }
    }
}
