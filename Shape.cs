using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public abstract class Shape
    {
        
        public abstract double GetArea();
       
        public static double GetTotalArea(Shape[] shapes)
        {
            double sum = 0;

            foreach (Shape shape in shapes)
            {
                sum += shape.GetArea();
            }

            return sum;
        }
    }
}
