using System;

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

        Rectangle[] rectangles;

        public static void PrintInfoForAll (Rectangle[] rectangles)
        {
            foreach (Rectangle rectangle in rectangles)
            {
                Rectangle.PrintInfo(rectangle);
            }
        }

        public static void GetBiggestRectangle (Rectangle[] rectangles)
        {
            int[] areas = new int[rectangles.Length];

            for (int i = 0; i < rectangles.Length; i++)
            {
                areas[i] = rectangles[i].GetArea();
            }

            Array.Sort(areas);
            //Array.Reverse(areas);

            Console.WriteLine("Największe pole wynosi: " + areas[areas.Length-1]);

        }

}
}
