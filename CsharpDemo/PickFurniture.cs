using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class PickFurniture
    {
        public static Furniture GetFurniture(MyEnum myEnum)
        {
            if (myEnum == MyEnum.Bed)
            {
                return new Bed();
            }
            else if (myEnum == MyEnum.Chair)
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
