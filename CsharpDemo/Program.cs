using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            Animal target = new Animal("Jessica");
            animalList.Add(new Animal("Doad"));
            animalList.Add(new Animal("Jess"));
            animalList.Add(target);
            animalList.Add(new Animal("Beca"));
            animalList.Insert(1, new Animal() { Name = "Koe" });
            foreach (var o in animalList)
            {
                Console.WriteLine(o.Name);
            }
            Console.WriteLine("------------------------------");
         
            animalList.Remove(target);
            foreach (var o in animalList)
            {
                Console.WriteLine(o.Name);
            }
            Console.WriteLine("------------------------------");
        }
    }
}
