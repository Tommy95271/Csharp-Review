using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Radio : IElectronicDevice
    {
        public int Volumn { get; set; } = 0;
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
            if (Volumn >= 0)
            {
                Volumn--;
            }
            else
            {
                Volumn = 0;
            }
        }

        public void VolumnUp()
        {
            if (Volumn != 0)
            {
                Volumn++;
            }
            else if (Volumn < 0)
            {
                Volumn = 0;
            }
        }
    }
}
