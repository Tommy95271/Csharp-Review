using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Television : IElectronicDevice
    {
        public int Volumn { get; set; }
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
            if (Volumn >= 0)
            {
                Volumn--;
            }
            Console.WriteLine($"The TV is at {Volumn}");
        }

        public void VolumnUp()
        {
            if (Volumn != 100)
            {
                Volumn++;
            }
            Console.WriteLine($"The TV is at {Volumn}");
        }
    }
}
