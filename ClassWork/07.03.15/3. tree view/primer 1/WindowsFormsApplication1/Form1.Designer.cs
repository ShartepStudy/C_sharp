namespace TreeViewEarthBrowser
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContinentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuContinent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCountry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuForm.SuspendLayout();
            this.contextMenuContinent.SuspendLayout();
            this.contextMenuCountry.SuspendLayout();
            this.contextMenuCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(335, 330);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuForm
            // 
            this.contextMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContinentToolStripMenuItem,
            this.findToolStripMenuItem});
            this.contextMenuForm.Name = "contextMenuForm";
            this.contextMenuForm.Size = new System.Drawing.Size(151, 48);
            // 
            // addContinentToolStripMenuItem
            // 
            this.addContinentToolStripMenuItem.Name = "addContinentToolStripMenuItem";
            this.addContinentToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addContinentToolStripMenuItem.Text = "Add continent";
            this.addContinentToolStripMenuItem.Click += new System.EventHandler(this.addContinentToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continentToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.cityToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // continentToolStripMenuItem
            // 
            this.continentToolStripMenuItem.Name = "continentToolStripMenuItem";
            this.continentToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.continentToolStripMenuItem.Text = "Continent";
            this.continentToolStripMenuItem.Click += new System.EventHandler(this.continentToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // contextMenuContinent
            // 
            this.contextMenuContinent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.addCityToolStripMenuItem,
            this.findToolStripMenuItem1});
            this.contextMenuContinent.Name = "contextMenuContinent";
            this.contextMenuContinent.Size = new System.Drawing.Size(141, 92);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // addCityToolStripMenuItem
            // 
            this.addCityToolStripMenuItem.Name = "addCityToolStripMenuItem";
            this.addCityToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addCityToolStripMenuItem.Text = "Add country";
            this.addCityToolStripMenuItem.Click += new System.EventHandler(this.addCityToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem1
            // 
            this.findToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem1,
            this.cityToolStripMenuItem1});
            this.findToolStripMenuItem1.Name = "findToolStripMenuItem1";
            this.findToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.findToolStripMenuItem1.Text = "Find";
            // 
            // countryToolStripMenuItem1
            // 
            this.countryToolStripMenuItem1.Name = "countryToolStripMenuItem1";
            this.countryToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.countryToolStripMenuItem1.Text = "Country";
            this.countryToolStripMenuItem1.Click += new System.EventHandler(this.countryToolStripMenuItem1_Click);
            // 
            // cityToolStripMenuItem1
            // 
            this.cityToolStripMenuItem1.Name = "cityToolStripMenuItem1";
            this.cityToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.cityToolStripMenuItem1.Text = "City";
            this.cityToolStripMenuItem1.Click += new System.EventHandler(this.cityToolStripMenuItem1_Click);
            // 
            // contextMenuCountry
            // 
            this.contextMenuCountry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem1,
            this.addCityToolStripMenuItem1,
            this.findCityToolStripMenuItem});
            this.contextMenuCountry.Name = "contextMenuCountry";
            this.contextMenuCountry.Size = new System.Drawing.Size(120, 92);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // addCityToolStripMenuItem1
            // 
            this.addCityToolStripMenuItem1.Name = "addCityToolStripMenuItem1";
            this.addCityToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.addCityToolStripMenuItem1.Text = "Add city";
            this.addCityToolStripMenuItem1.Click += new System.EventHandler(this.addCityToolStripMenuItem1_Click);
            // 
            // findCityToolStripMenuItem
            // 
            this.findCityToolStripMenuItem.Name = "findCityToolStripMenuItem";
            this.findCityToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.findCityToolStripMenuItem.Text = "Find city";
            this.findCityToolStripMenuItem.Click += new System.EventHandler(this.findCityToolStripMenuItem_Click);
            // 
            // contextMenuCity
            // 
            this.contextMenuCity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem2,
            this.removeToolStripMenuItem2});
            this.contextMenuCity.Name = "contextMenuCity";
            this.contextMenuCity.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // removeToolStripMenuItem2
            // 
            this.removeToolStripMenuItem2.Name = "removeToolStripMenuItem2";
            this.removeToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem2.Text = "Remove";
            this.removeToolStripMenuItem2.Click += new System.EventHandler(this.removeToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 354);
            this.ContextMenuStrip = this.contextMenuForm;
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Earth Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuForm.ResumeLayout(false);
            this.contextMenuContinent.ResumeLayout(false);
            this.contextMenuCountry.ResumeLayout(false);
            this.contextMenuCity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuForm;
        private System.Windows.Forms.ToolStripMenuItem addContinentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuContinent;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuCountry;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findCityToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuCity;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem2;
    }
}

