using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRes.After
{
    internal class Invoice
    {
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        private double total;

        public Invoice(Book book, int quantity, double discountRate, double taxRate)
        {
            this.book = book;
            this.quantity = quantity;
            this.discountRate = discountRate;
            this.taxRate = taxRate;
            this.total = CalculateTotal();
        }
        // Public properties to access private fields
        public Book Book => book;
        public int Quantity => quantity;
        public double DiscountRate => discountRate;
        public double TaxRate => taxRate;
        public double Total => total;



        // Method to calculate the total
        public double CalculateTotal()
        {
            double price = ((book.Price - book.Price * discountRate) * this.quantity);
            double priceWithTaxes = price * (1 + taxRate);
            return priceWithTaxes;
        }
    }
    public class Book
    {
        public Book() { }

        public string? Name { get; set; }
        public double Price { get; set; }
    }
}
