﻿using Business.Concrete;
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
            // ProductTest();

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.WriteLine();

            Category categorySingle = categoryManager.GetById(3);

            Console.WriteLine(categorySingle.CategoryName); 

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);

            }

            Console.WriteLine();

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);

            }

            Console.WriteLine();

            foreach (var product in productManager.GetAllByUnitPrice(20, 100))
            {
                Console.WriteLine(product.UnitPrice);

            }
        }




    }

}