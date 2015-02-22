using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runButtonRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((button1.Left + button1.Width + 15) >= e.X && (e.X > (button1.Left + button1.Width))&&(e.Y >= button1.Top && e.Y <= button1.Top+button1.Height))
            {
                button1.Left--;
            }else if ((button1.Left - 15) <= e.X && (e.X < (button1.Left)) &&
                      (e.Y >= button1.Top && e.Y <= button1.Top + button1.Height))
            {
                button1.Left++;
            }else if ((button1.Top-15)<=e.Y && (e.Y<button1.Top)&&(e.X>=button1.Left && e.X<=button1.Left + button1.Width))
            {
                button1.Top++;
            }
            else if ((button1.Top + button1.Height + 15) >= e.Y && (e.Y > button1.Top + button1.Height) && (e.X >= button1.Left && e.X <= button1.Left + button1.Width))
            {
                button1.Top--;
            }
            
            //button1.Left = r.Next(0, this.Size.Width - button1.Width);
            //button1.Top = r.Next(0, this.Size.Height - button1.Height);
        }
    }
}
