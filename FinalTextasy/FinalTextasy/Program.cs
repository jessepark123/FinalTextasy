using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace FinalTextasy
{
    class Program 
    {
        static int CharAttack = 2;
        static int CharHealth = 3;

        static Character adv = new Character(CharHealth, CharAttack);
        static int RoomsCompleted = 0;
        static int wonBattle = 0;
        public static void setWindowSize(int width, int height) {
            Console.SetWindowSize(width, height);
        }
      
        public static void Main(String[] args)
        {
            setWindowSize(100, 50);
            ///displays opening 
            Console.WriteLine("Welcome adventurer, to the world of....");

        
            Console.Beep(740, 428);
            Console.Beep(659, 428);
            Console.Beep(740, 428);
            Console.Beep(659, 107);
            Console.Beep(880, 428);
            Console.Beep(880, 107);
            Console.Beep(830, 428);
            Console.Beep(880, 107);
            Console.Beep(830, 428);
            Console.Beep(830, 107);
            Console.Beep(740, 428);
            Console.Beep(659, 428);
            Console.Beep(622, 428);
            Console.Beep(659, 107);
            Console.Beep(554, 1714);
            Console.Beep(740, 428);
            Console.Beep(659, 428);
            Console.Beep(740, 428);
            Console.Beep(659, 107);
            Console.Beep(880, 428);
            Console.Beep(880, 107);
            Console.Beep(830, 428);
            Console.Beep(880, 107);
            Console.Beep(830, 428);
            Console.Beep(880, 107);
            Console.Beep(830, 428);
            Console.Beep(830, 107);
            Console.Beep(740, 428);
            Console.Beep(659, 428);
            Console.Beep(740, 428);
            Console.Beep(880, 107);
            Console.Beep(987, 1714);
            Thread.Sleep(500);




            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     ***** **                                    ***           ****           *                                                                         ");
            Console.WriteLine("  ******  **** *   *                              ***         *  *************                               *                                          ");
            Console.WriteLine(" **   *  *  ***   ***                              **        *     *********                                **                                          ");
            Console.WriteLine("*    *  *    *     *                               **        *     *  *                                     **                                          ");
            Console.WriteLine("    *  *                                           **        **   *  **                    ***    ***     ********               ****    **   ****      ");
            Console.WriteLine("   ** **        ***     ***  ****       ****      **             *  ***            ***    * ***  **** *  ********     ****      * **** *  **    ***  *  ");
            Console.WriteLine("   ** **          ***     **** **** *   * ***  *   **           **   **           * ***      *** *****      **       * ***  *  **  ****   **     ****   ");
            Console.WriteLine("   ** ******       **      **   ****   *   ****    **           **   **          *   ***      ***  **       **      *   ****  ****        **      **    ");
            Console.WriteLine("   ** *****        **      **    **   **    **     **           **   **         **    ***      ***          **     **    **     ***       **      **    ");
            Console.WriteLine("   ** **           **      **    **   **    **     **           **   **         ********      * ***         **     **    **       ***     **      **    ");
            Console.WriteLine("   *  **           **      **    **   **    **     **            **  **         *******      *   ***        **     **    **         ***   **      **    ");
            Console.WriteLine("      *            **      **    **   **    **     **             ** *      *   **          *     ***       **     **    **    ****  **   **      **    ");
            Console.WriteLine("  *****            **      **    **   **    **     **              ***     *    ****    *  *       *** *    **     **    **   * **** *     *********    ");
            Console.WriteLine(" *  *****          *** *   ***   ***   ***** **    *** *            *******      *******  *         ***      **     ***** **     ****        **** ***   ");
            Console.WriteLine("*    * **            ***     ***   ***   ***   **    ***              ***         *****                              ***   **                      ***  ");
            Console.WriteLine("*                                                                                                                                           *****   *** ");
            Console.WriteLine(" **                                                                                                                                       ********  **  ");
            Console.WriteLine("                                                                                                                                         *      ****    ");
            Thread.Sleep(1000);
           


            Console.WriteLine("You are a valiant knight tasked to steal the treasure from the evil dragon");
            Thread.Sleep(1000);
            Console.WriteLine("Will you be able to steal the treasure undetected?!?!");
            Thread.Sleep(1000);
            Console.WriteLine("Or are you going to slay the evil dragon and steal all the ladies' hearts");
            Thread.Sleep(1000);
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Press the enter key to attack and also progress through the dungeon."); 
            Console.WriteLine("Type 'run' to flee at the beginning of a fight!");
            Console.WriteLine("Press enter now to start the game");
            Console.WriteLine("*****************************************************************************");
            Console.ReadLine();


            Random obstacle = new Random(); //GENERATES THE TYPE OF EVENT
          
            while (adv.myHealth > 0)
            {
               
                while (RoomsCompleted < 15)
                {

                    switch (obstacle.Next(1, 4))
                    {
                        case 1:
                           
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("You have " + adv.myHealth + " health remaining!");
                            Console.WriteLine("You have " + adv.myAttack + " attack!");
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("Press enter to proceed to the next room!");
                            Console.WriteLine("====================================================================================");
                            
                            String input = Console.ReadLine();

                            Battle(adv); //CALLS BATTLE METHOD
                            Console.Clear();
                            RoomsCompleted++;

                            
                            break;
                        case 2:
                          
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("You have " + adv.myHealth + " health remaining!");
                            Console.WriteLine("You have " + adv.myAttack + " attack!");
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("Press enter to proceed to the next room!");
                            Console.WriteLine("====================================================================================");

                            Console.ReadLine();

                            

                            Equip(adv); //calls an equip
                           
                            RoomsCompleted++;
                           
                            break;
                        case 3:
                           
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("You have " + adv.myHealth + " health remaining!");
                            Console.WriteLine("You have " + adv.myAttack + " attack!");
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("====================================================================================");
                            Console.WriteLine("Press enter to proceed to the next room!");
                            Console.WriteLine("====================================================================================");

                            Console.ReadLine();

                            Trap(adv); //calls a trap
                            
                            RoomsCompleted++;

                            
                            break;
                    }
                    if (adv.myHealth <= 0)
                    {
                        Console.WriteLine("====================================================================================");
                        Console.WriteLine("You met an unfortunate demise! Press enter to end the adventure.");
                        Console.WriteLine("====================================================================================");           
                        Console.Beep(1760, 300);
                        Console.Beep(1397, 300);
                        Console.Beep(1175, 300);
                        Console.Beep(880, 300);
                        Console.Beep(698, 300);
                        Console.Beep(587, 300);
                        Console.Beep(440, 300);
                        Console.Beep(349, 500);
                        Console.Beep(220, 500);
                        Console.Beep(175, 2000);
                        Console.Beep(165, 3000);

                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
              
                if (RoomsCompleted == 15)
                {
                    BossBattle(adv);
                }
               
            }
        }

        public static void Battle(Character advtemp)
        {
            Random critchance = new Random();
            Random id = new Random();
            Enemy enemy = new Enemy(id.Next(1, 6)); //CREATES ENEMY
            string input = Console.ReadLine();
            if(input == "run")
            {
                enemy.myhealth = 0;
                wonBattle = 1;
                Console.WriteLine("You ran away!");
                Console.ReadLine();
            }
           
            while (enemy.myhealth > 0)
            {
                Console.WriteLine("====================================================================================");
                Console.WriteLine("The enemy does " + enemy.myatk + " damage!");
                adv.myHealth -= enemy.myatk;
                Console.ReadLine();
                Console.WriteLine("====================================================================================");
                Console.WriteLine("You retaliate with " + adv.myAttack + " damage!");
                switch(critchance.Next(1, 9))
                {
                    case 1:
                        Console.WriteLine("Critical Strike! You deal " + adv.myAttack * 1.5 + " damage!");
                        break;
                }
                enemy.myhealth -= adv.myAttack;
                Console.WriteLine("====================================================================================");
                Console.WriteLine("You have " + adv.myHealth + " health remaining!");
                Console.WriteLine("The enemy has " + enemy.myhealth + " health remaining!");
                Console.WriteLine("====================================================================================");
            }
            if(wonBattle == 0)
            {
                Console.WriteLine("You defeated the enemy and grabbed its loot!");
                Equip(adv);
              

                Console.Beep(1047, 53);
                Console.Beep(1047, 53);
                Console.Beep(1047, 53);
                Console.Beep(1047, 428);
                Console.Beep(784, 428);
                Console.Beep(987, 428);
                Console.Beep(1047, 107);
                Console.Beep(987, 107);
                Console.Beep(1047, 857);

            }
            wonBattle = 0;
        }
        public static void Equip(Character advtemp)
        {
            Random equip = new Random();
            switch (equip.Next(1, 6))
            {
                case 1:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("You found a worn iron sword! You Gain 2 Attack!");
                    Console.WriteLine("====================================================================================");
                    adv.myAttack += 2;
                    break;
                case 2:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("You found a sword glowing with magical light! You gain 3 Attack!");
                    Console.WriteLine("====================================================================================");
                    adv.myAttack += 3;
                    break;
                case 3:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("You found a leather-bound suit of armor! You gain 2 Health!");
                    Console.WriteLine("====================================================================================");
                    adv.myHealth += 2;
                    break;
                case 4:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("You found a chainmail suit of armor! You gain 3 Health!");
                    Console.WriteLine("====================================================================================");
                    adv.myHealth += 3;
                    break;
                case 5:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("You found a suit of armor that descended from the heavens itself! You gain 5 Health!");
                    Console.WriteLine("====================================================================================");
                    adv.myHealth += 5;
                    break;

                    
            }
        }
        public static void Trap(Character advtemp)
        {
            Random trap = new Random();
            switch(trap.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("A bunch of sharp metal spikes erupt from the ground! Lose 1 Health!");
                    Console.WriteLine("====================================================================================");
                    adv.myHealth -= 1;
                    break;
                case 2:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("Whoosh! A bunch of poison darts shoot past your face and hit you in the side! Lose 1 Health!");
                    Console.WriteLine("====================================================================================");
                    adv.myHealth -= 1;
                    break;
                case 3:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("Oh no! You stepped on a Lego piece! OW! Lose 2 Health!");
                    Console.WriteLine("====================================================================================");
                    adv.myHealth -= 2;
                    break;
                case 4:
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("A bunch of magical withering liquid falls on you from the ceiling! Lose 1 Attack!");
                    Console.WriteLine("====================================================================================");
                    adv.myAttack -= 1;
                    break;

                    
            }
           
        }
        public static void BossBattle(Character advtemp)
        {
            int bossHealth = 15;
            int bossAttack = 5;
            Console.WriteLine("====================================================================================");
            Console.WriteLine("You made it through the dungeon! However, you have now stepped into the Dragon's Lair!");
            Console.WriteLine("You try to sneak past quietly, however, the dragon sees you and awakes.");
            Console.WriteLine("There's only one way outta this! Press Enter to see what happens next!");
            Console.WriteLine("====================================================================================");
            Console.ReadLine();
            if(adv.myHealth <= 0)
            {
                Console.WriteLine("Next time battle more enemies to get more equipment, or just pray to rngesus...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            while (bossHealth > 0)
            {
                adv.myHealth -= bossAttack;
                bossHealth -= adv.myAttack;
                Console.WriteLine("====================================================================================");
                Console.WriteLine("You took " + bossAttack + " damage! You have " + adv.myHealth + " remaining!");
                Console.WriteLine("====================================================================================");
                Console.WriteLine("You stabbed the dragon for " + adv.myAttack + " damage!");
                Console.WriteLine("====================================================================================");
                Console.WriteLine("The dragon has " + bossHealth + " remaining!");
                Console.WriteLine("====================================================================================");
                Console.ReadLine();
            }
            if(bossHealth <= 0 && adv.myHealth > 0)
            {
                Console.WriteLine("====================================================================================");
                Console.WriteLine("You have slain the dragon, and have made it through the dungeon! Congratulations!");
                Console.WriteLine("====================================================================================");
                Console.Beep(1047, 53);
                Console.Beep(1047, 53);
                Console.Beep(1047, 53);
                Console.Beep(1047, 428);
                Console.Beep(784, 428);
                Console.Beep(987, 428);
                Console.Beep(1047, 107);
                Console.Beep(987, 107);
                Console.Beep(1047, 857);
                Console.Beep(740, 428);
                Console.Beep(659, 428);
                Console.Beep(740, 428);
                Console.Beep(659, 107);
                Console.Beep(880, 428);
                Console.Beep(880, 107);
                Console.Beep(830, 428);
                Console.Beep(880, 107);
                Console.Beep(830, 428);
                Console.Beep(830, 107);
                Console.Beep(740, 428);
                Console.Beep(659, 428);
                Console.Beep(622, 428);
                Console.Beep(659, 107);
                Console.Beep(554, 1714);
                Console.Beep(740, 428);
                Console.Beep(659, 428);
                Console.Beep(740, 428);
                Console.Beep(659, 107);
                Console.Beep(880, 428);
                Console.Beep(880, 107);
                Console.Beep(830, 428);
                Console.Beep(880, 107);
                Console.Beep(830, 428);
                Console.Beep(880, 107);
                Console.Beep(830, 428);
                Console.Beep(830, 107);
                Console.Beep(740, 428);
                Console.Beep(659, 428);
                Console.Beep(740, 428);
                Console.Beep(880, 107);
                Console.Beep(987, 1714);
                Console.ReadLine();
                Environment.Exit(0);
            }
            if(bossHealth <= 0 && adv.myHealth <= 0)
            {
                Console.WriteLine("'Twas a valiant effort, but unfortunately you died in the process of slaying the dragon!");
                Console.WriteLine("You get brownie points tho");
                Console.Beep(1760, 300);
                Console.Beep(1397, 300);
                Console.Beep(1175, 300);
                Console.Beep(880, 300);
                Console.Beep(698, 300);
                Console.Beep(587, 300);
                Console.Beep(440, 300);
                Console.Beep(349, 500);
                Console.Beep(220, 500);
                Console.Beep(175, 2000);
                Console.Beep(165, 3000);
                Console.ReadLine();
                Environment.Exit(0);
            }
          
        }


    }
}


