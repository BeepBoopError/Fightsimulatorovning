using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Player : Fighter
    {


        public void Setter(Fighter oppTemp)
        {
            opponent = oppTemp;

            Console.WriteLine("Type Name");

            name = Console.ReadLine();

            Console.WriteLine("Choose Weapon" + name);
            Console.WriteLine(" 1. Sword \n 2. Knife \n 3. Psyonics \n 4. Halberd");

          

            bool undone = true;

            while (undone)
            {
                undone = false;
                string inner = Console.ReadLine();
                if (inner == "1")
                {
                    weapon = new Sword();
                   
                }
                else if (inner =="2")
                {
                    weapon = new Knife();
                }
                else if (inner == "3")
                {
                    weapon = new Psyonic();
                }
                else if (inner == "4")
                {
                    weapon = new Halberd();
                }
                else
                {
                    Console.WriteLine("invalid, try again");
                    undone = true;
                }
            } 

        }
    }
}
