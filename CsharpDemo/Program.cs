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
            Animal target2 = new Animal("Beyonce");
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

            animalList.Add(target2);
            Console.WriteLine($"Does animalList contain Beyonce? {animalList.Contains(target2)}");
            Console.WriteLine("------------------------------");

            Console.WriteLine($"How many animals are in animalList? {animalList.Count()}");
            Console.WriteLine($"How many animals are in animalList? {animalList.Count}");
            Console.WriteLine("------------------------------");



        }
    }
}
