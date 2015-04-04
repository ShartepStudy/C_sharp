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
            this.m_menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.utrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fsdfsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jhdsfdgfvdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fsdnbdfbndfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbnfdsbnfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsbnfdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xfbhxfbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xgbfdgbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menuStrip
            // 
            this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.m_menuStrip.Location = new System.Drawing.Point(0, 24);
            this.m_menuStrip.Name = "m_menuStrip";
            this.m_menuStrip.Size = new System.Drawing.Size(284, 24);
            this.m_menuStrip.TabIndex = 1;
            this.m_menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnClickNew);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Op&en";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnClickOpen);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnClickSave);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnClickSaveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnClickExit);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "123";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tryToolStripMenuItem,
            this.helloToolStripMenuItem,
            this.toolStripSeparator2,
            this.utrToolStripMenuItem,
            this.fsdfsdToolStripMenuItem,
            this.toolStripComboBox1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tryToolStripMenuItem
            // 
            this.tryToolStripMenuItem.Name = "tryToolStripMenuItem";
            this.tryToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.tryToolStripMenuItem.Text = "try";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(152, 23);
            this.helloToolStripMenuItem.Text = "hello";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // utrToolStripMenuItem
            // 
            this.utrToolStripMenuItem.Name = "utrToolStripMenuItem";
            this.utrToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.utrToolStripMenuItem.Text = "utr";
            // 
            // fsdfsdToolStripMenuItem
            // 
            this.fsdfsdToolStripMenuItem.Name = "fsdfsdToolStripMenuItem";
            this.fsdfsdToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.fsdfsdToolStripMenuItem.Text = "fsdfsd";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "dfgvsd",
            "zfvg"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jhdsfdgfvdbToolStripMenuItem,
            this.fsdnbdfbndfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jhdsfdgfvdbToolStripMenuItem
            // 
            this.jhdsfdgfvdbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xfbhxfbToolStripMenuItem,
            this.xgbfdgbToolStripMenuItem});
            this.jhdsfdgfvdbToolStripMenuItem.Name = "jhdsfdgfvdbToolStripMenuItem";
            this.jhdsfdgfvdbToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.jhdsfdgfvdbToolStripMenuItem.Text = "jhdsfdgfvdb";
            // 
            // fsdnbdfbndfToolStripMenuItem
            // 
            this.fsdnbdfbndfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fbnfdsbnfdToolStripMenuItem,
            this.dsbnfdbToolStripMenuItem});
            this.fsdnbdfbndfToolStripMenuItem.Name = "fsdnbdfbndfToolStripMenuItem";
            this.fsdnbdfbndfToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fsdnbdfbndfToolStripMenuItem.Text = "fsdnbdfbndf";
            // 
            // fbnfdsbnfdToolStripMenuItem
            // 
            this.fbnfdsbnfdToolStripMenuItem.Name = "fbnfdsbnfdToolStripMenuItem";
            this.fbnfdsbnfdToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fbnfdsbnfdToolStripMenuItem.Text = "fbnfdsbnfd";
            // 
            // dsbnfdbToolStripMenuItem
            // 
            this.dsbnfdbToolStripMenuItem.Name = "dsbnfdbToolStripMenuItem";
            this.dsbnfdbToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dsbnfdbToolStripMenuItem.Text = "dsbnfdb";
            // 
            // xfbhxfbToolStripMenuItem
            // 
            this.xfbhxfbToolStripMenuItem.Name = "xfbhxfbToolStripMenuItem";
            this.xfbhxfbToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xfbhxfbToolStripMenuItem.Text = "xfbhxfb";
            // 
            // xgbfdgbToolStripMenuItem
            // 
            this.xgbfdgbToolStripMenuItem.Name = "xgbfdgbToolStripMenuItem";
            this.xgbfdgbToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xgbfdgbToolStripMenuItem.Text = "xgbfdgb";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_menuStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuStrip";
            this.m_menuStrip.ResumeLayout(false);
            this.m_menuStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tryToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem utrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fsdfsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jhdsfdgfvdbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xfbhxfbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fsdnbdfbndfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fbnfdsbnfdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsbnfdbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xgbfdgbToolStripMenuItem;

    }
}

