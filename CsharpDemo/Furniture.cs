using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    abstract public class Furniture
    {
        public Furniture(string name = "No Name",
            int years = 0,
            int legs = 0,
            string color = "No Color",
            double weight = 0,
            double length = 0,
            double price = 0)
        {
            Name = name;
            Years = years;
            Legs = legs;
            Color = color;
            Weight = weight;
            Length = length;
            Price = price;
        }
        public string Name { get; set; }
        public int Years { get; set; }
        public int Legs { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Price { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} was made in {Years} year and has {Legs} legs." +
                $" Its color is {Color}, it is {Weight} kg and {Length} tall, most importantly, it's only {Price} dollars!");
        }
    }
}
