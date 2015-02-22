using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConfirmChoice
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Parent());
        }
    }
}
