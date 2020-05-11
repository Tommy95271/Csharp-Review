using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class AnimalIdInfo
    {
        public bool HealthyWeight(double height, double weight)
        {
            double calc = height / weight;

            if ((calc < 2.7) || (calc > 1.8))
            {
                Console.WriteLine("Good job!");
                return true;
            }
            else
            {
                Console.WriteLine("Your pet is overweighted...");
                return false;
            }
        }
    }
}
