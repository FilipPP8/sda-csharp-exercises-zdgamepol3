using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void GetArithmeticSequence(int sequenceLength, int firstNumber, int difference)
        {
            int result = firstNumber;

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Write(result + " ");
                result += difference;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość ciągu: ");
            int sequenceLenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj pierwszy element ciągu: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj różnicę ciągu: ");
            int difference = Convert.ToInt32(Console.ReadLine());

            GetArithmeticSequence(sequenceLenght, firstNumber, difference);

        }
    }
}
