namespace DesktopWallpaper
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
            this.btnSet = new System.Windows.Forms.Button();
            this.openGraphic = new System.Windows.Forms.OpenFileDialog();
            this.picThumbnail = new System.Windows.Forms.PictureBox();
            this.ddlStyle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(42, 196);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(144, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set Desktop Background";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // picThumbnail
            // 
            this.picThumbnail.Location = new System.Drawing.Point(12, 12);
            this.picThumbnail.Name = "picThumbnail";
            this.picThumbnail.Size = new System.Drawing.Size(200, 150);
            this.picThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThumbnail.TabIndex = 1;
            this.picThumbnail.TabStop = false;
            // 
            // ddlStyle
            // 
            this.ddlStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStyle.Items.AddRange(new object[] {
            "Fit To Screen",
            "Center",
            "Tile"});
            this.ddlStyle.Location = new System.Drawing.Point(12, 169);
            this.ddlStyle.Name = "ddlStyle";
            this.ddlStyle.Size = new System.Drawing.Size(200, 21);
            this.ddlStyle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 230);
            this.Controls.Add(this.ddlStyle);
            this.Controls.Add(this.picThumbnail);
            this.Controls.Add(this.btnSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Desktop Wallpaper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.OpenFileDialog openGraphic;
        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.ComboBox ddlStyle;
    }
}

