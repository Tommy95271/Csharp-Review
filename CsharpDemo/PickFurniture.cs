using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class PickFurniture
    {
        public static Furniture GetFurniture(Furniture furniture)
        {
            if (furniture.GetType().ToString() == "Bed")
            {
                return new Bed();
            }
            else if (furniture.GetType().ToString() == "Chair")
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
