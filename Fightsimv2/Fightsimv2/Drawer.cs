using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Drawer
    {

        public static void InGame(Player player1, Player player2)
        {
            Console.Clear();
            Console.WriteLine();

            


        }

        public static void PosUpdate(Player player1, Player player2)
        {
            Console.Write("   xX");

            for (int i = 0; i < 6; i++)
            {
                if (player1.GetPos() - 1 == i)
                {
                    Console.Write("1");
                }
                else if (player2.GetPos() - 1 == i)
                {
                    Console.Write("2");
                }
                else
                {
                    Console.Write("_");
                }
            }

            Console.WriteLine("Xx");
        }


        public static void GameOver()
        {

        }



    }
}
