using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Before
{
    internal class GestionDelivery
    {
    }


    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }

    }

    public class DeliveryDriver
    {
        public void DeliverProduct(Product product)
        {
            Console.WriteLine($"Delivering {product.Name}...");
            Console.WriteLine($"Successfully delivered {product.Name}!");
        }
    }

    public class DeliveryCompany
    {
        public void SendProduct(Product product)
        {
            DeliveryDriver deliveryDriver = new DeliveryDriver();
            deliveryDriver.DeliverProduct(product);
        }
    }



}
