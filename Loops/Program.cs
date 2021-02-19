using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] krediler = new string[7];
            krediler[0] = "Kredi 1";
            krediler[1] = "Kredi 2";
            krediler[2] = "Kredi 3";
            krediler[3] = "Kredi 4";
            krediler[4] = "Kredi 5";
            krediler[5] = "Kredi 6";
            krediler[6] = "Kredi 7";

            string[] krediler2 = new string[]
            {
                "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6", "Kredi 7"
            };

            // i = index, i = 0 (start from 0), i < length (until to end), i++ (counting)
            //for (int i = 0; i < length; i++) { } 
            //for (int i = 0; i < krediler.Length; i++)
            //for (int i = 0; 7 < krediler.Length; i++)

            for (int i = 0; i < krediler.Length; i++)
            {
                Console.WriteLine(krediler[i]);
            }


            Console.WriteLine("The loop of the 'for' ended");


            // "kredi" has been alias. Alias means nickname
            foreach (string kredi in krediler)
            {
                Console.WriteLine(kredi);
            }
            Console.WriteLine("for each loop the end");



            //infinite loop

            //while (true)
            //{
            //    Console.WriteLine("Engin");
            //}

            int sayac = 0;
            while (sayac < 7)
            {
                Console.WriteLine(krediler[sayac]);
                sayac++;
            }
            Console.WriteLine("while loop the ended");


            //do - while loop, bir kere calistir, sart gecerliyse devam ettir
            int sayac2 = 0;
            do
            {
                Console.WriteLine(krediler[sayac2]);
                sayac2++;
            } while (sayac2 < 7);
            Console.WriteLine("do-while loop the ended");
        }
    }
}
