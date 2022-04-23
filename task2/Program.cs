using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi { a}
            //simvoludurmu ?
            string text = "Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu ?";
            char a = 'i';
            int counta = 0;
            int countb = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    counta++;
                
                if (text[i] == a)
                {
                    countb++;
                }
            }
        }
            if (counta == countb)
            {
                Console.WriteLine($"tek yerde dayanan simvollarin hamisi {a} simvoludur");
            }
            else
            {
                Console.WriteLine($"tek yerde dayanan simvollarin hamisi {a} deyil");
            }

        }
    }
}