using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary) 
            :base(firstName, lastName,yearOfBirth)
        {
            Console.WriteLine("Wywołano konstruktor z parametrami z klasy Employee");
            Salary = salary;
        }

        public Employee()
        {
            Console.WriteLine("Wywołano konstruktor bezparametrowy z klasy Employee");
        }

        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine("Moje zarobki to: " + Salary);
            Console.WriteLine("Całkowite zarobki: " + GetTotalSalary());
        }

        public virtual decimal GetTotalSalary()
        {
            return Salary;
        }
    }
}
