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

        public void Move(int moveX, int moveY)
        {
            X += moveX;
            Y += moveY;
        }

        public void ShowCurrentPosition()
        {
            Console.WriteLine("Aktualna pozycja punktu to " + X + " oraz " + Y);
        }


        public static void Collinear(Point point1, Point point2, Point point3)
        {

            int a = point1.X * (point2.Y - point3.Y) + point2.X * (point3.Y - point1.Y) + point3.X * (point1.Y - point2.Y);

            if (a == 0)
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}
