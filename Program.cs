using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(5, 4);

            Point.ShowCurrentPosition(point);

            Point.Move(point, 3, 2);

            Point.ShowCurrentPosition(point);


        }
    }
}
