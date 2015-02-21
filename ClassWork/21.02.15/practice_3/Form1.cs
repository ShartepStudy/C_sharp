using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_3
{
    public partial class Form1 : Form
    {
        private int mWidth = 5;
        private int mHeight = 3;
        private int mBorder = 10;
        private int mSize = 100;

        private Button[][] buttons;

        public Form1()
        {
            InitializeComponent();

            buttons = new Button[mWidth][];
            int count = 1;
            for (int x = 0; x < mWidth; x++)
            {
                buttons[x] = new Button[mHeight];
                for (int y = 0; y < mHeight; y++)
                {
                    Button b = new Button();
                    b.Size = new Size(mSize, mSize);
                    b.Left = x * (mSize + mBorder) + mBorder;
                    b.Top = y * (mSize + mBorder) + mBorder;
                    b.Parent = this;
                    b.Text = (count++).ToString();
                    b.BackColor = Color.FromArgb(count * b.Left % 255, count * b.Top % 255, count);
                    b.Click += new EventHandler(delegate(object o, EventArgs e) { ((Button)o).Hide(); });
                    buttons[x][y] = b;
                }
            }

            //Size = new Size(mWidth * (mSize + mBorder) + mBorder, mHeight * (mSize + mBorder) + mBorder);
        }

    }
}
