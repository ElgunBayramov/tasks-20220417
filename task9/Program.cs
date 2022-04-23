using System;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
            string text = "Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?";
            string sub1 = text.Substring(0, 3);
            string sub2 = text.Substring(text.Length - 3, 3);
            char[] herfler = sub2.ToCharArray();
            Array.Reverse(herfler);
            string revsub2 = string.Join("", herfler);
            if (revsub2 == sub1)
            {
                Console.WriteLine("eynidir");
            }
            else
            {
                Console.WriteLine("eyni deyil");
            }
        }
    }
}
