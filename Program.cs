using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals = new Animal[2];

            Dog dog1 = new Dog("Miki");

            Cat cat1 = new Cat("Kocur");

            animals[0] = dog1;
            animals[1] = cat1;

            foreach (Animal animal in animals)
            {
                animal.MakeSound();

                if (animal is Cat)
                {
                    Console.WriteLine(" To jest kot.");
                }
                else if (animal is Dog)
                {
                    Console.WriteLine(" To jest piesek.");
                }
                else
                {
                    Console.WriteLine("Nie mam pojęcia jakie to zwierzę.");
                }
            }


        }
    }
}
