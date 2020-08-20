using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher
{
    interface IMissleLauncher
    {
        public List<IMissle> MissleInventory { get; set; }
        public int MissleCount { get; set; }
        public void MissleLaunch(string missleType, int missleCount);
        public void PrintMissleInventory();
        public void PrintMissleCount();
        public void AddMissle(IMissle missle);
    }
}
