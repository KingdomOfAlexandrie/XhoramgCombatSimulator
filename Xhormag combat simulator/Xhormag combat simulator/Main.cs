﻿using System;
using System.Collections.Generic;

namespace Xhormag_combat_simulator
{
    public class Program
    {
        private const int MAX_ENEMY_COUNT = 5;
        private static int numberEnemy = 0;
        static void Main(string[] args)
        {
            string winner = "";
            //Create the gameData
            GameData PlayerData = new GameData();

            //Inventory test

            //Create the fighter
            string fighterName = "Player";
            Fighter Player = new Fighter(PlayerData.GetStats().GetAbility(), PlayerData.GetStats().GetDamage(), PlayerData.GetStats().GetArmor(), PlayerData.GetStats().GetEndurence());
            PrintStats(Player, fighterName);

            while (true)
            {
                Console.Clear();
                bool endOfCombat = false;


                //Create the enemies
                int numberEnemy = NumberOfEnemy();

                //Create a list of enemy
                List<Fighter> Enemy = new List<Fighter>();
                if(numberEnemy > 0 && numberEnemy < MAX_ENEMY_COUNT)
                {
                    for (int enemyGenerator = 0; enemyGenerator < numberEnemy; enemyGenerator++)
                    {
                        fighterName = "enemy" + (enemyGenerator + 1);
                        Enemy.Add(GetFighter(fighterName));
                    }
                }

                //Start the combat
                while (endOfCombat == false)
                {                    
                    int totalEndurenceOfAllEnemies = 0;
                    for (int activeEnemy = 0; activeEnemy < numberEnemy; activeEnemy++)
                    {
                        if (Enemy[activeEnemy].GetEndurence() > 0)
                        {
                            Assault(Player, Enemy[activeEnemy], (activeEnemy + 1));
                            if (Enemy[activeEnemy].GetEndurence() < 0)
                            {
                                Enemy[activeEnemy].SetEndurence(0);
                            }
                            PrintCombat(Player, "Player");
                            Console.WriteLine();
                            PrintCombat(Enemy[activeEnemy], "Enemy " + (activeEnemy + 1));
                            Console.ReadLine();
                            Console.Clear();

                            totalEndurenceOfAllEnemies += Enemy[activeEnemy].GetEndurence();
                        }
                    }

                    if (totalEndurenceOfAllEnemies <= 0 || Player.GetEndurence() <= 0)
                    {
                        if(Player.GetEndurence() <= 0)
                        {
                            winner = "Enemies";
                        }
                        else
                        {
                            winner = "Player";
                        }
                        endOfCombat = true;
                    }
                }

                //Winner and next combat
                Console.WriteLine("The winner of the combat is the " + winner);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Combat finished, press on the enter key to start another combat");
                Console.ReadLine();
            } 

        }

        private static Fighter GetFighter(string figtherName)
        {
            return new Fighter(NewFighterAbility(figtherName), NewFighterDamage(figtherName), NewFighterArmor(figtherName), NewFighterEndurence(figtherName));
        }
        private static void Assault(Fighter Player, Fighter Enemy, int enemyNumber)
        {
            short[,] damageGrid =
        {
            {1,2,2,3,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,20,22,24,26,28,30,40},                                //0 
            {-8,1,1,2,2,3,4,5,6,7,7,8,9,10,11,12,13,14,15,16,18,20,22,24,26,28,38},                                 //1
            {-9,-7,1,1,2,2,3,4,5,6,6,7,7,8,9,10,11,12,14,15,17,18,20,22,24,26,36},                                  //2
            {-10,-8,-6,-5,1,1,2,2,4,4,5,5,6,6,7,8,10,11,13,14,16,17,19,20,22,24,34},                                //3
            {-11,-9,-7,-6,-5,-4,1,1,3,3,4,4,5,5,6,7,9,10,12,13,15,16,18,19,21,22,32},                               //4
            {-12,-10,-8,-7,-6,-5,-4,-3,2,2,3,3,4,4,5,6,8,9,11,12,14,15,17,18,20,21,30},                             //5
            {-13,-11,-9,-8,-7,-6,-5,-4,-3,-2,2,2,3,3,4,5,7,8,20,11,13,14,16,17,19,20,28},                           //6
            {-14,-12,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,2,2,3,4,6,7,9,10,12,13,15,16,18,19,26},                         //7
            {-15,-13,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,-1,2,3,5,6,8,9,11,12,14,15,17,18,24},                       //8
            {-16,-14,-12,-11,-10,-9,-8,-7,-6,5,-4,-3,-2,-2,-1,-1,4,5,7,8,10,11,13,14,16,17,22},                     //9
            {-17,-15,-13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-3,-2,-2,-1,-1,6,7,9,10,12,13,15,16,20},                  //10
            {-18,-16,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-4,-3,-3,-2,-2,-1,-1,8,9,11,12,14,15,18},                //11
            {-19,-17,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-5,-4,-4,-3,-3,-2,-2,-1,-1,10,11,13,14,17},             //12
            {-21,-18,-17,-16,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-5,-4,-4,-3,-2,-2,-2,-1,-1,12,13,16},           //13
            {-23,-20,-19,-18,-17,-16,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-5,-4,-3,-3,-2,-2,-2,-1,-1,15},         //14
            {-25,-22,-21,-20,-19,-18,-17,-16,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-4,-3,-3,-2,-2,-1,-1}        //15
        };


            bool criticalHit = false;
            int damage = DamageRoll(AbilityDiffrence(Player, Enemy));
            if (damage > 0)
            {
                //player deals damage
                Enemy.SetEndurence(Enemy.GetEndurence() - (damage - Enemy.GetArmor() + Player.GetDamage()));
                //apply critical wound rules
                CriticalWoundRules(Enemy, damage);
                HitText("Player");
            }
            else
            {
                //player receive damage
                damage = damage * -1;
                Player.SetEndurence(Player.GetEndurence() - (damage - Player.GetArmor() + Enemy.GetDamage()));
                //apply critical wound rules
                CriticalWoundRules(Player, (damage * -1));
                HitText("Enemy" + enemyNumber);

            }

            void CriticalWoundRules(Fighter Fighter, int damageDealt)
            {
                //Critical damage
                if (damageDealt >= Fighter.GetCriticalWound())
                {
                    Fighter.SetAbility(Fighter.GetAbility() - (damageDealt / Fighter.GetCriticalWound()));
                    criticalHit = true;
                }

                //Critical Weakness
                if (Fighter.GetEndurence() < Fighter.GetCriticalWound() && Fighter.GetCriticalWeakness() == false)
                {
                    Fighter.SetCriticalWeakness(true);
                    Fighter.SetAbility(Fighter.GetAbility() - 1);
                }
            }

            void HitText(string Fighter)
            {
                if (criticalHit == true)
                {
                    Console.WriteLine("Critical hit from the {0} he dealt {1} damage", Fighter, damage);
                    criticalHit = false;
                }
                else
                {
                    Console.WriteLine("Hit from the {0} he dealt {1} damage", Fighter, damage);
                }
                Console.ReadLine();
            }

            int DamageRoll(int abilityDifference) //cant handle greater diffrence than 13 in ability
            {
                int[] criticalHitDamage = { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5 };
                int roll = Random();
                int damageDealt = damageGrid[roll, abilityDifference];           //Deal if the difference in ability is to large
                if (roll == 0)
                {
                    damageDealt += criticalHitDamage[Random()];
                }
                return damageDealt;

                int Random()
                {
                    Random random = new Random();
                    return random.Next(0, 15);
                }
            }
            
        }
        private static int AbilityDiffrence(Fighter Player, Fighter Enemy)
        {
            int abilityDiffrence;

            if ((13 + (Player.GetAbility() - Enemy.GetAbility()) > 27))
            {
                abilityDiffrence = 27;
            }
            if ((13 + (Player.GetAbility() - Enemy.GetAbility()) < 0))
            {
                abilityDiffrence = 0;
            }
            else
            {
                abilityDiffrence = 13 + (Player.GetAbility() - Enemy.GetAbility());
            }
            return abilityDiffrence;
        }
        public static void PrintStats(Fighter Fighter, string FighterName)
        {
            Console.Clear();
            Console.WriteLine(FighterName);
            Console.WriteLine("Ability: " + Fighter.GetAbility());
            Console.WriteLine("Damage: " + Fighter.GetDamage());
            Console.WriteLine("Armor: " + Fighter.GetArmor());
            Console.WriteLine("Endurence: " + Fighter.GetEndurence());
            Console.WriteLine("Critical wound : " + Fighter.GetCriticalWound());
            Console.ReadLine();
            Console.Clear();
        }
        public static void PrintCombat(Fighter Fighter, string FighterName)
        {
            Console.WriteLine(FighterName);
            Console.WriteLine("Ability: " + Fighter.GetAbility());
            Console.WriteLine("Endurence: " + Fighter.GetEndurence());
        }        
        private static int NewFighterAbility(string figtherCategory)
        {
            return StringToInt("What is the " + figtherCategory + " ability?");
        }
        private static int NewFighterEndurence(string figtherCategory)
        {
            return StringToInt("What is the " + figtherCategory + " endurence?");
        }
        private static int NewFighterDamage(string figtherCategory)
        {
            return StringToInt("What is the " + figtherCategory + " damage?");
        }
        private static int NewFighterArmor(string figtherCategory)
        {
            return StringToInt("What is the " + figtherCategory + " armor?");
        }
        public static int StringToInt(string question)
        {
            int parsedValue = 0;
            int count = 0;
            Console.WriteLine(question);
            while (true)

                if (int.TryParse(Console.ReadLine(), out parsedValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    if (++count >= 3)
                    {
                        Console.WriteLine("You failed to many times.");
                        Environment.Exit(0);
                    }
                }
            return parsedValue;
        }
        private static int NumberOfEnemy()
        {
            int count = 0;
            int numberEnemy = 0;
            while (true)
            {
                numberEnemy = StringToInt("How many enemy(ies) are you facing?");
                if (numberEnemy > 0 && numberEnemy < MAX_ENEMY_COUNT)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    if (++count >= 3)
                    {
                        Console.WriteLine("You failed to many times.");
                        Environment.Exit(0);
                    }
                }
            }
            return numberEnemy;
        }
    }
}