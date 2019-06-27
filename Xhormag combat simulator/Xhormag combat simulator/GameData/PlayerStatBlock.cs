using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator
{
    public class PlayerStatBlock
    {
        private int mAbility;
        private int mNaturalAbility;
        private int mEndurence;
        private int mDamage;
        private int mArmor;

        private int bestWeaponRatio = 0;
        private int bestWeaponPostionInList = 0;
        private int bestChestArmorValue = 0;
        private int bestChestArmorPositionInList = 0;
        private int bestShieldArmorValue = 0;
        private int bestShieldArmorPositionInList = 0;

        public PlayerStatBlock(Inventory inventory)
        {
            //Set natural ability
            mNaturalAbility = Program.StringToInt("What is the player natural ability?");
            //Set Endurence 
            mEndurence = Program.StringToInt("What is the Player endurence?");
            //Refresh
            Refresh(inventory);   
        }
        public void Refresh(Inventory inventory)
        {
            //Iterate trought inventory

            int numberOfIteration = inventory.GetWeaponList().Count;

            if (numberOfIteration > 0)
            {

                //Best weapon in inventory
                for (int iteration = 0; iteration < numberOfIteration; iteration++)
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
                for (int iteration = 0; iteration < numberOfIteration; iteration++)
                {
                    if (inventory.GetArmorList()[iteration].GetChestArmorValue() > bestChestArmorValue)
                    {
                        bestChestArmorValue = inventory.GetArmorList()[iteration].GetChestArmorValue();
                        bestChestArmorPositionInList = iteration;
                    }
                }

                //Best Shield in inventory

                for (int iteration = 0; iteration < numberOfIteration; iteration++)
                {
                    if (inventory.GetArmorList()[iteration].GetShieldArmorValue() > bestShieldArmorValue)
                    {
                        bestShieldArmorValue = inventory.GetArmorList()[iteration].GetChestArmorValue();
                        bestShieldArmorPositionInList = iteration;
                    }
                }
            }
            //Set stats

            //Set ability (Nat + weapon)
            
            if (inventory.GetWeaponList().Count > 0)
            {
                mAbility = mNaturalAbility + inventory.GetWeaponList()[bestWeaponPostionInList].GetWeaponAbilityBonus();
            }
            else
            {
                mAbility = mNaturalAbility;
            }


            

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
            else if (bestShieldArmorValue > 0)
            {
                mArmor = inventory.GetArmorList()[bestShieldArmorPositionInList].GetShieldArmorValue();
            }
            else
            {
                mArmor = 0;
            }
        }
        public int GetAbility() => mAbility;
        public int GetEndurence() => mEndurence;
        public int GetArmor() => mArmor;
        public int GetDamage() => mDamage;
        
    }
}
