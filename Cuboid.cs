using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Cuboid
    {
        double length;
        double width;
        double heigth;

        public Cuboid(double length, double width, double heigth)
        {
            this.length = length;
            this.width = width;
            this.heigth = heigth;
        }

        public double GetVolume()
        {
            return length * width * heigth;
        }

        public static void CompareVolume(Cuboid a, Cuboid b)
        {
            if (a.GetVolume() > b.GetVolume())
            {
                Console.WriteLine("Większa objętość wynosi: " + a.GetVolume());
            }
            else if (b.GetVolume() > a.GetVolume())
            {
                Console.WriteLine("Większa objętość wynosi: " +b.GetVolume());
            }
            else
            {
                Console.WriteLine("Obie objętości są równe.");
            }
        }

    }
}
