using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add();
            personManager.Update();

            CustomerManager customerManager = new CustomerManager();
            customerManager.GetBestCustomer();

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.GetBestEmployee();
        }
    }

    class PersonManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }
    }

    //PersonManager inheritance to CustomerManager
    class CustomerManager : PersonManager
    {
        public void GetBestCustomer()
        {
            Console.WriteLine("Best Customer is here");
        }
    }

    class EmployeeManager : PersonManager
    {
        public void GetBestEmployee()
        {
            Console.WriteLine("Best Employee is here");
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Employee : Person
    {
        public string EmployeeNumber { get; set; }
    }

    class Customer
    {
        public string CreditCardNumber { get; set; }
    }
}
