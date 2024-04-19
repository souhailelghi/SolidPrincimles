using InterfaceSegregation.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.After
{
    internal interface IPaidParkingLot
    {
        double CalculateFee();
        void DoPayment();
    }
}
