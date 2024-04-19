using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After
{
    public class Invoice
    {

        //Attribut : 
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        private double total;



        //constructor 
        public Invoice(Book book, int quantity, double discountRate, double taxRate)
        {
            this.book = book;
            this.quantity = quantity;
            this.discountRate = discountRate;
            this.taxRate = taxRate;
            this.total = CalculateTotal();
        }



        //access for attrubit
        public Book Book => book;
        public int Quantity => quantity;
        public double DiscountRate => discountRate;
        public double TaxRate => taxRate;
        public double Total => total;



        //function for calculateTotal
        public double CalculateTotal()
        {
            double price = ((book.Price - book.Price * discountRate) * this.quantity);
            double priceWithTaxes = price * (1 + taxRate);
            return priceWithTaxes;
        }
    }
}
