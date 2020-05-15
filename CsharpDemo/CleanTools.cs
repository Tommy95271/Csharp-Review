using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class CleanTools : Bed, ICleanable
    {
        Furniture furniture;
        public CleanTools(Furniture furniture,
            bool cleanable,
            string name = "No Name",
            int years = 0,
            int legs = 0,
            string color = "No Color",
            double weight = 0,
            double length = 0,
            double price = 0): base(name,years,legs,color,weight,length,price)
        {
            this.furniture = furniture;
            Cleanable = cleanable;
        }
        public bool Cleanable { get; set; } = false;

        public void Clean()
        {
            if (Cleanable)
            {
                Console.WriteLine($"You can clean {Name}");
            }
            else
            {
                Console.WriteLine($"Unless you want to lose {Price} dollars, don't wash it!");
            }
        }
    }
}
