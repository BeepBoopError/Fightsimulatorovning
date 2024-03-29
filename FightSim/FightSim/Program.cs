﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter A = new Fighter() { };

            Fighter B = new Fighter() { };
            Console.WriteLine("Buckle up buckaroo, it's time to fight, " + A.name + " VS " + B.name);
            
            bool fighting = true;

            Console.WriteLine("It's fighting time!");

            Console.ReadLine();

            while (fighting)
            {
                //they hurt eachother for the others damage
                B.Hurt(A.Attack());
                A.Hurt(B.Attack());

                //if they're both alive
                if (A.IsAlive() && B.IsAlive())
                {
                    Console.WriteLine("Both are hurt! Owie");
                    Console.WriteLine(A.name + " Has " + A.GetHp() + " Hitpoints left!");
                    Console.WriteLine(B.name + " Has " + B.GetHp() + " Hitpoints left!");
                    Console.WriteLine("They prepare for another round");
                }
                //if both die
                else if (A.IsAlive() == false && B.IsAlive() == false)
                {
                    Console.WriteLine("Both combatants fall, too bad!");
                    fighting = false;
                }
                //if B dies
                else if (A.IsAlive() && B.IsAlive() == false)
                {
                    Console.WriteLine(A.name + " stands victorious, " + B.name + " falls!");
                    fighting = false;
                }
                //if A dies
                else
                {
                    Console.WriteLine(B.name + " stands victorious, " + A.name + " falls!");
                    fighting = false;
                }
                Console.ReadLine();
            }

            Console.WriteLine("That's All Folks!");

            Console.ReadLine();
        }
    }
}
