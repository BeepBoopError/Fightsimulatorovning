using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");

            /* 
   ____________________
  /         /    \     \
 /|         |     \Ò   |
x |         \___      -|
  |   ______    \_\   -|
  |   |  |  |   | \\  -/
  |   |  |  |   |  \__/   
  |DDD|DD|  |DDD|DD|
  */

            Console.WriteLine("   ____________________\n  /         /    \\     \\\n /|         |     \\Ò   |\nx |         \\___      -|\n  |   ______    \\_\\   -|\n  |   |  |  |   | \\\\  -/\n  |   |  |  |   |  \\__/\n  |DDD|DD|  |DDD|DD|");

            Console.WriteLine("Making 1");
            Player p1 = new Player();

            Console.WriteLine("Making 2");
            Player p2 = new Player();

            Console.WriteLine("Setting up");
            p1.Setter(p2, 2);
            p2.Setter(p1, 5);
            Drawer.PosUpdate(p1, p2);

            bool runGame = true;

            while (runGame)
            {
                //players decide what they do

                //turnstarters are run

                //a random player gets to go first

                if (Fighter.rangen.Next(0,2) == 1)
                {
                    //player1 does their attack

                    //check if they are both alive

                    //render approriate 

                    //player 2 does their attack
                }
                else
                {
                    //player 2 does their attack

                    //check if they are both alive

                    //render appropriate
                    
                    //player 1 does their attack
                }

                // check if they are both alive
                
                //turnenders ar run
                
                
                
                
            }

            

            Console.ReadLine();
        }
    }
}
