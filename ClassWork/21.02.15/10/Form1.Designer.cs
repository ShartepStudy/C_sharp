namespace Пробег_мышки
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblProbeg = new System.Windows.Forms.Label();
            this.tmrDef = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblProbeg
            // 
            this.lblProbeg.AutoSize = true;
            this.lblProbeg.BackColor = System.Drawing.Color.Transparent;
            this.lblProbeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProbeg.ForeColor = System.Drawing.SystemColors.Info;
            this.lblProbeg.Location = new System.Drawing.Point(26, 26);
            this.lblProbeg.Name = "lblProbeg";
            this.lblProbeg.Size = new System.Drawing.Size(54, 13);
            this.lblProbeg.TabIndex = 0;
            this.lblProbeg.Text = "Пробег:";
            // 
            // tmrDef
            // 
            this.tmrDef.Enabled = true;
            this.tmrDef.Interval = 10;
            this.tmrDef.Tick += new System.EventHandler(this.tmrDef_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(605, 376);
            this.Controls.Add(this.lblProbeg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProbeg;
        private System.Windows.Forms.Timer tmrDef;
    }
}

