using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematic mathematic = new Mathematic();
            int sonuc1 = mathematic.Add(2, 3);
            int sonuc2 = mathematic.Add(2, 6);
            int sonuc3 = mathematic.Add(sayi2: 65, sayi1: 10);

            int sonuc4 = mathematic.AddParams(new int[] { 2, 3, 4, 5, 6 });
            int sonuc5 = mathematic.AddParams(2, 3, 4, 5, 6, 7, 8);

        }
    }

    //Overloading on Mathematic Class, there are two different methos but they work at the same time
    class Mathematic
    {
        public int Add(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
         
        public int Add(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public int AddParams(params int[] sayilar)
        {
            int sonuc = 0;
            //foreach (var sayi in sayilar)
            //{
            //    sonuc = sonuc + sayi;
            //    sonuc += sayi;
            //}
            //return sonuc;

            return sayilar.Sum();
        }

        public int Minus(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
