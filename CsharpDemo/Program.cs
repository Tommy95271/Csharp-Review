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
            Dog Ahfu = new Dog("Ahfu", "Woof", "Grrr");
            Ahfu.Sound = "Woooooof";
            Ahfu.MakeSound();

        }
    }
}
