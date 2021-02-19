using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 30;
            int sayi2 = 35;

            string durum = (sayi1 > sayi2) ? "Sayı 1, sayı 2'den büyüktür" : "Sayı 2, sayı 1'den büyüktür";

            Console.WriteLine(durum);
        }
    }
}
