using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator
{
    class GameData
    {
        private readonly Inventory mInventory;
        private readonly PlayerStatBlock mStats;
        
        public GameData()
        {
            Inventory pPlayerInventeory = new Inventory();
            mInventory = pPlayerInventeory;
            PlayerStatBlock pStats = new PlayerStatBlock(pPlayerInventeory);
            mStats = pStats;
            
        }

        public Inventory GetPlayerInventory() => mInventory;
        public PlayerStatBlock GetStats() => mStats; 

    }
}
