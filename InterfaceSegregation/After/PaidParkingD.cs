using InterfaceSegregation.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.After
{
    internal class PaidParkingD:IParkingLot,IPaidParkingLot
    {


        public void ParkCar()
        {
            
            Console.WriteLine(" Park Car .");
        }
        public void UnparkCar()
        {
            
            Console.WriteLine(" Unpark Car .");
        }
        public int GetCapacity()
        {
            return 0;
        }

        public double CalculateFee()
        {
            return 0;
        }
        public void DoPayment()
        {
            Console.WriteLine(" Do Payment .");
        }
    }
}
