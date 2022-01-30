using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Point
    {
        int X { get; set; }
        int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static void Move(Point point, int moveX, int moveY)
        {
            point.X += moveX;
            point.Y += moveY;
        }

        public static void ShowCurrentPosition(Point point)
        {
            Console.WriteLine("Aktualna pozycja punktu to " + point.X + " oraz " +point.Y);
        }
    }
}
