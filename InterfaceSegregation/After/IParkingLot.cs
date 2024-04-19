using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.After
{
    internal interface IParkingLot
    {
        void ParkCar(); 
        void UnparkCar(); 
        int GetCapacity(); 
    }
}
