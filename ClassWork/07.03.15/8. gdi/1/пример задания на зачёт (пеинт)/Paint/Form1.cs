using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
//
namespace Paint
{
    #region Class
    public partial class Form1 : Form
    {
        string radio = "pen";
        Color penColor = Color.Black;
        Pen pen;
        bool drawFlag = false, flagTrans = false, drawRect = true, flagSave = false;
        Point lastP, firstP;
        List<Point> pts = new List<Point>();
        List<Point> ptsRul = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 100;
            Image img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(img))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = img;

            Image img1 = new Bitmap(pictureBoxExample.Width, pictureBoxExample.Height);
            using (Graphics g = Graphics.FromImage(img1))
            {
                g.Clear(Color.White);
            }
            pictureBoxExample.Image = img1;

            comboBox1.SelectedIndex = 0;
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
    #endregion
        #region Open
        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = openFileDialog1.FileName;
                try
                {
                    Image im = new Bitmap(s);
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = im;
                    pictureBox1.Visible = true;
                    flagSave = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Text = "Image Editor - " + s;
                saveFileDialog1.FileName = s;
                openFileDialog1.FileName = "";
            }
        }
        #endregion
        #region Save
        private void Save_Click(object sender, EventArgs e)
        {
            if (flagSave == false)
            {
                MessageBox.Show("No image");
                return;
            }
            string s0 = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                if (s.ToUpper() == s0.ToUpper())
                {
                    s0 = Path.GetDirectoryName(s0) + "\\($$##$$)";
                    pictureBox1.Image.Save(s0);
                    pictureBox1.Image.Dispose();
                    File.Delete(s);
                    File.Move(s0, s);
                    pictureBox1.Image = new Bitmap(s);
                }
                else
                    if (pictureBox1.Image != null)
                    {
                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                pictureBox1.Image.Save(s, ImageFormat.Bmp);
                                break;
                            case 2:
                                pictureBox1.Image.Save(s, ImageFormat.Jpeg);
                                break;
                            case 3:
                                pictureBox1.Image.Save(s, ImageFormat.Png);
                                break;
                            case 4:
                                pictureBox1.Image.Save(s, ImageFormat.Gif);
                                break;
                        }
                    }
                Text = "Image Editor - " + s;
            }
        }
        #endregion
        #region New
        private void New_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Image im = new Bitmap(frm.Width, frm.Height);
                Graphics g = Graphics.FromImage(im);
                g.Clear(Color.White);
                g.Dispose();
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                pictureBox1.Image = im;
                pictureBox1.Visible = true;
                flagSave = true;
            }
            else
                return;
        }
        #endregion
        #region Clear
        private void Clear_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
                pictureBox1.Refresh();
            }
        }
        #endregion
        #region Combobox
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            pen = new Pen(penColor, 5.0f);
            using (Pen p = new Pen(e.ForeColor, 2))
            {
                p.DashStyle = (DashStyle)e.Index;
                int y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
                e.Graphics.DrawLine(p, e.Bounds.Left, y, e.Bounds.Right, y);
                pen.DashStyle = p.DashStyle;
            }
            e.DrawFocusRectangle();
            Graphics g = Graphics.FromImage(pictureBoxExample.Image);
            if (drawRect)

                g.DrawRectangle(pen, 0, 0, pictureBoxExample.Width - 3, pictureBoxExample.Height - 3);
            else
                g.DrawEllipse(pen, 0, 0, pictureBoxExample.Width - 3, pictureBoxExample.Height - 3);
            pictureBoxExample.Invalidate();
            pen.Dispose();
            g.Dispose();
        }
        #endregion
        #region Picturebox Front
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFront.BackColor = colorDialog1.Color;
                penColor = colorDialog1.Color;
                comboBox1.ForeColor = colorDialog1.Color;
                example.ForeColor = colorDialog1.Color;
            }
        }
        #endregion
        #region Picturebox Back
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBack.BackColor = colorDialog1.Color;
                pictureBoxExample.BackColor = colorDialog1.Color;
            }
        }
        #endregion
        #region MuoseDown
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                drawFlag = true;
                lastP = new Point(e.X, e.Y);
                firstP = new Point(e.X, e.Y);
                this.Text = firstP.X + " " + firstP.Y;

                pts.Add(lastP);
                ptsRul.Add(lastP);
                if (radio == "text")
                {
                    using (Graphics g = Graphics.FromHwnd(pictureBox1.Handle))
                    {
                        g.DrawString(example.Text, fontDialog1.Font, new SolidBrush(pictureBoxFront.BackColor), new Point(e.X, e.Y));
                    }
                }
            }
        }
        #endregion
        #region MouseUp
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawFlag = false;
            if (radio == "pen")
            {
                using (pen = new Pen(pictureBoxFront.BackColor, (int)numericUpDown1.Value))
                {
                    pen.DashStyle = (DashStyle)comboBox1.SelectedIndex;
                    pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        for (int i = 0; i < pts.Count - 1; i++)
                        {
                            g.DrawLine(pen, pts[i], pts[i + 1]);
                        }
                    }
                }
                ptsRul.Clear();
                pts.Clear();
            }
            else if (radio == "ruler")
            {
                using (pen = new Pen(pictureBoxFront.BackColor, (int)numericUpDown1.Value))
                {
                    pen.DashStyle = (DashStyle)comboBox1.SelectedIndex;
                    pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.DrawLine(pen, firstP, lastP);
                    }
                }
                ptsRul.Clear();
                pts.Clear();
            }
            else if (radio == "figure")
            {
                lastP = new Point(e.X, e.Y);
                if(lastP.X < firstP.X)
                {
                    int t = lastP.X;
                    lastP.X = firstP.X;
                    firstP.X = t;
                }
                if (lastP.Y < firstP.Y)
                {
                    int t = lastP.Y;
                    lastP.Y = firstP.Y;
                    firstP.Y = t;
                }
                int w = lastP.X - firstP.X;
                if(w  < 0) w *= -1;
                int h = lastP.Y - firstP.Y;
                if (h < 0) h *= -1;
                this.Text = lastP.X + " " + lastP.Y;
                using (SolidBrush b = new SolidBrush(pictureBoxBack.BackColor))
                {
                    using (pen = new Pen(pictureBoxFront.BackColor, (int)numericUpDown1.Value))
                    {
                        using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                        {
                            if (drawRect)
                            {
                                if (!flagTrans)
                                {
                                    g.FillRectangle(b, new Rectangle(firstP, new Size(w, h)));
                                }
                                g.DrawRectangle(pen, new Rectangle(firstP, new Size(lastP.X - firstP.X, lastP.Y - firstP.Y)));
                            }
                            else
                                if (!flagTrans)
                                {
                                    g.FillEllipse(b, new Rectangle(firstP, new Size(w, h)));
                                }
                            g.DrawEllipse(pen, new Rectangle(firstP, new Size(lastP.X - firstP.X, lastP.Y - firstP.Y)));
                        }
                    }
                }
            }
            pictureBox1.Refresh();
        }
        #endregion
        #region MouseMove
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawFlag)
            {
                if (radio == "pen")
                {
                    using (pen = new Pen(pictureBoxFront.BackColor, (int)numericUpDown1.Value))
                    {
                        pen.DashStyle = (DashStyle)comboBox1.SelectedIndex;
                        pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

                        using (Graphics g = Graphics.FromHwnd(pictureBox1.Handle))
                        {
                            g.DrawLine(pen, lastP, new Point(e.X, e.Y));
                        }
                    }
                    lastP = new Point(e.X, e.Y);
                    pts.Add(lastP);
                }
                else if (radio == "ruler")
                {
                    pictureBox1.Refresh();
                    using (pen = new Pen(pictureBoxFront.BackColor, (int)numericUpDown1.Value))
                    {
                        pen.DashStyle = (DashStyle)comboBox1.SelectedIndex;
                        pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

                        using (Graphics g = Graphics.FromHwnd(pictureBox1.Handle))
                        {
                            g.DrawLine(pen, firstP, new Point(e.X, e.Y));
                        }
                    }
                    lastP = new Point(e.X, e.Y);
                    ptsRul.Add(lastP);
                }
            }
            xy.Text = "X, Y : " + e.X + ", " + e.Y;
        }
        #endregion
        #region Font
        private void Font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            example.Font = fontDialog1.Font;
        }
        #endregion
        #region Transparent
        private void trans_CheckedChanged(object sender, EventArgs e)
        {
            if (flagTrans == false)
                pictureBoxExample.BackColor = Color.Transparent;
            else
                pictureBoxExample.BackColor = pictureBoxBack.BackColor;
            flagTrans = !flagTrans;
        }
        #endregion
        #region Radiobuttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbutton = new RadioButton();
            rbutton = (RadioButton)sender;
            switch (rbutton.Name)
            {
                case "radioButton1":
                    radio = "pen";
                    break;
                case "radioButton2":
                    radio = "ruler";
                    break;
                case "radioButton3":
                    radio = "figure";
                    break;
                case "radioButton4":
                    radio = "text";
                    break;
            }
        }
        #endregion
        #region PictureBox Example
        private void pictureBoxExample_Click(object sender, EventArgs e)
        {
            drawRect = !drawRect;
            Graphics g = Graphics.FromImage(pictureBoxExample.Image);
            pen = new Pen(pictureBoxFront.BackColor, 3);
            g.Clear(Color.White);
            if (flagTrans == false)
                pictureBoxExample.BackColor = pictureBoxBack.BackColor;
            else
                pictureBoxExample.BackColor = Color.Transparent;
            if (drawRect == true)
                g.DrawRectangle(pen, 0, 0, pictureBoxExample.Width - 3, pictureBoxExample.Height - 3);
            else
                g.DrawEllipse(pen, 0, 0, pictureBoxExample.Width - 3, pictureBoxExample.Height - 3);
            pictureBoxExample.Refresh();
            g.Dispose();
            pen.Dispose();
        }
        #endregion
    }
}