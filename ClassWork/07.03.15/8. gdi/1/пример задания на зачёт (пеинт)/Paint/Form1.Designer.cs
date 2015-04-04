namespace Paint
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.New = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.trans = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxFront = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.example = new System.Windows.Forms.TextBox();
            this.Font = new System.Windows.Forms.Button();
            this.xy = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExample = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExample)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.FileName = "Untitled";
            this.saveFileDialog1.Filter = "*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png|*.gif|*.gif";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(12, 12);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(96, 23);
            this.New.TabIndex = 0;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 41);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(96, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 70);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(96, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 99);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(96, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pen";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Ruler";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "Figure";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 87);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.Text = "Text";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(278, 273);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(222, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Width :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trans
            // 
            this.trans.AutoSize = true;
            this.trans.Location = new System.Drawing.Point(450, 276);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(15, 14);
            this.trans.TabIndex = 11;
            this.trans.UseVisualStyleBackColor = true;
            this.trans.CheckedChanged += new System.EventHandler(this.trans_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(374, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Transparent";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxFront
            // 
            this.pictureBoxFront.BackColor = System.Drawing.Color.Black;
            this.pictureBoxFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFront.Location = new System.Drawing.Point(114, 257);
            this.pictureBoxFront.Name = "pictureBoxFront";
            this.pictureBoxFront.Size = new System.Drawing.Size(43, 43);
            this.pictureBoxFront.TabIndex = 13;
            this.pictureBoxFront.TabStop = false;
            this.pictureBoxFront.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.White;
            this.pictureBoxBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBack.Location = new System.Drawing.Point(135, 276);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(43, 43);
            this.pictureBoxBack.TabIndex = 14;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(223, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Text :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // example
            // 
            this.example.Location = new System.Drawing.Point(279, 300);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(92, 20);
            this.example.TabIndex = 16;
            this.example.Text = "Example";
            // 
            // Font
            // 
            this.Font.Location = new System.Drawing.Point(377, 295);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(88, 25);
            this.Font.TabIndex = 17;
            this.Font.Text = "Font";
            this.Font.UseVisualStyleBackColor = true;
            this.Font.Click += new System.EventHandler(this.Font_Click);
            // 
            // xy
            // 
            this.xy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy.Location = new System.Drawing.Point(471, 295);
            this.xy.Name = "xy";
            this.xy.Size = new System.Drawing.Size(109, 23);
            this.xy.TabIndex = 18;
            this.xy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(472, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 115);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBoxExample
            // 
            this.pictureBoxExample.BackColor = System.Drawing.Color.White;
            this.pictureBoxExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxExample.Location = new System.Drawing.Point(12, 257);
            this.pictureBoxExample.Name = "pictureBoxExample";
            this.pictureBoxExample.Size = new System.Drawing.Size(96, 62);
            this.pictureBoxExample.TabIndex = 22;
            this.pictureBoxExample.TabStop = false;
            this.pictureBoxExample.Click += new System.EventHandler(this.pictureBoxExample_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(120, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 238);
            this.panel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 334);
            this.Controls.Add(this.pictureBoxExample);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.xy);
            this.Controls.Add(this.Font);
            this.Controls.Add(this.example);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxFront);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.New);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(615, 372);
            this.MinimumSize = new System.Drawing.Size(615, 372);
            this.Name = "Form1";
            this.Text = "My Paint";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExample)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox trans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxFront;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox example;
        private System.Windows.Forms.Button Font;
        private System.Windows.Forms.Label xy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExample;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;

    }
}

