﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=5},
                new Product{ProductId=1, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3},
                new Product{ProductId=1, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitsInStock=2},
                new Product{ProductId=1, CategoryId=1, ProductName="Samsung Laptop", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15},
                new Product{ProductId=1, CategoryId=1, ProductName="Apple Laptop", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0}
            };

            //Test(products);

            //GetProducts(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            //ClassicLinqBasicTest(products);

            //ClassicLinqTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000 && p.UnitsInStock > 3
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000 && p.UnitsInStock > 2
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ClassicLinqBasicTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000 && p.UnitsInStock > 2
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void NewMethod(List<Product> products)
        {
            //Single line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            //lambda
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik---------------");
            foreach (var p in products)
            {
                if (p.UnitPrice > 5000 && p.UnitsInStock > 3)
                {
                    Console.WriteLine(p.ProductName);
                }
            }

            Console.WriteLine("Linq-----------------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }



        //Writes without Linq
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        //Writes with Linq
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
    }

    class ProductDto //Data Transformation Object
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}
