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

        public virtual void MakeSound()
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
        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();
        public void SetAnimalIdInfo(int idNum, string owner)
        {
            animalIdInfo.IdNum = idNum;
            animalIdInfo.Owner = owner;
        }
        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{Name} has Id {animalIdInfo.IdNum} and is owned by {animalIdInfo.Owner}");
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= 0.18) && (calc <= 0.26))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
