using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    // First, we want to define a interface which contains only methods, so devices can inherit and implement it.
    interface IElectronicDevice
    {
        void Off();
        void On();
        void VolumnDown();
        void VolumnUp();
    }
}
