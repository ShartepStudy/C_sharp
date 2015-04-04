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
        TabControl tabs = new TabControl();

        public ContainerForm()
        {

            ToolStripMenuItem Open = new ToolStripMenuItem();
            Open.Text = "Open";
            Open.Click += new EventHandler(Open_Click);
            mainMenu.Items.Add(Open);
            mainMenu.Parent = this;

            tabs.Location = new Point(0, 24);
            tabs.Width = this.Width;
            tabs.Height = this.Height - 24;
            tabs.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

            tabs.Parent = this;
            tabs.DoubleClick += new EventHandler(tabs_DoubleClick);

        }

        void tabs_DoubleClick(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabs.SelectedTab);
        }

        void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TabPage tab = new TabPage(dlg.SafeFileName);
                tab.Controls.Add(new PictureBox() {
                    Image = Image.FromFile(dlg.FileName), Dock = DockStyle.Fill
                });
                tabs.TabPages.Add(tab);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ContainerForm
            // 
            this.ClientSize = new System.Drawing.Size(558, 333);
            this.Name = "ContainerForm";
            this.ResumeLayout(false);

        }
    }
}
