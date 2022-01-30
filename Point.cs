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
    }
}
