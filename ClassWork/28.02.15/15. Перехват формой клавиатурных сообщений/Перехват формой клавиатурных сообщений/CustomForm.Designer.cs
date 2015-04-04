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
            this.m_label = new System.Windows.Forms.Label();
            this.m_textBox = new System.Windows.Forms.TextBox();
            this.m_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_label
            // 
            this.m_label.Location = new System.Drawing.Point(12, 38);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(289, 23);
            this.m_label.TabIndex = 7;
            this.m_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_textBox
            // 
            this.m_textBox.Location = new System.Drawing.Point(93, 13);
            this.m_textBox.Name = "m_textBox";
            this.m_textBox.Size = new System.Drawing.Size(208, 20);
            this.m_textBox.TabIndex = 6;
            // 
            // m_button
            // 
            this.m_button.Location = new System.Drawing.Point(12, 12);
            this.m_button.Name = "m_button";
            this.m_button.Size = new System.Drawing.Size(75, 23);
            this.m_button.TabIndex = 4;
            this.m_button.Text = "Button";
            this.m_button.UseVisualStyleBackColor = true;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 72);
            this.Controls.Add(this.m_label);
            this.Controls.Add(this.m_textBox);
            this.Controls.Add(this.m_button);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keybord Interception";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_label;
        private System.Windows.Forms.TextBox m_textBox;
        private System.Windows.Forms.Button m_button;
    }
}

