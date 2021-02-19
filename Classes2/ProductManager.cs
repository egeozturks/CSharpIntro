using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    class ProductManager
    {
        //methods
        //reusability
        public void Add(Product product)
        {
            Console.WriteLine("Product Added : " + product.ProductName + " / " + "Price : " + product.UnitInPrice);
        }
    }
}
