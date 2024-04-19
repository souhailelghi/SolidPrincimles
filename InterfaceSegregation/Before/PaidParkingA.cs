using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Before
{
    internal class PaidParkingA : IParkingLotAll
    {
        public double CalculateFee()
        {
        
            return 0;
        }

        public void DoPayment()
        {
            
            Console.WriteLine(" Do Payment");
        }

        public int GetCapacity()
        {
            return 10;
        }

        public void ParkCar()
        {
        
            Console.WriteLine(" Park Car !");
        }

        public void UnparkCar()
        {
           

            Console.WriteLine(" Unpark Car !");
        }
    }
}
