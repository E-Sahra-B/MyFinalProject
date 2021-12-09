using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //Ekleme();
            //CategoryTest();
           // Birlestirme();
            //UyariMesajlari();


        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal(),
        //        new CategoryManager(new EfCategoryDal()));
        //    foreach (var product in productManager.GetAll().List<Product>)
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}
        private static void Birlestirme()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),
                new CategoryManager(new EfCategoryDal()));

            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
        private static void UyariMesajlari()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),
                new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


        //static  void Ekleme()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    Product p = new Product{ CategoryId=2,ProductName="Deneme",UnitPrice=12000,UnitsInStock=12 };
        //    productManager.Add(p);

        //}
    }
}
