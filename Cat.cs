using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Cat : Animal
    {
        static string catSound = "miau";
        public Cat(string name)
            : base(name, catSound)
        {         
        }

    }
}
