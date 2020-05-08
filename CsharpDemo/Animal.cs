using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class Animal
    {
        // Name of animal
        public string name { get; set; }
        // Sound of animal
        public string sound { get; set; }
        // Constructor of Animal, unlike struct, default parameter works in class.
        public Animal(string name = "no name", string sound = "no sound")
        {
            // The data you input will be assigned to name and sound.
            this.name = name;
            this.sound = sound;
            // When you create an Animal, numOfAnimals will plus one.
            numOfAnimals++;
        }
        // An easy function to show data
        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }
        // We add static to this prop,
        static int numOfAnimals = 0;
        // and this function.
        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
