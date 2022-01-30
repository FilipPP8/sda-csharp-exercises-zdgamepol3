using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle (4, 5);
            Rectangle rectangle2 = new Rectangle(3, 2);
            Rectangle rectangle3 = new Rectangle(10, 2);
            Rectangle rectangle4 = new Rectangle(14, 5);


            Rectangle.PrintInfo(rectangle1);

            Console.WriteLine("-----");

            Rectangle[] rectangles = { rectangle1, rectangle2, rectangle3, rectangle4 };

            Rectangle.PrintInfoForAll(rectangles);

            Console.WriteLine("-----");

            Rectangle.GetBiggestRectangle(rectangles);



        }
    }
}
