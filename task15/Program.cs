using System;

namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmish metinde ilk ve son simvol eynidirse, 
            //ve metn daxilinde yanashi gelen { a}
            // simvolu varsa,
            //ve metn daxilinde { b}
            //  simvolu yoxdursa
            //o zaman bu metnde butun { c}
            //  simvollari yox et ve
            //neticede alinan metn zerkalni olub olmadigini yoxla.
            string text = "salcccaclas";
            string first = text.Substring(0, 1);
            char a = 'a';
            char b = 'b';
            int indexc = text.IndexOf('c');
            string last = text.Substring(text.Length - 1);
            string empty = "";
            string text1 = "";
            bool state = false;
            if (first == last)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == a && text[i + 1] == a)
                    {

                    }
                    if (text[i] == b)
                    {
                        state = true;

                    }

                }
                    if (state == false)
                    {
                    Console.WriteLine(text);
                    text = text.Replace("c", string.Empty);
                    Console.WriteLine(text);
                    for (int j = text1.Length - 1; j >= 0; j--)
                    {
                        empty = empty + text[j];
                    }

                    if (text1 == empty)
                    {
                        Console.WriteLine("Zerkalni");
                    }
                    else
                    {
                        Console.WriteLine("Zerkalni deyil");
                    }
                }
                }
            }
        }
    }

