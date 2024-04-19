using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.After
{
    internal class FreeParkingC : IParkingLot
    {

        public void ParkCar()
        {
            
            Console.WriteLine("Park Car .");
        }
        public void UnparkCar()
        {
            
            Console.WriteLine("Un park Car .");
        }
        public int GetCapacity()
        {
            return 0;
        }
    }
}
