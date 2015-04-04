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
            this.m_labelB = new System.Windows.Forms.Label();
            this.m_labelG = new System.Windows.Forms.Label();
            this.m_labelR = new System.Windows.Forms.Label();
            this.m_trackBarBlue = new System.Windows.Forms.TrackBar();
            this.m_trackBarGreen = new System.Windows.Forms.TrackBar();
            this.m_trackBarRed = new System.Windows.Forms.TrackBar();
            this.m_labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // m_labelB
            // 
            this.m_labelB.AutoSize = true;
            this.m_labelB.Location = new System.Drawing.Point(13, 127);
            this.m_labelB.Name = "m_labelB";
            this.m_labelB.Size = new System.Drawing.Size(14, 13);
            this.m_labelB.TabIndex = 13;
            this.m_labelB.Text = "B";
            // 
            // m_labelG
            // 
            this.m_labelG.AutoSize = true;
            this.m_labelG.Location = new System.Drawing.Point(12, 76);
            this.m_labelG.Name = "m_labelG";
            this.m_labelG.Size = new System.Drawing.Size(15, 13);
            this.m_labelG.TabIndex = 12;
            this.m_labelG.Text = "G";
            // 
            // m_labelR
            // 
            this.m_labelR.AutoSize = true;
            this.m_labelR.Location = new System.Drawing.Point(12, 25);
            this.m_labelR.Name = "m_labelR";
            this.m_labelR.Size = new System.Drawing.Size(15, 13);
            this.m_labelR.TabIndex = 11;
            this.m_labelR.Text = "R";
            // 
            // m_trackBarBlue
            // 
            this.m_trackBarBlue.Location = new System.Drawing.Point(33, 127);
            this.m_trackBarBlue.Maximum = 255;
            this.m_trackBarBlue.Name = "m_trackBarBlue";
            this.m_trackBarBlue.Size = new System.Drawing.Size(239, 45);
            this.m_trackBarBlue.TabIndex = 10;
            this.m_trackBarBlue.TickFrequency = 10;
            this.m_trackBarBlue.Scroll += new System.EventHandler(this.OnScrollBlue);
            // 
            // m_trackBarGreen
            // 
            this.m_trackBarGreen.Location = new System.Drawing.Point(33, 76);
            this.m_trackBarGreen.Maximum = 255;
            this.m_trackBarGreen.Name = "m_trackBarGreen";
            this.m_trackBarGreen.Size = new System.Drawing.Size(239, 45);
            this.m_trackBarGreen.TabIndex = 9;
            this.m_trackBarGreen.TickFrequency = 10;
            this.m_trackBarGreen.Scroll += new System.EventHandler(this.OnScrollGreen);
            // 
            // m_trackBarRed
            // 
            this.m_trackBarRed.Location = new System.Drawing.Point(33, 25);
            this.m_trackBarRed.Maximum = 255;
            this.m_trackBarRed.Name = "m_trackBarRed";
            this.m_trackBarRed.Size = new System.Drawing.Size(239, 45);
            this.m_trackBarRed.TabIndex = 7;
            this.m_trackBarRed.TickFrequency = 10;
            this.m_trackBarRed.Scroll += new System.EventHandler(this.OnScrollRed);
            // 
            // m_labelTitle
            // 
            this.m_labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_labelTitle.AutoSize = true;
            this.m_labelTitle.BackColor = System.Drawing.Color.White;
            this.m_labelTitle.Location = new System.Drawing.Point(90, 9);
            this.m_labelTitle.Name = "m_labelTitle";
            this.m_labelTitle.Size = new System.Drawing.Size(93, 13);
            this.m_labelTitle.TabIndex = 0;
            this.m_labelTitle.Text = "Change form color";
            this.m_labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.m_labelTitle);
            this.Controls.Add(this.m_labelB);
            this.Controls.Add(this.m_labelG);
            this.Controls.Add(this.m_labelR);
            this.Controls.Add(this.m_trackBarBlue);
            this.Controls.Add(this.m_trackBarGreen);
            this.Controls.Add(this.m_trackBarRed);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackBar";
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_labelB;
        private System.Windows.Forms.Label m_labelG;
        private System.Windows.Forms.Label m_labelR;
        private System.Windows.Forms.TrackBar m_trackBarBlue;
        private System.Windows.Forms.TrackBar m_trackBarGreen;
        private System.Windows.Forms.TrackBar m_trackBarRed;
        private System.Windows.Forms.Label m_labelTitle;
    }
}

