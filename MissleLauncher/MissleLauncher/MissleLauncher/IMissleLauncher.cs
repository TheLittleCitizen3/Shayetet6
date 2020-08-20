using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher
{
    interface IMissleLauncher
    {
        public List<IMissle> MissleInventory { get; set; }
        public int MissleInventoryCount { get; set; }
        public void MissleLaunch(List<IMissle> MissleToLaunch);
        public void PrintMissleInventory();
        public void PrintMissleCount();
        public void AddMissle(IMissle missle);
    }
}
