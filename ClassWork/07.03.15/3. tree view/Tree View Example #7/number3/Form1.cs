using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace number3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DirectoryInfo dinfo;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dinfo = new DirectoryInfo(fbd.SelectedPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode nodeDrive = new TreeNode(dinfo.FullName);
            // Добавляем корневой узел к дереву просмотра
            treeView1.Nodes.Add(nodeDrive);
            // Развертываем корневой узел
            nodeDrive.Expand();
            AddDirectories(nodeDrive);
        }

        void AddDirectories(TreeNode node)
        {
            // для текущего узла node получаем полный путь к корню дерева
            string strPath = node.FullPath;
            // создаём объект текущего каталога
            DirectoryInfo dirInfo = new DirectoryInfo(strPath);
            // ссылка на массив подкаталогов текущего каталога
            DirectoryInfo[] arrayDirInfo;
            try
            {
                arrayDirInfo = dirInfo.GetDirectories();
            }
            catch
            {  
                // если нет подкаталогов - выходим из рекурсии
                return;
            }
            // проход по всем подкаталогам
            foreach (DirectoryInfo dir in arrayDirInfo)
            {
                // проверяем, или есть файлы в подкаталогах текущего каталога
                string[] check_files = Directory.GetFiles(dir.FullName, "*" + textBox1.Text, SearchOption.AllDirectories);
                // если есть
                if (check_files.Length > 0)
                {
                    // пытаемся сделать узел, на который будем весить названия папок, в которых есть файлы, или просто названия файлов
                    TreeNode nodeDir = new TreeNode(dir.Name); // название узла - это название папки
                    // получаем список файлов в текущей папке
                    // на следующей строчке можно сделать не фулл нейм, а просто нейм!
                    string[] file_names = Directory.GetFiles(dir.FullName, "*" + textBox1.Text);
                    foreach (string name in check_files)
                    {
                        // привязываем узлы с именами файлов к узлу с названием папки
                        TreeNode nd = new TreeNode(name);

                        if (file_names.Length > 0)
                        {
                            nodeDir.Nodes.Add(nd);
                        }
                    }
                    // весим узел с названием папки (который уже с узлами-файлами)
                    node.Nodes.Add(nodeDir);
                    // запускаем рекурсию
                    AddDirectories(nodeDir);
                }
            }
        }
    }
}
