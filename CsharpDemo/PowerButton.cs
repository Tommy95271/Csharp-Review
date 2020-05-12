using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    // Fourth, we define a class PowerButton and inherit from ICommand, this step is important,
    // we create a device of IElectronicDevice but we do not instantiate it, in the constructor,
    // we connect the parameter and the prop, if we pass any argument with IElectronicDevice interface,
    // we can use the methods Execute (which executes device.On()) and Undo (which executes device.Off()),
    // but we can not instantiate interface, what should we do?
    class PowerButton : ICommand
    {
        IElectronicDevice device;
        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
