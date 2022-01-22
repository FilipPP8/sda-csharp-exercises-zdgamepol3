using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static bool ControlDigit(string pesel)
        {
            int[] scale = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            int[] peselDigits = new int[pesel.Length];

            for (int i=0; i < pesel.Length; i++)
            {
                peselDigits[i] = Convert.ToInt32(Char.GetNumericValue(pesel[i]));
            }

            int s = 0;

            for (int j=0; j < peselDigits.Length -1; j++)
            {
                s += peselDigits[j] * scale[j];
            }

            int m = s % 10;

            if (10 - m == peselDigits[10])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            string pesel = "55030101193"; // poprawny pesel
            string pesel1 = "94040421293"; // niepoprawny pesel

            Console.WriteLine(ControlDigit(pesel));
            Console.WriteLine(ControlDigit(pesel1));
        }
    }
}
