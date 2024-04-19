using SingleRes.After;

namespace SingleRes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
     
            Book book = new Book { Name = "100Day", Price = 20.0 };
            Invoice inv = new Invoice(book, 2, 0.2, 0.5);

            // Example usage:
            //Book book = new Book { Name = "BookName", Price = 20.0 };
            //Invoice invoice = new Invoice(book, 2, 0.1, 0.05);

            //before : 
            //invoice.PrintInvoice();

            // after : 
        InvoicePrinter invoicePrinter = new InvoicePrinter(inv);
            invoicePrinter.PrintInvoice(inv);


            //before : 
            //invoice.SaveToFile("invoice.txt");

            //after : 
           InvoiceSaver invoiceSaver = new InvoiceSaver();
            invoiceSaver.SaveToFile(inv, "invoice.txt");

        }
    }
}
