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
            this.m_listBox = new System.Windows.Forms.ListBox();
            this.m_buttonBrowse = new System.Windows.Forms.Button();
            this.m_buttonGetContent = new System.Windows.Forms.Button();
            this.m_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // m_listBox
            // 
            this.m_listBox.FormattingEnabled = true;
            this.m_listBox.HorizontalScrollbar = true;
            this.m_listBox.Location = new System.Drawing.Point(12, 60);
            this.m_listBox.Name = "m_listBox";
            this.m_listBox.Size = new System.Drawing.Size(290, 212);
            this.m_listBox.TabIndex = 5;
            // 
            // m_buttonBrowse
            // 
            this.m_buttonBrowse.Location = new System.Drawing.Point(227, 12);
            this.m_buttonBrowse.Name = "m_buttonBrowse";
            this.m_buttonBrowse.Size = new System.Drawing.Size(75, 42);
            this.m_buttonBrowse.TabIndex = 4;
            this.m_buttonBrowse.Text = "Browse";
            this.m_buttonBrowse.UseVisualStyleBackColor = true;
            this.m_buttonBrowse.Click += new System.EventHandler(this.OnClickBrowse);
            // 
            // m_buttonGetContent
            // 
            this.m_buttonGetContent.Location = new System.Drawing.Point(12, 12);
            this.m_buttonGetContent.Name = "m_buttonGetContent";
            this.m_buttonGetContent.Size = new System.Drawing.Size(209, 42);
            this.m_buttonGetContent.TabIndex = 3;
            this.m_buttonGetContent.Text = "Get files and folders";
            this.m_buttonGetContent.UseVisualStyleBackColor = true;
            this.m_buttonGetContent.Click += new System.EventHandler(this.OnClickGetContent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 282);
            this.Controls.Add(this.m_listBox);
            this.Controls.Add(this.m_buttonBrowse);
            this.Controls.Add(this.m_buttonGetContent);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_listBox;
        private System.Windows.Forms.Button m_buttonBrowse;
        private System.Windows.Forms.Button m_buttonGetContent;
        private System.Windows.Forms.FolderBrowserDialog m_folderBrowserDialog;
    }
}

