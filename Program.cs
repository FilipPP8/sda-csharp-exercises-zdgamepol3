using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static public void PrintTriangleAndReverse(char symbol, int number)
        {
            for (int i=0; i < number; i++)
            {
                for (int j=0; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            for (int i = number - 1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj znak: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj liczbę linii: ");
            int number = Convert.ToInt32(Console.ReadLine());

            PrintTriangleAndReverse(symbol, number);
        }
    }
}
