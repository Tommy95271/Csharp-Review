using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    interface ICleanable
    {
        bool Cleanable { get; set; }
        void Clean();
    }
}
