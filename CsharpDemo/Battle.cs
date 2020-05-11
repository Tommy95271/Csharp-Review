using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetBattleResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetBattleResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetBattleResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttk = warriorA.Attack();
            double warBBlk = warriorB.Block();
            double dmg2WarB = warAAttk - warBBlk;
            if (dmg2WarB > 0)
            {
                warriorB.Health -= dmg2WarB;
            }
            Console.WriteLine($"{warriorA.Name} made {dmg2WarB} damage to {warriorB.Name}.");
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} left.\n");
            if (warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} is dead and {warriorA.Name} is victorious!");
                return "Game Over";
            }
            else return "Keep fighting";

        }
    }
}
