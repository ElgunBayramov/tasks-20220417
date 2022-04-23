using System;
using System.Text.RegularExpressions;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metinde butun reqemleri legv et. 
            string text = "56Verilmish434 metinde2345 butun5680 reqemleri992 legv5 7et.74540";
            string strPattern = @"\d+";
            Console.WriteLine(text);
            text = Regex.Replace(text, strPattern, "");
            Console.WriteLine(text);
        }
    }
}
