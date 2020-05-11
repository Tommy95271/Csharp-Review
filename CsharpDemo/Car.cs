using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Car : IDrivable
    {
        public int Wheel { get; set; }
        public double Speed { get; set; }

        public void Drive()
        {
            
        }

        public void Stop()
        {
            
        }
    }
}
