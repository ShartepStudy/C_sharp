using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class ContainerForm : Form
    {
        MenuStrip mainMenu = new MenuStrip();

        public ContainerForm()
        {
            this.IsMdiContainer = true;
            ToolStripMenuItem Open = new ToolStripMenuItem();
            Open.Text = "Open";
            Open.Click += new EventHandler(Open_Click);
            mainMenu.Items.Add(Open);
            mainMenu.Parent = this;

        }

        void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bitmap |*.bmp|Jpeg |*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PictureForm tmp = new PictureForm(dlg.FileName);
                //tmp.Path = dlg.FileName;
                tmp.MdiParent = this;
                tmp.Show();
            }
        }
    }


    class PictureForm : Form
    {
        PictureBox image = new PictureBox();
        public string Path { get; set; }
        MenuStrip menu = new MenuStrip();
        public PictureForm(string Path)
        {
            image.Parent = this;
            image.Dock = DockStyle.Fill;
            image.Image = Image.FromFile(this.Path = Path);
            this.Text = Path;
            menu.Parent = this;
            menu.Items.Add("Item");
            menu.Items.Add("Item");
            menu.Items.Add("Item");
            menu.Items.Add("Item");
        }
    }
}
