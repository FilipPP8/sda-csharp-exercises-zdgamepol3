using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid object1 = new Cuboid(3, 4, 5);
            Cuboid object2 = new Cuboid(4, 5, 6);
            Cuboid object3 = new Cuboid(3, 4, 5);

            Console.WriteLine(object1.GetVolume());

            Console.WriteLine(object2.GetVolume());

            Cuboid.CompareVolume(object1, object2);

            Console.WriteLine("------");

            Console.WriteLine(object1.GetVolume());

            Console.WriteLine(object3.GetVolume());

            Cuboid.CompareVolume(object1, object3);
        }
    }
}
