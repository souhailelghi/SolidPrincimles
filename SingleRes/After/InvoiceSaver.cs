//using Distribution_essence.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRes.After
{
    internal class InvoiceSaver
    {
        public void SaveToFile(Invoice invoice, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(invoice.Quantity + " x " + invoice.Book.Name + " - $" + invoice.Total);
            }
        }
    }
}
