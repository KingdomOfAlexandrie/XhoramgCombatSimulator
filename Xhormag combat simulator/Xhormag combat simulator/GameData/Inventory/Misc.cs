using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator
{
    public class Misc
    {
        //Miscellaneous members
        private readonly string mMiscellaneousName;
        private readonly string mDescription;
        private readonly int mVolume;
        

        public Misc(string pName, string pDescription, int pVolume)
        {
            mMiscellaneousName = pName;
            mVolume = pVolume;
        }

        //Miscellaneous getter
        public string MiscellaneousName() => mMiscellaneousName;
        public string GetDescription() => mDescription;
        public int GetVolume() => mVolume;
    }
}