using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal __productDal;

        public ProductManager(IProductDal productDal)
        {
            __productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            return __productDal.GetAll();
        }
    }
}
