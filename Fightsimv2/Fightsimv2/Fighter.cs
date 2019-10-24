using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsimv2
{
    class Fighter
    {
        //hitpoints som fightern har
        protected int hp;

        //hur bra fightern är på att parrera attacker minimivärde och maximifärde
        protected int[] evade;

        //hur träffsäker fightern är
        protected int baseToHit;

        //vart fightern står
        protected int position;

        //hur mycket skada kraktären kan blockera, minimi och maximi värde
        protected int[] armor;

        //om karktären lever
        protected bool alive = true;

        //list på namn en random fiende skulle kunna anta, static, men kan vara icke static ifall jag vil göra olika namn för olika sorters fiender.
        public static List<string> namesList = new List<string> { "Ummn", "Ylv", "Uulv", "Hult", "Vilt", "Vittnar" };

        //namnet fightern har
        public string name;

        //om karaktären bör randomly genereras
        public bool random = false;

        //en random generator, static
        protected static Random rangen = new Random();

        //the opponent they are fighting
        protected Fighter opponent;

        //the weapon they are wielding
        protected Weapon weapon;

        //constructor
        public Fighter()
        {
            //generera ett random namn
            if (random)
            {
                name = namesList[rangen.Next(0, namesList.Count)];
            }
        }

        //när fightern tar skada.
        public virtual void Hurt(int damage)
        {
            damage -= rangen.Next(armor[0], armor[1] + 1);

            if (damage < 0 ) { damage = 0; }

            hp -= damage;
            if (hp <= 0 ) { alive = false; }
        }

        //attackerar en en fiende overidas för att använda vapen
        public virtual void Attack()
        {
            opponent.Hurt(1);
        }

        //hämta positionen av karaktären
        public int GetPos()
        {
            return position;
        }

        //flyttar karaktären, vissa attacker kommer dels att flytta karaktären, och det utgår altid från vart fiende karaktären är, så att forwards är mot karaktöern och backwards är från finenden
        public virtual bool Move(int amount)
        {
            bool success = true;

            if (opponent.GetPos() > position)
            {
                position += amount;
            }
            else
            {
                position -= amount;
            }

            if (position <= 0 || position >= 7)
            {
                success = false;
                Console.WriteLine(name + " falls off! ");
                alive = false;
            }

            if (position == opponent.position)
            {
                success = false;
                Console.WriteLine(name + " stumbles!");
                Move(rangen.Next(0, 3) - 1);
            }


            return success;
        }

    }
}
