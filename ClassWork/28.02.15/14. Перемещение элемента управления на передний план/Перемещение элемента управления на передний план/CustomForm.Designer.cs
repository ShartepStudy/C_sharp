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
            this.m_buttonFront = new System.Windows.Forms.Button();
            this.m_buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_buttonFront
            // 
            this.m_buttonFront.Location = new System.Drawing.Point(98, 30);
            this.m_buttonFront.Margin = new System.Windows.Forms.Padding(2);
            this.m_buttonFront.Name = "m_buttonFront";
            this.m_buttonFront.Size = new System.Drawing.Size(106, 50);
            this.m_buttonFront.TabIndex = 6;
            this.m_buttonFront.Text = "Front";
            this.m_buttonFront.UseVisualStyleBackColor = true;
            this.m_buttonFront.Click += new System.EventHandler(this.OnClick);
            // 
            // m_buttonBack
            // 
            this.m_buttonBack.Location = new System.Drawing.Point(11, 11);
            this.m_buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.m_buttonBack.Name = "m_buttonBack";
            this.m_buttonBack.Size = new System.Drawing.Size(130, 51);
            this.m_buttonBack.TabIndex = 5;
            this.m_buttonBack.Text = "Back";
            this.m_buttonBack.UseVisualStyleBackColor = true;
            this.m_buttonBack.Click += new System.EventHandler(this.OnClick);
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 91);
            this.Controls.Add(this.m_buttonFront);
            this.Controls.Add(this.m_buttonBack);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bring Control to Front";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_buttonFront;
        private System.Windows.Forms.Button m_buttonBack;
    }
}

