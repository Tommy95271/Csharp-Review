using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Warrior
    {
        private string name;
        private double health;
        private double attack;
        private double block;
        private double attkMax;
        private double blkMax;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    value = "Warrior";
                }
                name = value;
            }
        }

        public double Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                health = value;
            }
        }

        public double Attack
        {
            get { return attack; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                attack = value;
            }
        }

        public double Block
        {
            get { return block; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                block = value;
            }
        }


        public double AttkMax
        {
            get { return attkMax; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                attkMax = value;
            }
        }

        public double BlkMax
        {
            get { return blkMax; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                blkMax = value;
            }
        }

        public Warrior(string name = "Warrior",
            double health = 0,
            double attack = 0,
            double block = 0,
            double attkMax = 0,
            double blkMax = 0)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Block = block;
            AttkMax = attkMax;
            BlkMax = blkMax;
        }
    }
}
