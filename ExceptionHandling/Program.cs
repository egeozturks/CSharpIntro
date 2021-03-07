using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Divide(20,0));
        }
    }

    class Matematik
    {
        public int Add(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public decimal Divide(int sayi1, int sayi2)
        {
            try
            {
                return sayi1 / sayi2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Catch worked, something went wrong");
                throw new DivideByZeroException("Denominator can not be null, payda sıfır olamaz, Attempted to divide by zero");
            }
            catch (DllNotFoundException)
            {
                Console.WriteLine("Catch worked, different something went wrong");
                throw new DllNotFoundException();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Catch worked, An unexpected error has occurred");
                Console.WriteLine(exception.InnerException);
                throw;
            }
            finally //whether the try or the catch, it will work at the end
            {
                Console.WriteLine("Finally works");
            }

        }
    }
}
