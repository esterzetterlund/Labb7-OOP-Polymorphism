namespace Labb7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {   //declared a reference of type geometry, that I use to point to diffrent object 
            Geometry geoObject;  
            
            Rectangle minRectangle = new Rectangle();
            geoObject = minRectangle;

            //Area() method is called on the geoobject, 
            //it will call the version of the method defined in the current subclass
            double rectangleArea = geoObject.Area();
            Console.WriteLine("Arean på Rektangeln : " + rectangleArea + "cm2"); 

            Square minSquare = new Square();
            geoObject = minSquare;

            double squareArea = geoObject.Area();
            Console.WriteLine("Arean på Fyrkanten : " + squareArea + "cm2");


            Parallelogram minParallelogram = new Parallelogram();
            geoObject = minParallelogram;

            double parallelogramArea = geoObject.Area();
            Console.WriteLine("Arean på Parallellogramen : " + parallelogramArea + "cm2");


            Circle minCircle = new Circle();
            geoObject = minCircle;

            double circleArea = geoObject.Area();
            Console.WriteLine("Arean på Cirkeln : " + circleArea + "cm2");


            Ellipse minEllipse = new Ellipse();
            geoObject = minEllipse;

            double ellipseArea = geoObject.Area();
            Console.WriteLine("Arean på Ellipsen : " + ellipseArea + "cm2");

        }
    }
}