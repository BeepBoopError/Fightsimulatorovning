using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Weapon
    {
        /*
             _ 11|21|
            |A|12|22|
            ---13|23|

        */
        //the name of the weapon
        protected string name;

        //the fighter that i wielding the weapon
        protected Fighter Owner;

        //The fighter the owner is fighting
        protected Fighter Opponent;


        //setting the owner when the weapon is created
        public Weapon(Fighter WTemp)
        {
            Owner = WTemp;
            Opponent = Owner.GetOpp();
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
        public virtual void AttackOne()
        {

        }

        //attack two
        public virtual void AttackTwo()
        {

        }

        //attack three
        public virtual void AttackThree()
        {

        }

        //attack four
        public virtual void AttackFour()
        {

        }

        //Auto attack X/Y is a method to see if you hit when attacking, taking where to attack, who is attacking and who is being attacked as paramiters, and returning true if the fighter hits
        protected bool AAttackXY(int x, int y)
        {
            bool hit = false;

            if(Owner.GetPos() + x == Opponent.GetPos() || Owner.GetPos() - x == Opponent.GetPos())
            {
                if (Opponent.defend != y)
                {
                    hit = true;
                    Console.WriteLine(Owner.name +" hits!");
                }
                else
                {
                    Console.WriteLine(Opponent.name + " defends!");
                }
            }


            return hit;
        }

        //get thename of the weapon
        public string GetName()
        {
            return name; 
        }

    }
}
