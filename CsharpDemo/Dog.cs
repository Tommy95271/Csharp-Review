using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Dog : Animal
    {
        private string sound2;

        public string Sound2
        {
            get { return sound2; }
            set
            {
                if (value.Length > 10)
                {
                    value = "No Sound";
                }
                sound2 = value;
            }
        }
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(
            string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound")
            : base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}
