using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class Person
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set // init oznacza, że właściwość można ustawić tylko przy inicjalizacji obiektu
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Imię nie może być pustym ciągiem znaków!");
                }
                firstName = value;
            }
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - YearOfBirth;
            }
        }

        public bool IsAdult => Age >= 18;

        public Person() : this("Nieznany", "Nieznany", 0)
        {
            Console.WriteLine("Wywołano konstruktor bezparametrowy z klasy Person");

        }

        public Person(string firstName, string lastName, int yearOfBirth) // konstruktor - jeśli nie ma, jest domyślny bezparametrowy
        {
            this.firstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;

            Console.WriteLine("Wywołano konstruktor z parametrami z klasy Person");
        }

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}.");
        }

    }
}
