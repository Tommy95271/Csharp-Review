using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class PowerButton : ICommand
    {
        IElectronicDevice device;
        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
