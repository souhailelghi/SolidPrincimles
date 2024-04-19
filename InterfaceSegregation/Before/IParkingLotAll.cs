using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Before
{
    internal interface IParkingLotAll
    {
        void ParkCar(); 
        void UnparkCar();
        int GetCapacity(); 
        double CalculateFee(); 
        void DoPayment();
    }
}
