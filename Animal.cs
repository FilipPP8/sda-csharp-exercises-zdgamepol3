using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public abstract class Animal
    {
        public string name;
        public string sound;

        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }

        public void MakeSound()
        {
            Console.Write(name + " wydaje dźwięk: " + sound + ".");
        }


    }
}
