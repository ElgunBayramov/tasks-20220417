using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde { a}
            //simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            string text = " Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?";
            int herf1=text.LastIndexOf('r');
            int herf2=text.IndexOf('r');
            int x = (herf1 + 1) + (herf2 + 1);
            if (x == text.Length + 1)
            {
                Console.WriteLine($"{'r'} simvolunun sol ve sag terefden indeksleri eynidir");
            }
            else
            {
                Console.WriteLine($"{'r'} simvolunun sol ve sag terefden indeksleri eyni deyil");
            }
          
        }
    }
}
