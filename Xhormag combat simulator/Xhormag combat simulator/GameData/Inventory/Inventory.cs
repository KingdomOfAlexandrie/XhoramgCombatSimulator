using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator
{
    public class Inventory
    {
        private readonly List<Weapon> mWeaponList;
        private readonly List<Armor> mArmorList;
        private readonly List<Misc> mMiscList;
        
        public Inventory()
        {
            mWeaponList = new List<Weapon>();
            mArmorList = new List<Armor>();
            mMiscList = new List<Misc>();
        }

        public void AddToInventory()
        {
            int listNumber = Program.StringToInt("What kind of item do you want to Add? (0: Weapon, 1: Armor, 2: Misc");
            switch (listNumber)
            {
                //Weapon
                case 0:
                    Console.WriteLine("What is the weapon name?");
                    string weaponName = Console.ReadLine();

                    int weaponAbilityBonus = Program.StringToInt("What is the ability bonus of the weapon?");

                    int weaponDamageBonus = Program.StringToInt("What is the damage bonus of the weapon");

                    mWeaponList.Add(new Weapon(weaponName, weaponAbilityBonus, weaponDamageBonus));
                    break;
                default:
                    break;

            }
        }
        public List<Weapon> GetWeaponList() => mWeaponList;
        public List<Armor> GetArmorList() => mArmorList;
        public List<Misc> GetMiscList() => mMiscList;
    }
}
