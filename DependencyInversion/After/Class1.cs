using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.After
{
    internal class Class1
    {
    }



    namespace DependencyInversion.After
    {
        public class Product
        {
        
            public string? Name { get; set; } 
            public double Price { get; set; } 
        }
    }

  
    namespace DependencyInversion.After
    {
        public interface IDeliveryService<T>
        {
            void DeliverProduct(T product);
        }
    }


    namespace DependencyInversion.After
    {
        public class DeliveryCompany<T>
        {
            private IDeliveryService<T> deliveryService;

            public DeliveryCompany(IDeliveryService<T> deliveryService)
            {
                this.deliveryService = deliveryService;
            }

            public void SendProduct(T product)
            {
                this.deliveryService.DeliverProduct(product);
            }
        }
    }


    namespace DependencyInversion.After
    {
        public class DeliveryDriver : IDeliveryService<Product>
        {
            public void DeliverProduct(Product product)
            {
                Console.WriteLine("Deliver product.");
               
            }
        }
    }


}
