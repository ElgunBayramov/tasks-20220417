using System;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et. 
            string text = "Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.";
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    text = text.Insert(i, text[i].ToString().ToUpper());
                }
            }
            Console.WriteLine(text);
        }
    }
}
