using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class CleanTools : Bed, ICleanable
    {
        public bool Cleanable { get; set; }

        public void Clean()
        {
            if (Cleanable)
            {
                Console.WriteLine($"You can clean {Name}");
            }
        }
    }
}
