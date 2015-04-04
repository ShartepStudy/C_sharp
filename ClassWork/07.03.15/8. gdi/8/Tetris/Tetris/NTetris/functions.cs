using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace NTetris
{
    class functions
    {
        //проверка нажатия стрелок
        public static bool isButtons(KeyEventArgs e)
        {
            bool returned = false;
            switch(e.KeyCode)
            {
                case Keys.Up:
                    returned = true;
                    break;

                case Keys.Down:
                    returned = true;
                    break;

                case Keys.Left:
                    returned = true;
                    break;

                case Keys.Right:
                    returned = true;
                    break;
            }
            return returned;
        }

      
    }
}
