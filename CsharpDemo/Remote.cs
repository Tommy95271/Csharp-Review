using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    // Fifth, we define a class TVRomote, which has a static method so we can use the method without instantiating it,
    // the method has IElectronicDevice type and return a new Television.
    class Remote
    {
        public static IElectronicDevice GetDevice(string device)
        {
            if (device == "TV")
            {
                return new Television();
            }
            else if (device == "Radio")
            {
                return new Radio();
            }
            else
            {
                return null;
            }

        }
    }
}
