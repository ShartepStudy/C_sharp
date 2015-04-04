using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Controls
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button1;
        //===============================================
        // ����������, ������� ������������ ��� �������� � �����
        // ��������
        Pen pen;
        // �����
        Brush brush;
        Brush brushinside;
        //===============================================
        // ���������� ��� ����������� list-box ' a 
        // �� �������� ������� ��� ������ �������� owner - draw
        private System.Windows.Forms.ListBox listBox1;
        //===============================================
        // ������ �������� ��� ����-�����
        string[] ListData;
        // ������ ������ ��� ����-�����
        Color[] ListColor;
        // �������� ����
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // �������� ��������� � �����
            pen = new Pen(Color.Blue, 10);
            // � �������� ����� ����� ���������� �������  ���� ������ 
            // ����� �������� ����������
            brush = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            // ������� �����
            brushinside = new SolidBrush(Color.Red);
            // ���������� ������ �������� � ������ ��� ����-�����
            ListData = new string[4] { "����", "�����", "����", "�����" };
            ListColor = new Color[4] { Color.Blue, Color.Green, Color.Red, Color.Yellow };
            // ����������� ������ �������� � ����������� ����-�����
            listBox1.DataSource = ListData;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 120);
            this.button1.TabIndex = 0;
            this.button1.Text = "Circle";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Location = new System.Drawing.Point(376, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.OwnerDraw = true;
            this.menuItem2.Text = "Open";
            this.menuItem2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem2_DrawItem);
            this.menuItem2.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem2_MeasureItem);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.OwnerDraw = true;
            this.menuItem3.Text = "Save";
            this.menuItem3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem3_DrawItem);
            this.menuItem3.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem3_MeasureItem);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Save As";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "&Exit";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(664, 321);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Menu = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Controls";
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            Application.Run(new Form1());
        }
        // ������ ����� ��� �������� ������, ������� ����� ���������� ����������
        private void button1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // ������ �� ������ button1
            Button button = (Button)sender;
            Graphics gr = e.Graphics;
            // ����������� � ������������ ������
            gr.FillRectangle(brush, 0, 0, button.ClientSize.Width, button.ClientSize.Height);
            gr.FillEllipse(brushinside, 0, 0, button.ClientSize.Width, button.ClientSize.Height);
            gr.DrawEllipse(pen, 0, 0, button.ClientSize.Width, button.ClientSize.Height);
            // ������ ������ ����������
            GraphicsPath path = new GraphicsPath();
            // ��������� � ���� ������ � �������� ������, ������� ����� �������������� ��� ���������
            path.AddEllipse(0, 0, button.ClientSize.Width, button.ClientSize.Height);
            // ���������, ���������� ������ �� ���� ������
            button.Region = new Region(path);

            // �������� ������ � ��� ���������
            String text = "Round";

            Font font = new Font("Arial", 14);
            SolidBrush exbrush = new SolidBrush(Color.Black);


            RectangleF rect = new RectangleF(button.ClientSize.Width / 2 - 30, button.ClientSize.Height / 2 - 15, button.ClientSize.Width, button.ClientSize.Height);
            // ����������� ������� � ������
            gr.DrawString(text, font, exbrush, rect);


        }
        //���������� ������� �� ������	
        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Round Button Clicked", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ������ ���� ������,������ ��� ������ ����� �� ������ 
        private void button1_MouseEnter(object sender, System.EventArgs e)
        {
            pen = new Pen(Color.Red, 10);
            brushinside = new SolidBrush(Color.Yellow);
            // �������� ����� ����������� ����� ������
            button1.Invalidate();
        }
        // ������ ���� ������,������ ��� ������ ����� �� �������  ������ 

        private void button1_MouseLeave(object sender, System.EventArgs e)
        {
            pen = new Pen(Color.Blue, 10);
            brushinside = new SolidBrush(Color.Red);
            button1.Invalidate();
        }
        // �������, ��������������� ������ ��� �������� ������
        private void listBox1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            e.ItemHeight = 30;
        }
        // ������ ������� ������, �������� ������ ���������
        private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            SolidBrush solidbrush = new SolidBrush(ListColor[e.Index]);
            // �������� ������� ������
            Font newfont = new Font("Comic Sans MS", 14);
            e.Graphics.DrawString(ListData[e.Index], newfont, solidbrush, e.Bounds);
        }
        // ����� �� ���������
        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        // ��������� �������� ����. �� �������� ��������� ����� ownerdraw
        private void menuItem2_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            int delta = 10;
            // ��������� ������ �� ������� �������� ����� ����
            MenuItem item = (MenuItem)sender;

            // ������ ������ �� ��������� �����
            Font mFont = SystemInformation.MenuFont;


            SolidBrush mBrush;

            // ���� ������� ���������� ������ ��� �����
            if (item.Enabled == false)
            {

                mBrush = new SolidBrush(Color.Gray);
            }
            else
            {
                if ((e.State & DrawItemState.Selected) != 0)
                {
                    // ���� ������� �������� ��������� ������ ������ �����
                    // � ��������� �����
                    mBrush = new SolidBrush(Color.Red);
                    mFont = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    delta += 5;
                }
                else
                {
                    mBrush = new SolidBrush(Color.Blue);
                }
            }

            // ������ ������ ��� ��������������
            StringFormat stringfmt = new StringFormat();
            stringfmt.LineAlignment = System.Drawing.StringAlignment.Center;

            Rectangle rcText = e.Bounds;
            // ������ ������ ������������� ��� ���������� ��������
            if ((e.State & DrawItemState.Selected) != 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.SeaShell), e.Bounds);
            }
            // ����������� ������
            e.Graphics.DrawString(item.Text,
                mFont,
                mBrush,
                e.Bounds.Left + delta,
                e.Bounds.Top + ((e.Bounds.Height - mFont.Height) / 2 + delta / 2),
                stringfmt);

        }
        // ����� ����������� ������ ������ ����
        private void menuItem2_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            MenuItem item = (MenuItem)sender;

            Font mFont = SystemInformation.MenuFont;

            StringFormat stringfmt = new StringFormat();
            // ��������� ��������� ������ ��� ������ ����
            SizeF size =
                e.Graphics.MeasureString(item.Text,
                mFont,
                1000,
                stringfmt);

            e.ItemWidth = (int)Math.Ceiling(size.Width) + 10;

            e.ItemHeight = (int)Math.Ceiling(size.Height) + 10;

        }

        private void menuItem3_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            int delta = 10;
            MenuItem item = (MenuItem)sender;

            Font mFont = SystemInformation.MenuFont;


            SolidBrush mBrush;


            if (item.Enabled == false)
            {

                mBrush = new SolidBrush(Color.Gray);
            }
            else
            {
                if ((e.State & DrawItemState.Selected) != 0)
                {
                    mBrush = new SolidBrush(Color.Red);
                    mFont = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    delta += 5;
                }
                else
                {
                    mBrush = new SolidBrush(Color.Blue);
                }
            }


            StringFormat stringfmt = new StringFormat();
            stringfmt.LineAlignment = System.Drawing.StringAlignment.Center;

            Rectangle rcText = e.Bounds;

            if ((e.State & DrawItemState.Selected) != 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.SeaShell), e.Bounds);
            }

            e.Graphics.DrawString(item.Text,
                mFont,
                mBrush,
                e.Bounds.Left + delta,
                e.Bounds.Top + ((e.Bounds.Height - mFont.Height) / 2 + delta / 2),
                stringfmt);


        }

        private void menuItem3_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            MenuItem item = (MenuItem)sender;

            Font mFont = SystemInformation.MenuFont;

            StringFormat stringfmt = new StringFormat();

            SizeF size =
                e.Graphics.MeasureString(item.Text,
                mFont,
                1000,
                stringfmt);

            e.ItemWidth = (int)Math.Ceiling(size.Width) + 10;

            e.ItemHeight = (int)Math.Ceiling(size.Height) + 10;

        }


    }
}

