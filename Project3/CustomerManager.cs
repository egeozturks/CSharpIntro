using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class CustomerManager
    {
        List<Customer> customers;
        //constructor - the following class was created with the "ctor"
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1, FirstName="Engin", LastName="Demirog", City="Ankara", Email="engin@"},
                new Customer{Id=2, FirstName="Derin", LastName="Demirog", City="Ankara", Email="derin@"},
                new Customer{Id=3, FirstName="Salih", LastName="Demirog", City="Ankara", Email="salih@"},
                new Customer{Id=4, FirstName="Ahmet", LastName="Demirog", City="Istanbul", Email="ahmet@"},
                new Customer{Id=5, FirstName="Mehmet", LastName="Demirog", City="Izmir", Email="mehmet@"},
            };
        }

        public List<Customer> GetAll()
        {
            //Connect to database



            return customers;

        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
