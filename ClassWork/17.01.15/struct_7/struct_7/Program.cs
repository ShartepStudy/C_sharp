using System;

class Program
{
    static void Main(string[] args)
    {

        // выделение памяти происходит при объявлении переменной структуры.
        // операция new по отношению к структурам не выделяет память, а лишь инициализует поля.

        Rect r = new Rect(10, 12);
        r.Show();

        Mash(ref r, 2.57);
        r.Show();
    }

    static void Mash(ref Rect figure, double koef)
    {
        figure.Width *= koef;
        figure.Height *= koef;
    }

    struct Rect
    {
        double width;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value >= 0) width = value;
                else width = 0;
            }
        }

        double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0) height = value;
                else height = 0;
            }
        }

        public Rect(uint width = 5, uint height = 5)
        {
            this.width = width;
            this.height = height;
        }
        public void Show()
        {
            Console.WriteLine(width + "\t" + height + "\t" + Diagonal);
        }
        public double Diagonal
        {
            get
            {
                return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            }
        }
    }
}