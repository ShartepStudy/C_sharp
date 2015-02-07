using System;
using System.Text.RegularExpressions;

namespace RegularEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "-23";
            string pattern = @"-?\d+(\.\d+)?"; // ?> greedy subexpression (жадный поиск)

            if (Regex.IsMatch(str, pattern)) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            ////////////////////////////////////////////////////////////////////////////////////

            Regex reg = new Regex(pattern);
            if (reg.IsMatch(str)) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            ////////////////////////////////////////////////////////////////////////////////////

            str = "abshdjsdf 23.45 kfghsdkfgh 34.6 sdgsdfg 4.516 ";
            MatchCollection matches = Regex.Matches(str, pattern);
            foreach (Match match in matches) Console.Write(match.Value + ", ");
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////

            string strReplace = Regex.Replace(str, pattern, "0");
            Console.WriteLine(strReplace);

            ////////////////////////////////////////////////////////////////////////////////////

            string[] strSplit = Regex.Split(str, pattern);
            foreach (string s in strSplit) Console.Write(s + "& "); // (жадный поиск!)
            Console.WriteLine();
        }
    }
}
