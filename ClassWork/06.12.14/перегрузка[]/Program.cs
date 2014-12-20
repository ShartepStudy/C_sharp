using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace DotNetConsoleApp
{
    class MyArray
    {
        int[] arr = null;

        public MyArray()
        {
            arr = new int[] { 1, 2, 3, 4 };
        }

        public int Length
        {
            get { return arr.Length; }
        }
        public int this[int i]
        {
            get
            {
                if (i >= arr.Length)
                    throw new Exception("Sorry");
                return arr[i];
            }
            set
            {
                if (i >= arr.Length)
                    throw new Exception("Sorry");
                arr[i] = value;
            }
        }
        public int this[string i]
        {
            get
            {
                int index = Convert.ToInt32(i);
                return arr[index];
            }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            MyArray a = new MyArray();
            Console.WriteLine(a["0"]);
        }
    }


}
