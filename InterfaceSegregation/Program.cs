using InterfaceSegregation.Before;

namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example for Paid Parking !!
            Console.WriteLine(" Paid Parking  !!");
            PaidParkingA paidParkingA = new PaidParkingA();
            paidParkingA.UnparkCar();
            paidParkingA.ParkCar();
            paidParkingA.GetCapacity();
            //-----------
            paidParkingA.CalculateFee();
            paidParkingA.DoPayment();



            Console.WriteLine("\n");
            //Example for Free Parking !!
            Console.WriteLine(" Free Parking  !!");
            FreeParkingA freeParkingA = new FreeParkingA();
            freeParkingA.UnparkCar();
            freeParkingA.ParkCar();
            freeParkingA.GetCapacity();



            // violates
            //paidParkingA.CalculateFee();
            //paidParkingA.DoPayment();


            Console.WriteLine();
        }
    }
}
