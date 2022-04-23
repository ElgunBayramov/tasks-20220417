using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde { a}
            //simvolun sayi { b}
            //simvolun sayinda nece defe coxdur?
            string text = "Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?";
            char a = 'i';
            char b = 'o';
            double counta = 0;
            double countb = 0;
            double x;
            foreach (var item in text)
            {
                if (item == a)
                {
                    counta++;
                }
            }
            Console.WriteLine($"{a} simvolunun sayi: {counta}");
            foreach (var item in text)
            {
                if (item == b)
                {
                    countb++;
                }
            }
            Console.WriteLine($"{b} simvolunun sayi: {countb}");
            x = counta / countb;
            Console.WriteLine($"{counta}/{countb}={x}");
        }
    }
}
