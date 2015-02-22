namespace Процесс_загрузки_файла
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDest = new System.Windows.Forms.Button();
            this.lblProgressStatus = new System.Windows.Forms.Label();
            this.btnStartCopy = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(40, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(280, 31);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 2;
            this.btnDest.Text = "Куда ? ...";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // lblProgressStatus
            // 
            this.lblProgressStatus.AutoSize = true;
            this.lblProgressStatus.Location = new System.Drawing.Point(37, 72);
            this.lblProgressStatus.Name = "lblProgressStatus";
            this.lblProgressStatus.Size = new System.Drawing.Size(88, 13);
            this.lblProgressStatus.TabIndex = 3;
            this.lblProgressStatus.Text = "Скопировано %:";
            // 
            // btnStartCopy
            // 
            this.btnStartCopy.Location = new System.Drawing.Point(166, 128);
            this.btnStartCopy.Name = "btnStartCopy";
            this.btnStartCopy.Size = new System.Drawing.Size(75, 23);
            this.btnStartCopy.TabIndex = 4;
            this.btnStartCopy.Text = "Копировать";
            this.btnStartCopy.UseVisualStyleBackColor = true;
            this.btnStartCopy.Click += new System.EventHandler(this.btnStartCopy_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 163);
            this.Controls.Add(this.btnStartCopy);
            this.Controls.Add(this.lblProgressStatus);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Статус загрузки файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Label lblProgressStatus;
        private System.Windows.Forms.Button btnStartCopy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

