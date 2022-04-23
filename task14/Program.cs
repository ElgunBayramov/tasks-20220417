using System;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et. 
            string text = "Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et.";
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    text = text.Insert(i + 1, text[i + 1].ToString().ToUpper());
                    text = text.Remove(i, 1);
                }
            }
            Console.WriteLine(text);
        }
    }
}
