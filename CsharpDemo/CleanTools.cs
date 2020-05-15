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
        public CleanTools(Furniture furniture, bool cleanable, string name)
        {
            this.furniture = furniture;
            Cleanable = cleanable;
            Name = name;
        }
        public bool Cleanable { get; set; } = false;

        public void Clean()
        {
            if (Cleanable)
            {
                Console.WriteLine($"You can clean {Name}");
            }
        }
    }
}
