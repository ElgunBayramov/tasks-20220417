using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde ilk qabagima cixan {a}
            //simvolundan sonra gelen simvolu 10 defe dalbadal cap et.
            string text = "Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.";
            int indexa = text.IndexOf('a');
            for (int i = 0; i < 9; i++)
            {
                text = text.Insert(indexa+1, text[indexa+1].ToString());
            }
            Console.WriteLine(text);
        }
    }
}
