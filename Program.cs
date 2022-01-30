using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(5, 4);

            point.ShowCurrentPosition();

            point.Move(3, 2);

            point.ShowCurrentPosition();


        }
    }
}
