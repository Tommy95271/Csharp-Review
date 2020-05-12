﻿using System;
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

            // Since interfaces can not not be instantiated, so we need a static method to return a new instance.
            // Six, delcare a TV with IElectronicDevice and assign TVRemote.GetDevice() to it, which achieve instantiating new Television.
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton TVPowBtn = new PowerButton(TV);
            TVPowBtn.Execute();
            TVPowBtn.Undo();
            Console.WriteLine(TV.GetType());

            IElectronicDevice Radio = RadioRemote.GetDevice();
            PowerButton RadioPowBtn = new PowerButton(Radio);
            RadioPowBtn.Execute();
            RadioPowBtn.Undo();
            Console.WriteLine(Radio.GetType());
        }
    }
}
