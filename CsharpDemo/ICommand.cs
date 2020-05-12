using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    // Third, we define a interface ICommand which contains the methods of functionality.
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
