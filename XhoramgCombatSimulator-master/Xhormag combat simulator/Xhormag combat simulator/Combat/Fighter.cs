using System;

namespace Xhormag_combat_simulator
{
    public class Fighter
    {
        private int mAbility;
        private int mEndurence;
        private int mDamage;
        private int mArmor;
        private readonly int criticalWound;
        private bool criticalWeakness;

        public Fighter(int pAbility, int pDamage, int pArmor, int pEndurence)
        {
            SetAbility(pAbility);
            SetEndurence(pEndurence);
            SetDamage(pDamage);
            SetArmor(pArmor);
            if (pEndurence <= 120)
            {
                criticalWound = 12;
            } 
            if (pEndurence > 120)
            {
                criticalWound = pEndurence / 10;
            }
        }

        public int SetAbility(int ability) => mAbility = ability;
        public int SetEndurence(int endurence) => mEndurence = endurence;
        public int SetDamage(int damage) => mDamage = damage;
        public int SetArmor(int armor) => mArmor = armor;
        public bool SetCriticalWeakness(bool trueFalse) => criticalWeakness = trueFalse;
        public int GetAbility() => mAbility;
        public int GetEndurence() => mEndurence;
        public int GetDamage() => mDamage;
        public int GetArmor() => mArmor;
        public int GetCriticalWound() => criticalWound;
        public bool GetCriticalWeakness() => criticalWeakness;
    }
}