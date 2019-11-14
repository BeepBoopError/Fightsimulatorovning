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

        public override void AttackOne(Fighter Attacker, Fighter Defender)
        {
            bool hit1 = AAttackXY(1, 2, Attacker, Defender);
            bool hit2 = AAttackXY(2, 2, Attacker, Defender);

            if (hit1 || hit2)
            {
                Defender.Hurt(Fighter.rangen.Next(3, 7));
            }
        }

        public override void AttackTwo(Fighter Attacker, Fighter Defender)
        {
            bool hit = AAttackXY(1, 3, Attacker, Defender);
            if (hit)
            {
                Defender.Hurt(Fighter.rangen.Next(2, 6));
                Defender.Move(-1);
            }
        }

        public override void AttackThree(Fighter Attacker, Fighter Defender)
        {
            bool move = Attacker.Move(1);
            if (move)
            {
                bool hit = AAttackXY(1, 2, Attacker, Defender);
                if (hit)
                {
                    Defender.Hurt(Fighter.rangen.Next(3, 7));
                }
            }
        }

        public override void AttackFour(Fighter Attacker, Fighter Defender)
        {
            bool hit = AAttackXY(1, 1, Attacker, Defender);
            if (hit)
            {
                Defender.Hurt(Fighter.rangen.Next(5, 12));
            }
        }
    }
}
