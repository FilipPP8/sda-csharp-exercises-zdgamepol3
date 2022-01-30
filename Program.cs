using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle (4, 5);
            Rectangle rectangle2 = new Rectangle(3, 2);

            Rectangle.PrintInfo(rectangle1);

            Console.WriteLine("-----");

            Rectangle[] rectangles = { rectangle1, rectangle2 };

            foreach(Rectangle rectangle in rectangles)
            {
                Rectangle.PrintInfo(rectangle);
            }



        }
    }
}
