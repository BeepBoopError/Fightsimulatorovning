using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Knife : Weapon
    {
        //a character with a knife can evade, this keeps track of when they should stop evading
        private int evadeTimer = 0;

        //at the end of each turn, the evade timer should go time make sure that the evade expires
        public override void TurnEnder()
        {
            if (evadeTimer > 0)
            {
                evadeTimer--;
                Owner.evade = true;
            }
            else if (evadeTimer == 0)
            {
                Owner.evade = false;
            }
        }

        //constructor
        public Knife(Fighter WTemp) : base(WTemp)
        {
            Console.WriteLine("Knife Chosen");
        }

        //descriptions of the attacks
        public override void AttackDescriptions()
        {
            Console.WriteLine("1.  Stab");
            Console.WriteLine("   Medium damage, Hits middle 1 forward");

            Console.WriteLine("2.  Flurry");
            Console.WriteLine("   Light damage, Hits upper 1 forward -> Moves 2 forward -> Hits lower 1 forward");

            Console.WriteLine("3.  Bide time");
            Console.WriteLine("   Moves backwards 1, Adds Evade (Avoid incomming damage)");

            Console.WriteLine("4.  Backstab");
            Console.WriteLine("   High damage, Moves 3 forward -> Hits Lower 1 forward");
        }

        //the first attack simply attempts to hit the character infront of it in the middle area
        public override void AttackOne(Fighter Attacker, Fighter Defender)
        {
            bool hit = AAttackXY(1, 2, Attacker, Defender);
            if (hit)
            {
                Defender.Hurt(Fighter.rangen.Next(3,7));
            }
        }

        //this attack attacks upper, then moves to the other side of the character if that is successful, and then stabs again, this time lower
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

        //This attack isn't an attakc, rather it's tacticla move that allows you to defend from attacks, it moves the character away from the opponent and grants evade until the end of the next turn, making the character dodge damage, but not pushing or pulling
        public override void AttackThree(Fighter Attacker, Fighter Defender)
        {
            bool move = Attacker.Move(-1);
            if (move) { evadeTimer = 2; Attacker.evade = true; }
        }

        //This attack moves the character forward 3, intended to make them go around the opponent, and then attack for powerful damage
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
