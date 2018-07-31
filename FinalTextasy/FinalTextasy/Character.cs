using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTextasy
{
    class Character 
    {
        public int myHealth;
        public int myAttack;

        public Character(int health, int attack)
        {
            this.myHealth = health;
            this.myAttack = attack;
        }
        public void getAttacked(int monsteratk)
        {
            myHealth = myHealth - monsteratk;
        }


    }
}
