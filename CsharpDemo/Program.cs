using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ford", 4, 160);
            if (car is IDrivable)
            {
                car.Drive();
                car.Stop();
            }
            else
            {
                Console.WriteLine($"{car.Brand} can't be driven.");
            }
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton TVPowBtn = new PowerButton(TV);
            TVPowBtn.Execute();
            TVPowBtn.Undo();

            IElectronicDevice Radio = RadioRemote.GetDevice();
            PowerButton RadioPowBtn = new PowerButton(Radio);
            RadioPowBtn.Execute();
            RadioPowBtn.Undo();
        }
    }
}
