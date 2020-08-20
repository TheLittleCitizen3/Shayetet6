using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.MissleLauncher
{
    interface IMissleLauncherComputer
    {
        public IMissleLauncher MissleLauncher { get; set; }
        public void LaunchMissles(string misslesToLaounch, int numOfmissles);
        public void LaounchAllMissles(string totalWarString);
        public bool CheckMissleQunatity(List<IMissle> misslesToCheck);
    }
}
