using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            int price;

            quantity = 3;
            price = 5;

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Liczba sztuk: " + i + " łączna cena: " + i*price + "zł");
            }
        }
    }
}
