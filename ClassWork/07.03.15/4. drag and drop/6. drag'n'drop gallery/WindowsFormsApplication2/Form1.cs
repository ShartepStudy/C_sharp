using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApplication2
{
    partial class Form1 : Form
    {
        PictureBox pb = new PictureBox() { Dock = DockStyle.Fill };
        Label lb = new Label() { Dock = DockStyle.Bottom };
        Label lb2 = new Label() { Dock = DockStyle.Bottom };

        public string path, path1;
        public int current_item = 0;

        public Form1()
        {
            this.Text = "Перетащите jpg изображение на форму...";
            this.StartPosition = 0;
            this.Size = new Size(SystemInformation.PrimaryMonitorSize.Width/2, SystemInformation.PrimaryMonitorSize.Height - 40);
            
            pb.Parent = this;
            pb.AllowDrop = true;
            pb.DragDrop += new DragEventHandler(pb_DragDrop);
            pb.DragEnter += new DragEventHandler(pb_DragEnter);
            KeyDown += new System.Windows.Forms.KeyEventHandler(Form2_KeyDown);

            lb.Parent = this;
            lb2.Parent = this;
        }

        void pb_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string path = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
                if (path.Substring(path.LastIndexOf('.')) == ".jpg")
                    e.Effect = DragDropEffects.Link;
            }
        }

        void pb_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                path = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
                MessageBox.Show(path.ToString());

                path1 = path.Remove(path.LastIndexOf('\\') + 1);
                var bmpFiles = Directory.EnumerateFiles(path1, "*.jpg", SearchOption.TopDirectoryOnly);

                foreach (string currentFile in bmpFiles)
                {
                    //MessageBox.Show(currentFile.ToString());
                    pb.Image = Image.FromFile(currentFile);
                }

                current_item = bmpFiles.ToArray().Length - 1;
                lb.Text = "Текущая картинка: " + (current_item + 1).ToString();
                lb2.Text = "Всего картинок: " + bmpFiles.ToArray().Length;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            var bmpFiles = Directory.EnumerateFiles(path1, "*.jpg", SearchOption.AllDirectories);

            if (e.KeyCode.ToString() == "Left")
            {
                if (current_item == 0)
                    MessageBox.Show("Это - первый элемент коллекции.");
                else
                {
                    --current_item;
                    pb.Image = Image.FromFile(bmpFiles.ToArray()[current_item]);
                    lb.Text = "Текущая картинка: " + (current_item + 1).ToString();
                }
            }
            else
                if (e.KeyCode.ToString() == "Right")
                {
                    if (current_item == bmpFiles.ToArray().Length - 1)
                        MessageBox.Show("Это - последний элемент коллекции.");
                    else
                    {
                        ++current_item;
                        pb.Image = Image.FromFile(bmpFiles.ToArray()[current_item]);
                        lb.Text = "Текущая картинка: " + (current_item + 1).ToString();
                    }
                }
        }
    }
}
