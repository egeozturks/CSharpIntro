using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // If you want to create an array on wrong way
            //string kredi1 = "Hızlı kredi";
            //string kredi2 = "Maaşını Halkbank'tan alanlara özel";

            //Console.WriteLine(kredi1);
            //Console.WriteLine(kredi2);


            // Create an array to right way

            string[] krediler = new string[7];
            krediler[0] = "Kredi 1";
            krediler[1] = "Kredi 2";
            krediler[2] = "Kredi 3";
            krediler[3] = "Kredi 4";
            krediler[4] = "Kredi 5";
            krediler[5] = "Kredi 6";
            krediler[6] = "Kredi 7";

            Console.WriteLine(krediler[0]);

            ///////////////////////////////
            ///


            int[] numbers = new int[4];
            numbers[0] = 7;
            numbers[1] = 5;
            numbers[2] = 10;
            numbers[3] = 44;

            //Sorted Array, if you want to arrange on an array, to sort small to big
            Array.Sort(numbers);

            Console.WriteLine("En küçük : " + numbers[0]);
            Console.WriteLine("Ortanca Sayılar : " + numbers[1] + " ve " + numbers[2]);
            Console.WriteLine("En büyük : " + numbers[3]);

            string[] products = new string[] { "Elma", "Armut", "Mandalina", "Karpuz" };

            foreach (var fruits in products)
            {
                Console.WriteLine(fruits);
            }

        }
    }
}
