using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Before
{
    internal class FreeParkingA : IParkingLotAll
    {
        public void ParkCar()
        {
           
            Console.WriteLine(" Free Park Cark !");
        }
        public void UnparkCar()
        {
          
            Console.WriteLine(" Free Unpark Car !");
        }
        public int GetCapacity()
        {
            return 0;
        }
        // here we violate the interface segregation principle
        // because it's free park
        public double CalculateFee()
        {
            return 0;
        }
        public void DoPayment()
        {

        }


    }
}
