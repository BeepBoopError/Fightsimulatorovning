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
