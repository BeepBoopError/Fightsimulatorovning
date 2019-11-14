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
            Console.WriteLine("   Medium damage, Moves forward 1 -> Hits upper 1 forwards -> Pulls 3");
        }


        public override void AttackOne(Fighter Attacker, Fighter Defender)
        {
            bool move = Attacker.Move(1);
            if (move)
            {
                bool hit1 = AAttackXY(1, 2, Attacker, Defender);
                bool hit2 = AAttackXY(2, 2, Attacker, Defender);
                if(hit1 || hit2)
                {
                    Defender.Hurt(Fighter.rangen.Next(3, 7));
                }
            }
        }

        public override void AttackTwo(Fighter Attacker, Fighter Defender)
        {
            bool hit1 = AAttackXY(1, 1, Attacker, Defender);
            bool hit2 = AAttackXY(2, 1, Attacker, Defender);

            if (hit1 || hit2)
            {
                Defender.Hurt(Fighter.rangen.Next(3, 7));
            }
        }

        public override void AttackThree(Fighter Attacker, Fighter Defender)
        {
            bool hit = AAttackXY(1, 3, Attacker, Defender);
            if (hit)
            {
                Defender.Hurt(Fighter.rangen.Next(2, 6));
                bool hit2 = AAttackXY(1, 2, Attacker, Defender);
                if (hit2)
                {
                    Defender.Hurt(Fighter.rangen.Next(3, 7));
                    bool hit3 = AAttackXY(1, 1, Attacker, Defender);
                    if (hit3)
                    {
                        Defender.Hurt(Fighter.rangen.Next(5, 12));
                    }
                }
            }
        }

        public override void AttackFour(Fighter Attacker, Fighter Defender)
        {
            bool move = Attacker.Move(1);
            if (move)
            {
                bool hit = AAttackXY(1, 3, Attacker, Defender);
                if (hit)
                {
                    Defender.Hurt(Fighter.rangen.Next(3, 7));
                    Defender.Move(3);
                }
            }
        }
    }
}
