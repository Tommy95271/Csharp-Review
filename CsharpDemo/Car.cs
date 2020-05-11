using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Car : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }
        public Car(string brand = "No Brand", int wheels = 0,double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }
        public void Drive()
        {
            Console.WriteLine($"{Brand} Moves forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} Stops");
            Speed = 0;
        }
    }
}
