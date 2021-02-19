using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>() { "Ankara", "Istanbul", "Izmir" };
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Bursa");

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            sehirler.Add("Adana");
            sehirler.Remove("Istanbul");

            bool result = sehirler.Contains("Izmir");
            Console.WriteLine(result);

            Console.WriteLine("------------Second foreach going to show---------------");

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}
