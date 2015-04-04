using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class MainForm :
        Form
    {
        public MainForm()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");

            InitializeComponent();
        }
    }
}