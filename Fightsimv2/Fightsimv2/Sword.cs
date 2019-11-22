using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Sword : Weapon
    {


        public Sword(Fighter WTemp) : base(WTemp)
        {
            name = "Sword";

            Console.WriteLine("Sword chosen");
        }

        public override void AttackDescriptions()
        {
            Console.WriteLine("1.  Swing");
            Console.WriteLine("   Medium damage, Hits middle 1 & 2 forward");

            Console.WriteLine("2.  Pummel");
            Console.WriteLine("   Light damage, Hits upper 1 forward -> Knocks back 1");

            Console.WriteLine("3.  Advancing strike");
            Console.WriteLine("   Medium damage, Moves Forewards 1 -> Hits middle 1 forward ");

            Console.WriteLine("4.  Pierce armor");
            Console.WriteLine("   High damage, Hits lower 1 forward ");
        }

        public override void AttackOne()
        {
            bool hit1 = AAttackXY(1, 2);
            bool hit2 = AAttackXY(2, 2);

            if (hit1 || hit2)
            {
                Opponent.Hurt(Fighter.rangen.Next(3, 7));
            }
        }

        public override void AttackTwo()
        {
            bool hit = AAttackXY(1, 1);
            if (hit)
            {
                Opponent.Hurt(Fighter.rangen.Next(2, 6));
                Opponent.Move(-1);
            }
        }

        public override void AttackThree()
        {
            bool move = Owner.Move(1);
            if (move)
            {
                bool hit = AAttackXY(1, 2);
                if (hit)
                {
                    Opponent.Hurt(Fighter.rangen.Next(3, 7));
                }
            }
        }

        public override void AttackFour()
        {
            bool hit = AAttackXY(1, 3);
            if (hit)
            {
                Opponent.Hurt(Fighter.rangen.Next(5, 12));
            }
        }
    }
}
