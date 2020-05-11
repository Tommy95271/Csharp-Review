using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Ani = new Animal() { Name = "Ani", Sound = "Eeeee" };
            Ani.MakeSound();
            Ani.SetAnimalIdInfo(12346, "Mary");
            Ani.GetAnimalIdInfo();
            Dog Ahfu = new Dog("Ahfu", "Woof", "Grrr");
            Ahfu.Sound = "Woooooof";
            Ahfu.MakeSound();
            Ahfu.SetAnimalIdInfo(12345, "Tommy");
            Ahfu.GetAnimalIdInfo();

            Animal.AnimalHealth GetHealth = new Animal.AnimalHealth();

        }
    }
}
