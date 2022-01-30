using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 2);
            Point point3 = new Point(3, 3);


            Point.Collinear(point1, point2, point3);

            //point1.ShowCurrentPosition();

            //point1.Move(3, 2);

            //point1.ShowCurrentPosition();

            Console.WriteLine("-----");

            Point point4 = new Point(4, 5);
            Point point5 = new Point(11, 23);
            Point point6 = new Point(13, 1);

            Point.Collinear(point4, point5, point6);



        }
    }
}
