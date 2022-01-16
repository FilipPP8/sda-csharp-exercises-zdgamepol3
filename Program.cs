using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static public int GetPowerOf(int number, int power)
        {
            int value = number;
            for (int i = 1; i < power; i++)
            {
                value = value * number;
            }

            return value;
        }
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Podaj podstawę: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wykładnik: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (secondNumber < 0)
            {
                Console.WriteLine("Wykładnik jest ujemny :(");
            }
            else
            {
                Console.WriteLine(GetPowerOf(firstNumber, secondNumber));
            }
        }
    }
}
