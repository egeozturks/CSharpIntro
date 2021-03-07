﻿using Project4.Business;
using Project4.DataAccess;
using System;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new ProductDal());
            //ProductManager productManager = new ProductManager(new EfProductDal());
            ProductManager productManager = new ProductManager(new XProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            try
            {
                productManager.Add(new Entities.Product { ProductID = 10, ProductName = "Laptop", QuantityPerUnit = "4 Ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });
            }
            catch (DuplicateProductException exception)
            {

                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
