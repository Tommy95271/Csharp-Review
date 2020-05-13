using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class Bed : Furniture
    {
        public Bed(string name = "No Name",
            int years = 0,
            int legs = 0,
            string color = "No Color",
            double weight = 0,
            double length = 0,
            double price = 0) : base(name, years, legs, color, weight, length, price) { }
        public override void GetInfo()
        {
            base.GetInfo();
            if (Price<1000)
            {
                Console.WriteLine($"You got {Name} in such low price, impressive!");
            }
        }
    }
}
