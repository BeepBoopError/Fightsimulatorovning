using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Weapon
    {

        //the name of the weapon
        protected string name;

        //the fighter that i wielding the weapon
        protected Fighter Owner;

        //setting the owner when the weapon is created
        public Weapon(Fighter WTemp)
        {
            Owner = WTemp;
        }
        
        //things that should be run at the start of the turn
        public virtual void TurnStarter()
        {

        }

        //things that should be run at the end of the turn
        public virtual void TurnEnder()
        {

        }

        //descriptions of the attacks the weapon has
        public virtual void AttackDescriptions()
        {
            Console.WriteLine("Attack descriptions");
        }

        //attack one
        public virtual void AttackOne(Fighter Attacker, Fighter Defender)
        {

        }

        //attack two
        public virtual void AttackTwo(Fighter Attacker, Fighter Defender)
        {

        }

        //attack three
        public virtual void AttackThree(Fighter Attacker, Fighter Defender)
        {

        }

        //attack four
        public virtual void AttackFour(Fighter Attacker, Fighter Defender)
        {

        }

        //Auto attack X/Y is a method to see if you hit when attacking, taking where to attack, who is attacking and who is being attacked as paramiters, and returning true if the fighter hits
        public bool AAttackXY(int x, int y, Fighter Attacker, Fighter Defender)
        {
            bool hit = false;

            if(Attacker.GetPos() + x == Defender.GetPos() || Attacker.GetPos() - x == Defender.GetPos())
            {
                if (Defender.defend != y)
                {
                    hit = true;
                }
            }


            return hit;
        }

    }
}
