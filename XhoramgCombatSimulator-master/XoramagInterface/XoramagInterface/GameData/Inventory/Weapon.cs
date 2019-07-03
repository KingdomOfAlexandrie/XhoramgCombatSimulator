using System;
using System.Collections.Generic;
using System.Text;

namespace XoramagInterface
{
    public class Weapon
    {
        //Weapon members
        private readonly string mWeaponName;
        private readonly int mAbilityBonus;
        private readonly int mDamageBonus;

        public Weapon(string pName, int pAbiltityBonus, int pDamageBonus)
        {
            mWeaponName = pName;
            mAbilityBonus = pAbiltityBonus;
            mDamageBonus = pDamageBonus;
        }

        //Weapon getter
        public string GetWeaponName() => mWeaponName;
        public int GetWeaponAbilityBonus() => mAbilityBonus;
        public int GetWeaponDamageBonus() => mDamageBonus;
    }
}
