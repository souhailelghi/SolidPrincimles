using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After
{
    public class InvoiceSaver : IInvoiceSaver
    {
        public void SaveToFile(Invoice invoice, string fileName)
        {
            // Implementation to save the invoice to a file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(invoice.Quantity + " x " + invoice.Book.Name + " - $" + invoice.Total);
            }
        }
    }
}
