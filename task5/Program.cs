using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde sol terefden saydiqda { a},{ b},{ c}
            //  simollarindan hansi birinci gelir?
            string text = "Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?";
            char[] herf = { 'i', 'a', 'e' };
            int index=text.IndexOfAny(herf);
            Console.WriteLine($"{{'i','a','e'}} simvollarindan birinci gelen simvolun indeksi: {index+1}");
            Console.WriteLine($"{{'i','a','e'}} simvollarindan birinci gelen simvol: {text[index]}");

        }  
    }
}
