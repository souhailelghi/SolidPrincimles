//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SingleRes.Before
//{
//    internal class Facture
//    {
//    }

//        public class Invoice
//    {
//        private Book book;
//        private int quantity;
//        private double discountRate;
//        private double taxRate;
//        private double total;

//        public Invoice(Book book, int quantity, double discountRate, double taxRate)
//        {
//            this.book = book;
//            this.quantity = quantity;
//            this.discountRate = discountRate;
//            this.taxRate = taxRate;
//            this.total = CalculateTotal();
//        }


//        //first function : 
//        public double CalculateTotal()
//        {
//            double price = ((book.Price - book.Price * discountRate) * this.quantity);
//            double priceWithTaxes = price * (1 + taxRate);
//            return priceWithTaxes;
//        }

//        //move this 1
//        //seconde function : 
//        public void PrintInvoice()
//        {
//            Console.WriteLine(quantity + " x " + book.Name);
//            Console.WriteLine("Discount Rate: " + discountRate);
//            Console.WriteLine("Tax Rate: " + taxRate);
//            Console.WriteLine("Total: " + total);
//        }



//        //move this function 2
//        //thorth function : 

//        public void SaveToFile(string filename)
//        {
//            using (StreamWriter writer = new StreamWriter(filename))
//            {
//                writer.WriteLine(quantity + " x " + book.Name + " - $" + total);
//            }
//        }
//    }

//    public class Book
//    {
//        public string Name { get; set; }
//        public double Price { get; set; }
//    }
//}
