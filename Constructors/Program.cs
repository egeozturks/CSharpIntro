using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demirog", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ege";
            customer3.LastName = "Ozturk";
            customer3.City = "Bursa";

            // customer1 and customer3 writed by same constructor 'default constructor' so both are same but customer2 writed second constructor


            Customer customer2 = new Customer(2, "Engin", "Demirog", "Ankara");
        }
    }

    class Customer
    {
        //constructors work like methods
        //Default constructor - ctor
        //2 ctor work by overloading
        public Customer()
        {
            Console.WriteLine("Default constuctor works in here");
        }

        //second constructor
        //methods parameter write by camelCase
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("The second constructor works in here");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
