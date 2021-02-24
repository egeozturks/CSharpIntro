using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
