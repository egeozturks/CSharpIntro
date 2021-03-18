using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class XProductDal : IProductDal
    {
        List<Product> _products;
        public XProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductID = 1, ProductName = "Acer x Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 2},
                new Product{ProductID = 2, ProductName = "Asus x Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 1},
                new Product{ProductID = 3, ProductName = "Hp x Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 0},
                new Product{ProductID = 4, ProductName = "Mac x Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 3},
                new Product{ProductID = 5, ProductName = "Dell x Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 10}
            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("X ile eklendi");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
