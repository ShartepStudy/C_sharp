namespace exam
{
    partial class Form1
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.button_scan = new System.Windows.Forms.Button();
            this.textBox_target_path = new System.Windows.Forms.TextBox();
            this.button_chose_folder = new System.Windows.Forms.Button();
            this.fBD_open = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(783, 458);
            this.treeView.TabIndex = 0;
            // 
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(720, 570);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(75, 23);
            this.button_scan.TabIndex = 1;
            this.button_scan.Text = "Scan";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // textBox_target_path
            // 
            this.textBox_target_path.Location = new System.Drawing.Point(162, 573);
            this.textBox_target_path.Name = "textBox_target_path";
            this.textBox_target_path.Size = new System.Drawing.Size(403, 20);
            this.textBox_target_path.TabIndex = 2;
            // 
            // button_chose_folder
            // 
            this.button_chose_folder.Location = new System.Drawing.Point(571, 573);
            this.button_chose_folder.Name = "button_chose_folder";
            this.button_chose_folder.Size = new System.Drawing.Size(24, 20);
            this.button_chose_folder.TabIndex = 3;
            this.button_chose_folder.Text = "...";
            this.button_chose_folder.UseVisualStyleBackColor = true;
            this.button_chose_folder.Click += new System.EventHandler(this.button_chose_folder_Click);
            // 
            // fBD_open
            // 
            this.fBD_open.SelectedPath = "\\\\fs";
            this.fBD_open.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 605);
            this.Controls.Add(this.button_chose_folder);
            this.Controls.Add(this.textBox_target_path);
            this.Controls.Add(this.button_scan);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.TextBox textBox_target_path;
        private System.Windows.Forms.Button button_chose_folder;
        private System.Windows.Forms.FolderBrowserDialog fBD_open;
    }
}

