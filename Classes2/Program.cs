using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance - ornek, ProductManager'dan productManager örnegi olustu
            ProductManager productManager = new ProductManager();



            Product product1 = new Product() { ProductName = "Laptop", UnitInPrice = 500, UnitsInStock = 5 };
            //product1.ProductName = "Laptop";
            //product1.UnitInPrice = 5000;
            //product1.UnitsInStock = 5;

            Product product2 = new Product() { ProductName = "Mouse", UnitInPrice = 1000, UnitsInStock = 6 };
            //product2.ProductName = "Mouse";
            //product2.UnitInPrice = 1000;
            //product2.UnitsInStock = 6;

            productManager.Add(product1);
            productManager.Add(product2);

        }
    }
}
