//using DependencyInversion.Before;
using DependencyInversion.After.DependencyInversion.After;
using System;
namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Product product = new Product
            {
                Name = "SmartTv",
                Price = 499.99
            };

            //
            DeliveryDriver deliveryDriver = new DeliveryDriver();

            //
            DeliveryCompany<Product> deliveryCompany = new DeliveryCompany<Product>(deliveryDriver);

            // 
            deliveryCompany.SendProduct(product);

            Console.ReadLine(); 








            //--------------------------------------------------------

            // Create a sample product
            //Product product = new Product
            //{
            //    Name = "Smartphone",
            //    Price = 499.99
            //};

            //Product product = new Product
            //{
            //    Name = "Smartphone",
            //    Price = 499.99
            //};






            // Create a delivery company
            //DeliveryCompany deliveryCompany = new DeliveryCompany();

            // Send the product
            //deliveryCompany.SendProduct(product);

            Console.ReadLine(); // Keep the console window open
        }
    }
}
