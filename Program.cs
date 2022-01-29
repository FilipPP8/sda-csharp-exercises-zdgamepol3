using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void PrintHello(Person person)
        {
            if (person.IsAdult)
            {
                Console.WriteLine("Witaj w monopolowym");
            }
            else
            {
                Console.WriteLine("Witaj w sklepie z zabawkami");
            }
        }
        static void Main(string[] args)
        {

            Employee employee = new Employee("Jan", "Kowalski", 2000, 5000);

            employee.WhoAmI();

            Employee manager = new Manager("Adam", "Nowak", 1990, 6500); // dzięki virtual-override wyświetla WhoAmI dla Manager, nie Employee

            manager.WhoAmI(); // wywołuje WhoAmI ze zmienionym GetSalary dla managera

            Person person2 = new Person("Zbigniew", "Polski", 1960);

            person2.WhoAmI();


        }
    }
}
