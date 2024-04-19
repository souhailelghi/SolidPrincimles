//using Distribution_essence.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRes.After
{
    internal class InvoicePrinter
    {
        private Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine(invoice.Quantity + " x " + invoice.Book.Name);
            Console.WriteLine("Discount Rate: " + invoice.DiscountRate);
            Console.WriteLine("Tax Rate: " + invoice.TaxRate);
            Console.WriteLine("Total: " + invoice.Total);
        }
    }
}
