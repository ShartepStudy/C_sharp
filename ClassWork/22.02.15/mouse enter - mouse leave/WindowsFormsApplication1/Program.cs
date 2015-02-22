using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace DotNetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.MouseLeave += new EventHandler(form_MouseLeave);
            form.MouseEnter += new EventHandler(form_MouseEnter);
            form.MouseMove += new MouseEventHandler(form_MouseMove);
            form.KeyDown += new KeyEventHandler(form_KeyDown);
            form.ShowDialog();
        }

        static void form_KeyDown(object sender, KeyEventArgs e)
        {
            Form tmp = sender as Form;
            tmp.Close();
        }

        static void form_MouseMove(object sender, MouseEventArgs e)
        {
            string str = String.Format("X: {0} Y: {1}", e.X, e.Y);
            Form tmp = sender as Form;
            Point p = tmp.PointToScreen(new Point(e.X, e.Y));
            str += String.Format(" - scrX: {0} scrY: {1}", p.X, p.Y);
            tmp.Text = str;
        }

        static void form_MouseEnter(object sender, EventArgs e)
        {
            Form tmp = sender as Form;
            tmp.BackColor = Color.BlueViolet;
        }

        static void form_MouseLeave(object sender, EventArgs e)
        {
            Form tmp = sender as Form;
            tmp.BackColor = Color.Peru;
        }
    }
}
