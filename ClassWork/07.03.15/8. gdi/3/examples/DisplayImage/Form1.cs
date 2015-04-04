using System.Drawing;
using System.Windows.Forms;

namespace DisplayImage
{
    public partial class Form1 : Form
    {
        private Image picture;
        private Point[] pictureBounds;

        public Form1()
        {
            InitializeComponent();

            // Загрузка изображения
            picture = Image.FromFile(@"Images\metrobits.jpg");

            // Параллелограмм в котором будет выведено изображение
            pictureBounds = new Point[3];
            pictureBounds[0] = new Point(50, 50);
            pictureBounds[1] = new Point(picture.Width, 150);
            pictureBounds[2] = new Point(picture.Width/3, picture.Height);

            // Отображение полос прокрутки формы, если изображение не вмещается
            this.AutoScrollMinSize = new Size(picture.Width*2, picture.Height*2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.ScaleTransform(1.0f, 1.0f);
            graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
            graphics.RotateTransform(-8);
            graphics.DrawImage(picture,pictureBounds);
        }
    }
}
