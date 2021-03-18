using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        //EntityFramework
        List<Product> _products;
        public EfProductDal()
        {
            //_products = new List<Product>
            //{
            //    new Product{ProductID = 1, ProductName = "Acer ef Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 2},
            //    new Product{ProductID = 2, ProductName = "Asus ef Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 1},
            //    new Product{ProductID = 3, ProductName = "Hp ef Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 0},
            //    new Product{ProductID = 4, ProductName = "Mac ef Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 3},
            //    new Product{ProductID = 5, ProductName = "Dell ef Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 10}
            //};
        }
        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p=>p.ProductID==product.ProductID));
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
                //dispose
                
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p=>p.ProductID == id);
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductID == product.ProductID);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;

                context.SaveChanges();
            }
        }
    }
}
