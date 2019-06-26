using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator
{
    public class PlayerStatBlock
    {
        private readonly int mAbility;
        private readonly int mNaturalAbility;
        private readonly int mEndurence;
        private readonly int mDamage;
        private readonly int mArmor;

        private int bestWeaponRatio = 0;
        private int bestWeaponPostionInList = 0;
        private int bestChestArmorValue = 0;
        private int bestChestArmorPositionInList = 0;
        private int bestShieldArmorValue = 0;
        private int bestShieldArmorPositionInList = 0;

        public PlayerStatBlock(Inventory inventory)
        {
            //Refresh
            Refresh(inventory);
            //Set stats

            //Set ability (Nat + weapon)
            mNaturalAbility = StringToInt("What is the player natural ability?");
            if (inventory.GetWeaponList().Count > 0)
            {
                mAbility = mNaturalAbility + inventory.GetWeaponList()[bestWeaponPostionInList].GetWeaponAbilityBonus();
            }
            else
            {
                mAbility = mNaturalAbility;
            }    
           

            //Set Endurence 
            mEndurence = StringToInt("What is the Player endurence?"); ;

            //Set Damage
            if (inventory.GetWeaponList().Count > 0)
            {
                mDamage = inventory.GetWeaponList()[bestWeaponPostionInList].GetWeaponDamageBonus();
            }
            else
            {
                mDamage = 0;
            }

            //Set Armor
            if (bestChestArmorValue > 0 && bestShieldArmorValue > 0)
            {
                mArmor = inventory.GetArmorList()[bestChestArmorPositionInList].GetChestArmorValue() + inventory.GetArmorList()[bestShieldArmorPositionInList].GetShieldArmorValue();
            }
            else if (bestChestArmorValue > 0)
            {
                mArmor = inventory.GetArmorList()[bestChestArmorPositionInList].GetChestArmorValue();
            }
            else if(bestShieldArmorValue > 0)
            {
                mArmor = inventory.GetArmorList()[bestShieldArmorPositionInList].GetShieldArmorValue();
            }
            else
            {
                mArmor = 0;
            }   
        }
        private void Refresh(Inventory inventory)
        {
            //Iterate trought inventory

            int numberOfIteration = inventory.GetWeaponList().Count;

            if (numberOfIteration > 0)
            {

                //Best weapon in inventory
                for (int iteration = 0; iteration <= numberOfIteration; iteration++)
                {
                    int weaponAbility = inventory.GetWeaponList()[iteration].GetWeaponAbilityBonus();
                    int weaponDamage = inventory.GetWeaponList()[iteration].GetWeaponDamageBonus();
                    if (weaponAbility * weaponDamage > bestWeaponRatio)
                    {
                        bestWeaponRatio = weaponAbility * weaponDamage;
                        bestWeaponPostionInList = iteration;
                    }
                }
            }
            numberOfIteration = inventory.GetArmorList().Count;

            if (numberOfIteration > 0)
            {
                //Best chestArmor in inventory
                for (int iteration = 0; iteration <= numberOfIteration; iteration++)
                {
                    if (inventory.GetArmorList()[iteration].GetChestArmorValue() > bestChestArmorValue)
                    {
                        bestChestArmorValue = inventory.GetArmorList()[iteration].GetChestArmorValue();
                        bestChestArmorPositionInList = iteration;
                    }
                }

                //Best Shield in inventory

                for (int iteration = 0; iteration <= numberOfIteration; iteration++)
                {
                    if (inventory.GetArmorList()[iteration].GetShieldArmorValue() > bestShieldArmorValue)
                    {
                        bestShieldArmorValue = inventory.GetArmorList()[iteration].GetChestArmorValue();
                        bestShieldArmorPositionInList = iteration;
                    }
                }
            }
        }
        public int GetAbility() => mAbility;
        public int GetEndurence() => mEndurence;
        public int GetArmor() => mArmor;
        public int GetDamage() => mDamage;
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
    }
}
