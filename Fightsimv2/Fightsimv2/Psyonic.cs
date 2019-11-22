using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Psyonic : Weapon 
    {

        public Psyonic(Fighter WTemp) : base(WTemp)
        {
            name = "Psyonics";

            Console.WriteLine("Psyonic chosen");
        }

        public override void AttackDescriptions()
        {
            Console.WriteLine("1.  Psyblast");
            Console.WriteLine("   Light damage, Hits middle 1 & 2 forward -> Knocks back 1");

            Console.WriteLine("2.  Flux");
            Console.WriteLine("   Medium damage, Hits upper 1 forward & Hits lower 2 forward -> Moves backwards 1 & Knocks back 1");

            Console.WriteLine("3.  Warp");
            Console.WriteLine("   No damage, Moves forwards 3 -> Hits upper 1 -> Knocks back 3");

            Console.WriteLine("4.  Force Push");
            Console.WriteLine("   Light damage, Hits middle 2 forward -> Knocks back 2");
        }

        public override void AttackOne()
        {
            bool hit1 = AAttackXY(1, 2);
            bool hit2 = AAttackXY(2, 2);

            if(hit1 || hit2)
            {
                Opponent.Hurt(Fighter.rangen.Next(2, 6));
                Opponent.Move(-1);
            }
        }

        public override void AttackTwo()
        {
            bool hit1 = AAttackXY(1, 1);
            bool hit2 = AAttackXY(2, 3);
            if (hit1 || hit2)
            {
                Opponent.Hurt(Fighter.rangen.Next(3, 7));
                Owner.Move(-1);
                Opponent.Move(-1);
            }

        }

        public override void AttackThree()
        {
            bool move = Owner.Move(3);
            if (move)
            {
                bool hit = AAttackXY(1, 1);
                if (hit)
                {
                    Opponent.Move(-3);
                }
            }
        }

        public override void AttackFour()
        {
            bool hit = AAttackXY(2, 2);
            if (hit)
            {
                Opponent.Hurt(Fighter.rangen.Next(2, 6));
                Opponent.Move(-2);
            }
        }


    }
}
