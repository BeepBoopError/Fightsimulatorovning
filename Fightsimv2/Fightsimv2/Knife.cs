using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Knife : Weapon
    {
        private int evadeTimer = 0;

        public override void TurnEnder()
        {
            if (evadeTimer > 0)
            {
                evadeTimer--;
                //FIND A WAY TO GET THE FIGHTER WEILDING THE WEAPON
            }
            else if (evadeTimer == 0)
            {
                //FIND A WAY TO GET THE FIGHTER WIELDING THE WEAPON
            }
        }

        public Knife()
        {
            Console.WriteLine("Knife Chosen");
        }

        public override void AttackDescriptions()
        {
            Console.WriteLine("1.  Stab");
            Console.WriteLine("   Medium damage, Hits middle 1 forward");

            Console.WriteLine("2.  Flurry");
            Console.WriteLine("   Light damage, Hits upper 1 forward -> Moves 2 forward -> Hits lower 1 forward");

            Console.WriteLine("3.  Bide time");
            Console.WriteLine("   Moves Backwards 1, Adds Evade (Avoid incomming damage)");

            Console.WriteLine("4.  Backstab");
            Console.WriteLine("   High damage, Moves 3 forward -> Hits Lower 1 forward");
        }

        public override void AttackOne(Fighter Attacker, Fighter Defender)
        {
            bool hit = AAttackXY(1, 2, Attacker, Defender);
            if (hit)
            {
                Defender.Hurt(Fighter.rangen.Next(3,7));
            }
        }

        public override void AttackTwo(Fighter Attacker, Fighter Defender)
        {
            bool hit = AAttackXY(1, 3, Attacker, Defender);
            if (hit)
            {
                Defender.Hurt(Fighter.rangen.Next(2, 6));
                bool move = Attacker.Move(2);
                if (move)
                {
                    bool hit2 = AAttackXY(1, 1, Attacker, Defender);
                    if(hit2)
                    {
                        Defender.Hurt(Fighter.rangen.Next(2, 6));
                    }
                }
            }
        }

        public override void AttackThree(Fighter Attacker, Fighter Defender)
        {
            bool move = Attacker.Move(-1);
            if (move) { evadeTimer = 2; Attacker.evade = true; }
        }

        public override void AttackFour(Fighter Attacker, Fighter Defender)
        {
            bool move = Attacker.Move(3);
            if (move)
            {
                bool hit = AAttackXY(1, 1, Attacker, Defender);
                if (hit)
                {
                    Defender.Hurt(Fighter.rangen.Next(5, 12));
                }
            }
        }
    }
}
