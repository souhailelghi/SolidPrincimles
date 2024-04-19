using OpenClosed.After;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open_Closed !!");

            Console.WriteLine("Hello, World! open-closed with !!");

            // Example usage:
            //OpenBook openBook = new OpenBook { Name = "clean code", Price = 20.0 };
            //  OpenInvoice openInvoice = new OpenInvoice(openBook, 2, 0.1, 0.05);

            Console.WriteLine("------------------------------------------------------");
            //test------
            Book book1 = new Book { Name = "free palastin", Price = 60.0 };





            //invoice
            Invoice invoice1 = new Invoice(book1, 3, 0.1, 0.03);



            // Print invoice //base class 
            IInvoicePrinter invoicePrinter = new ConsoleInvoicePrinter(); // Instantiate the printer
            //invoicePrinter.PrintInvoice(openInvoice); // Call the PrintInvoice method
            invoicePrinter.PrintInvoice(invoice1); // Call the PrintInvoice method  2





            // Save invoice to file
            //IInvoiceSaver invoiceSaver = new InvoiceSaver(); // Instantiate the saver
            //invoiceSaver.SaveToFile(openInvoice, "invoice.txt"); // Call the SaveToFile method
            //invoiceSaver.SaveToFile(invoice1, "invoice.txt"); // Call the SaveToFile method



        }
    }
}
