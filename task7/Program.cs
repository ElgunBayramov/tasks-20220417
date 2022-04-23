using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde { a}
            //simvolu { b}
            //simvolundan qabaq ve oda { c}
            //simvolundan qabaq gelirmi ?
            string text = "Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?";
            int index1=text.IndexOf('e');
            int index2=text.IndexOf('i');
            int index3 =text.IndexOf('a');
            if(index1<index2 && index2 < index3)
            {
                Console.WriteLine($"{text[index1]} simvolu {text[index2]} simvolundan, oda {text[index3]} simvolundan qabaq gelir");
            }
            else
            {
                Console.WriteLine($"{text[index1]} simvolu {text[index2]} simvolundan, oda {text[index3]} simvolundan qabaq gelmir");
            }


        }
    }
}
