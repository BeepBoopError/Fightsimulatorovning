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
            Console.WriteLine("   Light damage, Hits middle 2 forward -> Knocks back 3");
        }

        public override void AttackOne(Fighter Attacker, Fighter Defender)
        {
            bool hit1 = AAttackXY(1, 2, Attacker, Defender);
            bool hit2 = AAttackXY(2, 2, Attacker, Defender);

            if(hit1 || hit2)
            {
                Defender.Hurt(Fighter.rangen.Next(2, 6));
                Defender.Move(-1);
            }
        }

        public override void AttackTwo(Fighter Attacker, Fighter Defender)
        {
            bool hit1 = AAttackXY(1, 3, Attacker, Defender);
            bool hit2 = AAttackXY(2, 1, Attacker, Defender);
            if (hit1 || hit2)
            {
                Defender.Hurt(Fighter.rangen.Next(3, 7));
                Attacker.Move(-1);
                Defender.Move(-1);
            }

        }

        public override void AttackThree(Fighter Attacker, Fighter Defender)
        {
            bool move = Attacker.Move(3);
            if (move)
            {
                bool hit = AAttackXY(1, 3, Attacker, Defender);
                if (hit)
                {
                    Defender.Move(-3);
                }
            }
        }

        public override void AttackFour(Fighter Attacker, Fighter Defender)
        {
            bool hit = AAttackXY(2, 2, Attacker, Defender);
            if (hit)
            {
                Defender.Hurt(Fighter.rangen.Next(2, 6));
                Defender.Move(-3);
            }
        }


    }
}
