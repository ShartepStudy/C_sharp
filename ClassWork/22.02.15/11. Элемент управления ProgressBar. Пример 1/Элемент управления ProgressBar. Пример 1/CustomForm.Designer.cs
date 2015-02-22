namespace WindowsForms
{
    partial class CustomForm
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
            this.m_button = new System.Windows.Forms.Button();
            this.m_progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // m_button
            // 
            this.m_button.Location = new System.Drawing.Point(127, 41);
            this.m_button.Name = "m_button";
            this.m_button.Size = new System.Drawing.Size(75, 23);
            this.m_button.TabIndex = 3;
            this.m_button.Text = "Start";
            this.m_button.UseVisualStyleBackColor = true;
            this.m_button.Click += new System.EventHandler(this.OnClick);
            // 
            // m_progressBar
            // 
            this.m_progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.m_progressBar.ForeColor = System.Drawing.Color.Yellow;
            this.m_progressBar.Location = new System.Drawing.Point(12, 12);
            this.m_progressBar.Name = "m_progressBar";
            this.m_progressBar.Size = new System.Drawing.Size(307, 23);
            this.m_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.m_progressBar.TabIndex = 2;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 73);
            this.Controls.Add(this.m_button);
            this.Controls.Add(this.m_progressBar);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_button;
        private System.Windows.Forms.ProgressBar m_progressBar;
    }
}

