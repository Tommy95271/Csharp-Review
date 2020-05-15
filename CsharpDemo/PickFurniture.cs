using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class PickFurniture
    {
        public static Furniture GetFurniture()
        {
            if ( == "Bed")
            {
                return new Bed();
            }
            else if ( == "Chair")
            {
                return new Chair();
            }
            else
            {
                return null;
            }
        }
    }
}
