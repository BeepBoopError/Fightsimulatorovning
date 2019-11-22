using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Halberd : Weapon
    {



        public Halberd(Fighter WTemp) : base(WTemp)
        {
            name = "Halberd";

            Console.WriteLine("Halberd chosen");
        }

        public override void AttackDescriptions()
        {
            Console.WriteLine("1.  Impale");
            Console.WriteLine("   Medium damage, Moves forwards 1 -> Hits middle 1 & 2 forward");

            Console.WriteLine("2.  Leg sweep");
            Console.WriteLine("   Medium damage, Hits lower 1 & 2 forwards");

            Console.WriteLine("3.  Bring 'em down");
            Console.WriteLine("   Variable damage, Hits upper 1 forwards for light damage -> Hits middle 1 forwards for medium damage -> Hits lower 1 forwards for high damage");

            Console.WriteLine("4.  Overhead");
            Console.WriteLine("   Medium damage, Moves forward 1 -> Hits middle 1 forwards -> Pulls 3");
        }


        public override void AttackOne()
        {
            bool move = Owner.Move(1);
            if (move)
            {
                bool hit1 = AAttackXY(1, 2);
                bool hit2 = AAttackXY(2, 2);
                if(hit1 || hit2)
                {
                    Opponent.Hurt(Fighter.rangen.Next(3, 7));
                }
            }
        }

        public override void AttackTwo()
        {
            bool hit1 = AAttackXY(1, 3);
            bool hit2 = AAttackXY(2, 3);

            if (hit1 || hit2)
            {
                Opponent.Hurt(Fighter.rangen.Next(3, 7));
            }
        }

        public override void AttackThree()
        {
            bool hit = AAttackXY(1, 1);
            if (hit)
            {
                Opponent.Hurt(Fighter.rangen.Next(2, 6));
                bool hit2 = AAttackXY(1, 2);
                if (hit2)
                {
                    Opponent.Hurt(Fighter.rangen.Next(3, 7));
                    bool hit3 = AAttackXY(1, 3);
                    if (hit3)
                    {
                        Opponent.Hurt(Fighter.rangen.Next(5, 12));
                    }
                }
            }
        }

        public override void AttackFour()
        {
            bool move = Owner.Move(1);
            if (move)
            {
                bool hit = AAttackXY(1, 2);
                if (hit)
                {
                    Opponent.Hurt(Fighter.rangen.Next(3, 7));
                    Opponent.Move(3);
                }
            }
        }
    }
}
