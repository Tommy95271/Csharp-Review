using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    // Second, we define a Television class to inherit from IElectronicDevice, add props we need and implement the methods.
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine($"The Tv is Off");
        }

        public void On()
        {
            Console.WriteLine($"The Tv is On");
        }

        public void VolumnDown()
        {
            if (Volume >= 0)
            {
                Volume--;
            }
            Console.WriteLine($"The TV is at {Volume}");
        }

        public void VolumnUp()
        {
            if (Volume != 100)
            {
                Volume++;
            }
            Console.WriteLine($"The TV is at {Volume}");
        }
    }
}
