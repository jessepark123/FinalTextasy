using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTextasy
{
    public class Enemy 
    {
        public int myatk;
        public int myhealth;

    public Enemy(int ID)
        {
            CreateEnemy(ID);
        }
        public void CreateEnemy(int ID)
        {
         
            switch (ID)
            {
                case 1:
                    Console.WriteLine("You encountered a spooky scary skeleton with 2 Health and 1 Attack! If you wish to run, do so now before it is too late!");
                    Skeleton spooks = new Skeleton(2, 1);
                    myatk = spooks.Attack(1);
                    myhealth = spooks.Health(2);
                    break;

                case 2:
                    Console.WriteLine("A flurry of wings flapping brings your sights to a bunch of dangerous-looking bats with 2 health and 1 attack! If you wish to run, do so now before it is too late!");
                    Bats flyer = new Bats(2, 1);
                    myatk = flyer.Attack(1);
                    myhealth = flyer.Health(2);
                    break;

                case 3:
                    Console.WriteLine("A big doggo attacks you with 3 Health and 2 Attack! If you wish to run, do so now before it is too late!");
                    Wolf puppy = new Wolf(3, 2);
                    myatk = puppy.Attack(2);
                    myhealth = puppy.Health(3);
                    break;

                case 4:
                    Console.WriteLine("A bunch of rats scurry towards you...be careful, they have 2 Health and 1 Attack...and might also have rabies. If you wish to run, do so now before it is too late!");
                    Rats vermin = new Rats(2, 1);
                    myatk = vermin.Attack(1);
                    myhealth = vermin.Health(2);
                    break;

                case 5:
                    Console.WriteLine("A big scary goblin comes around the corner brandishing a club! He is a tough guy, with 4 Health and 3 Attack! If you wish to run, do so now before it is too late!");
                    Goblins brute = new Goblins(4, 3);
                    myatk = brute.Attack(3);
                    myhealth = brute.Health(4);
                    break;
            }

        }







    }
}

