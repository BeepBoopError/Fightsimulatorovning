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
            
            

            Console.ReadLine();
        }
    }
}
