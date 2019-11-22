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
            Player P1 = new Player();

            Console.WriteLine("Making 2");
            Player P2 = new Player();

            Console.WriteLine("Setting up");
            P1.Setter(P2, 2);
            P2.Setter(P1, 5);
            

            bool runGame = true;

            while (runGame)
            {




                Console.Clear();
                DrawPos(P1, P2);

                Console.WriteLine(P1.name +" stats are:");
                P1.PrintStats();

                Console.WriteLine(P2.name +" stats are:");
                P2.PrintStats();

                Console.ReadLine();

                Console.Clear();
                DrawPos(P1, P2);

                //players decide what they do

                Console.WriteLine(P1.name + " what do you wish to do?");

                P1.Weapon.AttackDescriptions();

                int p1AATemp = ReadNum();

                Console.WriteLine("Where do you wish to defend? \n1. Upper \n2. Middle \n3. Lower \n4. None");

                P1.defend = ReadNum();

                Console.Clear();
                DrawPos(P1, P2);

                Console.WriteLine(P2.name + " what do you wish to do?");

                P2.Weapon.AttackDescriptions();

                int p2AATemp = ReadNum();

                Console.WriteLine("Where do you wish to defend? \n1. Upper \n2. Middle \n3. Lower \n4. None");

                P2.defend = ReadNum();

                //turnstarters are run

                P1.Weapon.TurnStarter();

                P2.Weapon.TurnStarter();

                Console.Clear();
                DrawPos(P1, P2);

                //a random player gets to go first

                if (Fighter.rangen.Next(0,2) == 1)
                {
                    //player1 does their attack
                    Console.WriteLine(P1.name + " Attacks");
                    P1.AADial(p1AATemp);
                    Console.ReadLine();

                    //check if they are both alive
                    Console.WriteLine("Alive checking");
                    Console.ReadLine();

                    if (P1.GetAlive() && P2.GetAlive())
                    {
                        //render approriate 
                        Console.Clear();
                        DrawPos(P1, P2);


                        //player 2 does their attack
                        Console.WriteLine(P2.name  +" Attacks");
                        P2.AADial(p2AATemp);
                        Console.ReadLine();
                    }
                }
                else
                {
                    //player2 does their attack
                    Console.WriteLine(P2.name + " Attacks");
                    P2.AADial(p2AATemp);
                    Console.ReadLine();

                    //check if they are both alive
                    Console.WriteLine("Alive checking");
                    Console.ReadLine();

                    if (P1.GetAlive() && P2.GetAlive())
                    {
                        //render approriate 
                        Console.Clear();
                        DrawPos(P1, P2);


                        //player 1 does their attack
                        Console.WriteLine(P1.name + " Attacks");
                        P1.AADial(p1AATemp);
                        Console.ReadLine();
                    }
                }

                // check if they are both alive
                Console.WriteLine("Alive checking");
                Console.ReadLine();
                if (P1.GetAlive() && !P2.GetAlive())
                {
                    Console.WriteLine(P1.name + " won, Congratulations");

                    runGame = false;



                }
                else if (!P1.GetAlive() && P2.GetAlive())
                {
                    Console.WriteLine(P2.name + " won, Congratulations");

                    runGame = false;
                }
                else if (!P1.GetAlive() && !P2.GetAlive())
                {
                    Console.WriteLine("Both loose, Too Bad");

                    runGame = false;
                }

                Console.ReadLine();
                //render appropriate
                Console.Clear();
                DrawPos(P1, P2);

                //turnenders ar run

                P1.Weapon.TurnEnder();

                P2.Weapon.TurnEnder();



                

            }

            

            Console.ReadLine();
        }

        public static void DrawPos(Player Player1, Player Player2)
        {
            /*
            xxx    _        _    xxx
            xxx|1|(A)|3||4|(B)|6|xxx
            xxx------------------xxx

            
            
            */

            Console.SetCursorPosition(0,0);

            Console.Write("xxx\nxxx\nxxx");

            for (int i = 0; i < 6; i++)
            {
                if (Player1.GetPos() - 1 == i)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition((i + 1) * 3, 0);
                    Console.Write(" _ ");
                    Console.SetCursorPosition((i + 1) * 3, 1);
                    Console.Write("|"+ Player1.name.Substring(0,1) +"|");
                    
                }
                else if (Player2.GetPos() - 1 == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition((i + 1) * 3, 0);
                    Console.Write(" _ ");
                    Console.SetCursorPosition((i + 1) * 3, 1);
                    Console.Write("|"+ Player2.name.Substring(0, 1) + "|");
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition((i + 1) * 3, 0);
                    Console.Write("   ");
                    Console.SetCursorPosition((i + 1) * 3, 1);
                    Console.Write("|"+ (i+1) +"|");
                    
                }
                Console.SetCursorPosition((i + 1) * 3, 2);
                Console.Write("---");
                Console.ResetColor();
            }

            Console.SetCursorPosition(21,0);
            Console.Write("xxx");
            Console.SetCursorPosition(21, 1);
            Console.Write("xxx");
            Console.SetCursorPosition(21, 2);
            Console.WriteLine("xxx");
        }


        public static int ReadNum()
        {
            int result;

            bool read = int.TryParse(Console.ReadLine(), out result);

            if (!read || result < 0 || result > 5)
            {
                Console.WriteLine("Invalid input");
                result = ReadNum();
            }

            
            return result;

        }

    }
}
