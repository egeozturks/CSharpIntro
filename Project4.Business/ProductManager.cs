using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                throw new DuplicateProductException("Laptop ekleyemezsiniz");
            }
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {

            //Business codes are write here for example if blocks

            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
