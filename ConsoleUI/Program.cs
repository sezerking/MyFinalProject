using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {


            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDeatils();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName+" / "+product.CategoryName);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            //ProductManager productManager = new ProductManager(new EfProductDal());
            //Console.WriteLine(productManager.GetById(15).ProductName); 
            //ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDeatils().Data)
            {
                Console.WriteLine(product.ProductName + " ----- " + product.CategoryName);
            }
        }
    }
}
