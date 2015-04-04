namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.восстановитьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_contextMenuStrip
            // 
            this.m_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.восстановитьОкноToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.m_contextMenuStrip.Name = "contextMenuStrip1";
            this.m_contextMenuStrip.Size = new System.Drawing.Size(114, 54);
            // 
            // восстановитьОкноToolStripMenuItem
            // 
            this.восстановитьОкноToolStripMenuItem.Name = "восстановитьОкноToolStripMenuItem";
            this.восстановитьОкноToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.восстановитьОкноToolStripMenuItem.Text = "Restore";
            this.восстановитьОкноToolStripMenuItem.Click += new System.EventHandler(this.OnClickRestore);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.OnClickExit);
            // 
            // m_notifyIcon
            // 
            this.m_notifyIcon.BalloonTipText = "System Tray Icon";
            this.m_notifyIcon.BalloonTipTitle = "System Tray";
            this.m_notifyIcon.ContextMenuStrip = this.m_contextMenuStrip;
            this.m_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_notifyIcon.Icon")));
            this.m_notifyIcon.Text = "System Tray Tooltip";
            this.m_notifyIcon.Visible = true;
            this.m_notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.m_contextMenuStrip;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Tray";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Resize += new System.EventHandler(this.OnResize);
            this.m_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip m_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem восстановитьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
    }
}

