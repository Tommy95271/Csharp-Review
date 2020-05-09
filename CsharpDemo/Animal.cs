using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Animal
    {
        private string name;
        private string sound;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    value = "No Name";
                }
                name = value;
            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    value = "No Sound";
                }
                sound = value;
            }
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            : this("No Name", "No Sound") { }
        public Animal(string name)
            : this(name, "No Sound") { }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
    }
}
