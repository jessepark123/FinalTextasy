using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTextasy
{
    class Wolf 
    {
        int myhealth;
        int myattack;

        public Wolf(int health, int attack)
        {
            this.myhealth = health;
            this.myattack = attack;

        }
        public int Attack(int attack)
        {
            attack = myattack;
            return attack;

        }
        public int Health(int health)
        {
            health = myhealth;
            return health;

        }
    }
}

