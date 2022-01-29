using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Dog : Animal
    {
        static string dogSound = "hau";
        public Dog(string name) 
            : base(name, dogSound)
        {

        }
    }
}
