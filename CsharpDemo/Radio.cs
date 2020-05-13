using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Radio : IElectronicDevice
    {
        public int Volume { get; set; } = 0;
        public void Off()
        {
            Console.WriteLine("The Radio is Off");
        }

        public void On()
        {
            Console.WriteLine("The Radio is On");

        }

        public void VolumnDown()
        {
            if (Volume >= 0)
            {
                Volume--;
            }
            else
            {
                Volume = 0;
            }
        }

        public void VolumnUp()
        {
            if (Volume != 0)
            {
                Volume++;
            }
            else if (Volume < 0)
            {
                Volume = 0;
            }
        }
    }
}
