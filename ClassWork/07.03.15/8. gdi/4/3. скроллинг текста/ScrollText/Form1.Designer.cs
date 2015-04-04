namespace WindowsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbVert = new System.Windows.Forms.RadioButton();
            this.rbHoriz = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbVert
            // 
            this.rbVert.AutoSize = true;
            this.rbVert.Location = new System.Drawing.Point(8, 4);
            this.rbVert.Margin = new System.Windows.Forms.Padding(2);
            this.rbVert.Name = "rbVert";
            this.rbVert.Size = new System.Drawing.Size(37, 17);
            this.rbVert.TabIndex = 0;
            this.rbVert.TabStop = true;
            this.rbVert.Text = "up";
            this.rbVert.UseVisualStyleBackColor = true;
            // 
            // rbHoriz
            // 
            this.rbHoriz.AutoSize = true;
            this.rbHoriz.Location = new System.Drawing.Point(8, 26);
            this.rbHoriz.Margin = new System.Windows.Forms.Padding(2);
            this.rbHoriz.Name = "rbHoriz";
            this.rbHoriz.Size = new System.Drawing.Size(39, 17);
            this.rbHoriz.TabIndex = 1;
            this.rbHoriz.TabStop = true;
            this.rbHoriz.Text = "left";
            this.rbHoriz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 305);
            this.Controls.Add(this.rbHoriz);
            this.Controls.Add(this.rbVert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Скроллинг текста";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbVert;
        private System.Windows.Forms.RadioButton rbHoriz;
    }
}

