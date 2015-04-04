using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            /*
            public void Intersect( - остается пересечение регионов.
                           Region region
                        );
            */
            Region rgn = new Region(new Rectangle(0, 0, 100, 100));
            Region rgn2 = new Region(new Rectangle(80, 80, 180, 180));
            rgn2.Intersect(rgn);
            this.Region = rgn2;
            this.BackColor = Color.Red;
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



    }
}