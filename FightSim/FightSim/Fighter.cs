using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {
        private static Random rangen = new Random();

        private int hp = 10;

        public string name = "";

        private List<string> npart1 = new List<string> {"", "Sir", "Lady", "Duke", "Slayer", "El", "Queen", "Emperor", "Cyber Naga", "Space Cop", "Grand", "Gargantuan", "Surfer", "Carpenter", "Dr." };

        private List<string> npart2 = new List<string> {"Gus", "Emi", "Elli", "Chi", "Rat", "Sau", "Jo", "Fri" , "Tur", "Hen", "Pet", "A", "Al", "Ali", "Gre", "Ic"};

        private List<string> npart3 = new List<string> { "tav", "la", "lo", "cho", "nor", "", "tle", "ce", "jo","da", "ma", "na", "er", "ry", "e", "ita", "aro", "ice", "g", "tai" };

        private List<string> npart4 = new List<string> { "The", "Del", "De La", "\"The\"", "The Super" };

        private List<string> npart5 = new List<string> { "Empress", "Bad", "Cruel", "Fluffy Dog", "Grandma", "[REDACTED]", "Unbreakable", "Sad", "Ultimate Weeb", "Breakable", "Forgettable", "YEET", "Big", "Grande", "Spinning", "Spicy", "Lad" };
        
        //constructor

        public Fighter()
        {
            name = npart1[rangen.Next(0,npart1.Count)]+ " "+ npart2[rangen.Next(0, npart2.Count)] + npart3[rangen.Next(0, npart3.Count)] + " " + npart4[rangen.Next(0, npart4.Count)]+ " " + npart5[rangen.Next(0, npart5.Count)];
        }


        //Attack-metoden anropas när slagskämpen ska attackera någon, och returnerar den mängd skada hjälten utdelar.
        public int Attack()
        {
            int damage = rangen.Next(1,11);
            return damage;
        }

        //Hurt-metoden anropas när slagskämpen ska bli skadad. Den tar emot en mängd skada som parameter.
        public void Hurt(int amount)
        {
            amount = Math.Abs(amount);
            hp -= amount;
            if (hp < 0) { hp = 0; }
        }

        //IsAlive anropas för att undersöka ifall slagskämpen har några hp kvar. Den returnerar true om så är fallet. Om det inte finns några hp kvar returneras false.
        public bool IsAlive()
        {
            bool alive = true;
            if (hp <= 0) { alive = false; }
            return alive;
        }

        //GetHp-metoden anropas för att undersöka hur många hp slagskämpen har kvar. Den returnerar slagskämpens nuvarande hp-värde.
        public int GetHp()
        {
            return hp;
        }

    }
}
