//using OpenClosed.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After
{
    public interface IInvoiceSaver
    {
        void SaveToFile(Invoice invoice, string fileName);
    }
}
