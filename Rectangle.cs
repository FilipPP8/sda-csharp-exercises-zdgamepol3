using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class Rectangle
    {
        int sideA;
        int sideB;

        public Rectangle(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        private int GetArea()
        {
            return sideA * sideB;
        }

        private int GetCircumference()
        {
            return (2 * sideA) + (2 * sideB);
        }

        public static void PrintInfo(Rectangle rectangle)
        {
            Console.WriteLine("Pole powierzchni tego prostkąta wynosi: " + rectangle.GetArea());
            Console.WriteLine("Obwód tego prostokąta wynosi: " + rectangle.GetCircumference());
        }
    }
}
