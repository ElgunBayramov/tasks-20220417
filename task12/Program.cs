using System;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metinde en ilk ve en son { a}
            //simvolundan bashqa yerde qalan butun { a}
            //simvollarini yox et.
            string text = "Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et.";
            char a='i';
            int first=text.IndexOf('a');
            int last=text.LastIndexOf('a');
            string s=string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i]==a && i!=last && i != first){
                    continue;
            }
                s += text[i];
            }
            Console.WriteLine(s);
            
        }
    }
}
