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
            //Person person1 = new Person();
            //Person person2 = new Person();

            //person1.SetFirstName("Jan");
            //Console.WriteLine(person1.GetFirstName());

            //person2.FirstName = "Adam";
            //Console.WriteLine(person2.FirstName);

            //person2.YearOfBirth = 2000;
            //Console.WriteLine(person2.Age);

            //Person person = new Person() // blok inicjalizacyjny
            //{
            //    FirstName = "Jan",
            //    LastName = "Kowalski",
            //    YearOfBirth = 2000
            //};

            //Console.WriteLine(person.IsAdult);

            //person.WhoAmI();

            //Employee employee = new Employee()
            //{
            //    FirstName = "Adam",
            //    LastName = "Nowak",
            //    YearOfBirth = 1990
            //};

            //employee.WhoAmI();

            //Person person = new Person("Jan", "Kowalski", 2000);
            //Person person2 = new Person();

            //Employee employee2 = new Employee("Jan", "Kowalski", 1980, 5000);

            Person person = new Person("Jan", "Kowalski", 2010);
            Employee employee = new Employee("Adam", "Nowak", 2000, 5000);

            Person[] people = { person, employee };

            foreach (Person p in people)
            {
                p.WhoAmI();
                //if (p is Employee)
                //{
                //    Employee e = (Employee)p;
                //    Console.WriteLine("Zarobki: " + e.Salary);
                //}
                if (p is Employee e) // skrócony zapis - jeśli p jest Employee, stwórz zmienną e
                {
                    Console.WriteLine("Zarobki: " + e.Salary);
                }

                Employee e2 = p as Employee;
                if (e2 != null)
                {
                    e2.WhoAmI();
                }

                PrintHello(p);

            }



        }
    }
}
