using System;
using System.Collections.Generic;
using System.Text;

namespace XoramagInterface
{
    public class Armor
    {
        //Armor members
        private readonly string mArmorName;
        private readonly string mArmorType;
        private readonly int mChestArmorValue;
        private readonly int mShieldArmorValue;

        public Armor(string pName, string pArmorType, int pArmorValue)
        {
            mArmorName = pName;
            mArmorType = pArmorType;
            switch (pArmorType)
            {
                case "Chest":
                    mChestArmorValue = pArmorValue;
                    break;
                case "Shield":
                    mShieldArmorValue = pArmorValue;
                    break;
                default:
                    mShieldArmorValue = 0;
                    mChestArmorValue = 0;
                    break;
            }
        }
        public string GetArmorName() => mArmorName;
        public string GetArmorType() => mArmorType;
        public int GetChestArmorValue() => mChestArmorValue;
        public int GetShieldArmorValue() => mShieldArmorValue;
    }
}