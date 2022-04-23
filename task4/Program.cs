using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde sol terefden ilk rast gelinen { a}
            //simvolunun yeri tek ededdi yoxsa cut ?
            string text = "Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut?";
            text=text.ToLower();
            int a = text.IndexOf('i');
            char letter = 'i';
            
            if (a % 2 == 0)
            {
                Console.WriteLine($"{letter} simvolunun yeri: {a + 1}");
                Console.WriteLine($"ilk {letter} simvolunun yeri tekdir");
            }
            else
            {
                Console.WriteLine($"{letter} simvolunun yeri: {a + 1}");
                Console.WriteLine($"ilk {letter} simvolunun yeri cutdur");
            }
        }
    }
}
