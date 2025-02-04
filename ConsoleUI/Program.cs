﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);

            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var resul = productManager.GetProductDetails();
            if (resul.Success == true) {
                foreach (var item in resul.Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);

                } 
            }
            else
            {
                Console.WriteLine(resul.Message);
            }
        }
    }
}
