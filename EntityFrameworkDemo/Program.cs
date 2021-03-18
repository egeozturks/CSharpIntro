using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET - Veritabanını bağlar, kontrol eder, veritabanına sorgu yazmayı sağlayan bir kütüphane - bununla çalışmak yorucu
            //Entity Framework -- ORM, Object Relational Mapping
            //NHibernate
            //Dapper, ADO.NET ' in kolaylastirilmis kutuphanesi

            //GetAll();
            //GetProductsByCategory(1);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryID == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
