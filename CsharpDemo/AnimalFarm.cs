using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class AnimalFarm
    {
        List<Animal> animalList = new List<Animal>();
        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }
        public AnimalFarm() { }

    }
}
