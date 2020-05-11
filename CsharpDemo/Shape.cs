using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    abstract class Shape
    {
        public string Name { get; set; } = "No Name";
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double Area();
    }
}
