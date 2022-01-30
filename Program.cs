using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Square object1 = new Square(5);

            Circle object2 = new Circle(4);

            Console.WriteLine(object1.GetArea());

            Console.WriteLine(object2.GetArea());

            Shape[] objects = { object1, object2 };

            Console.WriteLine(Shape.GetTotalArea(objects));


        }
    }
}
