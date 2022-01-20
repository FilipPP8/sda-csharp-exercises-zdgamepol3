using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void printDistinctNumbers(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                int j;

                for (j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        break;
                    }
                }
                
                if (i == j)
                {
                    Console.Write(numbers[i] + " ");
                }

            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 0, 0, 2, 5, 1, 2, 5, 6, 0, 45, 321, 321, 45 };

            printDistinctNumbers(numbers);
        }
    }
}
