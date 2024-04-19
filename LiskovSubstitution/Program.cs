using LiskovSubstitution.After;
using LiskovSubstitution.Before;

namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {





            // After
            //Rectangle1 rectangle11 = new Rectangle1(10, 2);
            //Square1 square11 = new Square1(5, 5);

            //IncreaseShapeWidth(rectangle11) ;
            //IncreaseShapeWidth(square11);




            // Before
            //Rectangle rectangle = new Rectangle(10, 2);
            //Square square = new Square(5, 5);

            //IncreaseShapeWidth(rectangle);
            //IncreaseShapeWidth(square);

            //Console.WriteLine(rectangle.GetArea());
            //Console.WriteLine(square.GetArea());
        }

        public static void IncreaseShapeWidth(IShape rec)
        {
            rec.SetWidth(rec.GetWidth() + 1); // Increase width by 1
        }






        //---------------------------------------------


        //    //after
        //    Rectangle1 rectangle11 = new Rectangle1(10,2); 
        //    Square1 square11 = new Square1(5,5);


        //    //
        //    IncreaseShapeWidth(rectangle11);
        //    IncreaseShapeWidth(square11);







        //    //before : 
        //    Rectangle rectangle = new Rectangle(10, 2);
        //    Square square = new Square(5,5);
        //    //
        //    IncreaseShapeWidth(rectangle);
        //    IncreaseShapeWidth(square);
        //    //
        //    Console.WriteLine(rectangle.GetArea());
        //    Console.WriteLine(square.GetArea());
        //}
        //public static void IncreaseShapeWidth(IShape rec)
        //{
        //    rec.SetWith()
        //}
    }
}


