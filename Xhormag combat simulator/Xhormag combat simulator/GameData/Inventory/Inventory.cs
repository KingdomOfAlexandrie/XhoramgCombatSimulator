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

        public void AddToWeapon(int listNumber)
        {
            switch (listNumber)
            {
                //Weapon
                case 0:
                    Console.WriteLine("What is the weapon name?");
                    string weaponName = Console.ReadLine();
                    Console.WriteLine("What is the weapon ability bonus?");
                    
                    Console.WriteLine("What is the weapon damage bonsu?");

                    break;
                default:
                    break;

            }
        }
        public List<Weapon> GetWeaponList() => mWeaponList;
        public void AddToArmor(Armor armor) => mArmorList.Add(armor);
        public List<Armor> GetArmorList() => mArmorList;
        public void AddToMisc(Misc misc) => mMiscList.Add(misc);
        public List<Misc> GetMiscList() => mMiscList;
    }
}
