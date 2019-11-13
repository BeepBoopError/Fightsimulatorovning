using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Weapon
    {
        protected string name;


        public virtual void TurnStarter()
        {

        }

        public virtual void TurnEnder()
        {

        }

        public virtual void AttackDescriptions()
        {
            Console.WriteLine("Attack descriptions");
        }

        public virtual void AttackOne(Fighter Attacker, Fighter Defender)
        {

        }

        public virtual void AttackTwo(Fighter Attacker, Fighter Defender)
        {

        }

        public virtual void AttackThree(Fighter Attacker, Fighter Defender)
        {

        }

        public virtual void AttackFour(Fighter Attacker, Fighter Defender)
        {

        }

        public bool AAttackXY(int x, int y, Fighter Attacker, Fighter Defender)
        {

        }

    }
}
