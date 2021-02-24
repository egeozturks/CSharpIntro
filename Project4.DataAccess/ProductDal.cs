using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    // Dal = Data Access Layer
    public class ProductDal:IProductDal
    {
        //Ado.NET
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product> 
            {
                new Product{ProductID = 1, ProductName = "Acer Ado.NET Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 2},
                new Product{ProductID = 2, ProductName = "Asus Ado.NET Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 1},
                new Product{ProductID = 3, ProductName = "Hp Ado.NET Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 0},
                new Product{ProductID = 4, ProductName = "Mac Ado.NET Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 3},
                new Product{ProductID = 5, ProductName = "Dell Ado.NET Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 10}
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET ile Eklendi");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
