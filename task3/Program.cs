using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}
            //-ye beraberdir.
            string text = "Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b}-ye beraberdir";
            char a = 'e';
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if(text[i] == a)
                    {
                        count++;
                        Console.Write($"{i}-ci simvol: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{a}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{i}-ci simvol: ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"{a}-ya beraber deyil");
                        Console.ResetColor();
                    }
                }
            }
            Console.Write("yekun: ");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"{count} denesi {a}-ye beraberdir");
            Console.ResetColor();
        }
    }
}
