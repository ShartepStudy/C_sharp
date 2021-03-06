﻿
using System;
using System.Collections;

namespace LaptopShop2
{

    public class Laptop
    {
        private string vendor;
        private double price;

        public string Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Laptop(string v, double p)
        {
            vendor = v;
            price = p;
        }

        public override string ToString()
        {
            return vendor + " " + price.ToString();
        }
    }

    public class Shop : IEnumerable // для работы foreach
    {
        private Laptop[] LaptopArr;

        public Shop(int size)
        {
            LaptopArr = new Laptop[size];
        }

        public int Length
        {
            get { return LaptopArr.Length; }
        }

        public Laptop this[int pos] // одномерный индексатор
        {
            get
            {
                if (pos >= LaptopArr.Length || pos < 0)
                    throw new IndexOutOfRangeException();
                else
                    return (Laptop)LaptopArr[pos];
            }
            set
            {
                LaptopArr[pos] = (Laptop)value;
            }
        }

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return LaptopArr.GetEnumerator();
        }

        #endregion
    }
    public class Tester
    {
        public static void Main()
        {
            Shop sh = new Shop(3);
            sh[0] = new Laptop("Samsung", 5200);
            sh[1] = new Laptop("Asus", 4700);
            sh[2] = new Laptop("LG", 4300);

            try
            {
                foreach (Laptop LT in sh)
                    Console.WriteLine(LT.ToString());

            }
            catch (System.NullReferenceException)
            {

            }
            Console.WriteLine();
        }
    }
}