namespace NTetris
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продолжитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСохранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextFigurePallete = new System.Windows.Forms.PictureBox();
            this.pallete = new System.Windows.Forms.PictureBox();
            this.information = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextFigurePallete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pallete)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пауза. Нажмините \"Ctrl-P\" для продолжения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(239, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem1,
            this.паузаToolStripMenuItem,
            this.продолжитьToolStripMenuItem,
            this.остановитьИгруToolStripMenuItem,
            this.toolStripMenuItem4,
            this.сохранитьИгруToolStripMenuItem,
            this.очиститьСохранениеToolStripMenuItem,
            this.toolStripMenuItem3,
            this.выходToolStripMenuItem1});
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.новаяИграToolStripMenuItem.Text = global::NTetris.Properties.Resources.game_menu;
            // 
            // новаяИграToolStripMenuItem1
            // 
            this.новаяИграToolStripMenuItem1.Image = global::NTetris.Properties.Resources.Play_16x16;
            this.новаяИграToolStripMenuItem1.Name = "новаяИграToolStripMenuItem1";
            this.новаяИграToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.новаяИграToolStripMenuItem1.Text = global::NTetris.Properties.Resources.new_game;
            this.новаяИграToolStripMenuItem1.Click += new System.EventHandler(this.новаяИграToolStripMenuItem1_Click);
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Image = global::NTetris.Properties.Resources.Pause_16x16;
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.паузаToolStripMenuItem.Text = "Пауза   ";
            this.паузаToolStripMenuItem.Click += new System.EventHandler(this.паузаToolStripMenuItem_Click);
            // 
            // продолжитьToolStripMenuItem
            // 
            this.продолжитьToolStripMenuItem.Image = global::NTetris.Properties.Resources.Play_16x16;
            this.продолжитьToolStripMenuItem.Name = "продолжитьToolStripMenuItem";
            this.продолжитьToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.продолжитьToolStripMenuItem.Text = "Продолжить ";
            this.продолжитьToolStripMenuItem.Visible = false;
            this.продолжитьToolStripMenuItem.Click += new System.EventHandler(this.продолжитьToolStripMenuItem_Click);
            // 
            // остановитьИгруToolStripMenuItem
            // 
            this.остановитьИгруToolStripMenuItem.Image = global::NTetris.Properties.Resources.Stop_16x16;
            this.остановитьИгруToolStripMenuItem.Name = "остановитьИгруToolStripMenuItem";
            this.остановитьИгруToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.остановитьИгруToolStripMenuItem.Text = global::NTetris.Properties.Resources.stop_game;
            this.остановитьИгруToolStripMenuItem.Click += new System.EventHandler(this.остановитьИгруToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 6);
            // 
            // сохранитьИгруToolStripMenuItem
            // 
            this.сохранитьИгруToolStripMenuItem.Image = global::NTetris.Properties.Resources.icon_menu_save_game;
            this.сохранитьИгруToolStripMenuItem.Name = "сохранитьИгруToolStripMenuItem";
            this.сохранитьИгруToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сохранитьИгруToolStripMenuItem.Text = "Сохранить игру";
            this.сохранитьИгруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИгруToolStripMenuItem_Click);
            // 
            // очиститьСохранениеToolStripMenuItem
            // 
            this.очиститьСохранениеToolStripMenuItem.Image = global::NTetris.Properties.Resources.icon_menu_resume_game;
            this.очиститьСохранениеToolStripMenuItem.Name = "очиститьСохранениеToolStripMenuItem";
            this.очиститьСохранениеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.очиститьСохранениеToolStripMenuItem.Text = global::NTetris.Properties.Resources.clear_save;
            this.очиститьСохранениеToolStripMenuItem.Visible = false;
            this.очиститьСохранениеToolStripMenuItem.Click += new System.EventHandler(this.очиститьСохранениеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 6);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = global::NTetris.Properties.Resources.Remove_16x16;
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.выходToolStripMenuItem1.Text = global::NTetris.Properties.Resources.exit_game;
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::NTetris.Properties.Resources.Information_16x16;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьЗановоToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьЗановоToolStripMenuItem
            // 
            this.начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            this.начатьЗановоToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.начатьЗановоToolStripMenuItem.Text = "Новая игра";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // nextFigurePallete
            // 
            this.nextFigurePallete.Location = new System.Drawing.Point(179, 60);
            this.nextFigurePallete.Name = "nextFigurePallete";
            this.nextFigurePallete.Size = new System.Drawing.Size(51, 61);
            this.nextFigurePallete.TabIndex = 4;
            this.nextFigurePallete.TabStop = false;
            // 
            // pallete
            // 
            this.pallete.Location = new System.Drawing.Point(0, 60);
            this.pallete.Name = "pallete";
            this.pallete.Size = new System.Drawing.Size(173, 205);
            this.pallete.TabIndex = 0;
            this.pallete.TabStop = false;
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.White;
            this.information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.information.Font = new System.Drawing.Font("Tahoma", 6.7F);
            this.information.Location = new System.Drawing.Point(179, 131);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(51, 67);
            this.information.TabIndex = 5;
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(239, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NTetris.Properties.Resources.Play_16x16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Новая игра";
            this.toolStripButton1.Click += new System.EventHandler(this.новаяИграToolStripMenuItem1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::NTetris.Properties.Resources.Pause_16x16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.паузаToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::NTetris.Properties.Resources.Play_16x16;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Visible = false;
            this.toolStripButton3.Click += new System.EventHandler(this.продолжитьToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::NTetris.Properties.Resources.Stop_16x16;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Visible = false;
            this.toolStripButton4.Click += new System.EventHandler(this.остановитьИгруToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::NTetris.Properties.Resources.icon_menu_save_game;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.сохранитьИгруToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::NTetris.Properties.Resources.icon_menu_resume_game;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Очистить сохранения";
            this.toolStripButton6.Click += new System.EventHandler(this.очиститьСохранениеToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::NTetris.Properties.Resources.Remove_16x16;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Выход";
            this.toolStripButton7.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::NTetris.Properties.Resources.Information_16x16;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "О программе";
            this.toolStripButton8.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NTetris.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(239, 304);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.information);
            this.Controls.Add(this.nextFigurePallete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pallete);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тетрис";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextFigurePallete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pallete)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox nextFigurePallete;
        private System.Windows.Forms.ToolStripMenuItem остановитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        public System.Windows.Forms.PictureBox pallete;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem сохранитьИгруToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem очиститьСохранениеToolStripMenuItem;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.ToolStripMenuItem продолжитьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}

