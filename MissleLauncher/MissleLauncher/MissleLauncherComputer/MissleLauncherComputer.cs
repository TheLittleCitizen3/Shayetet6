using MissleLauncher.Missles;
using MissleLauncher.MissleLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissleLauncher.MissleLauncherComputer
{
    class MissleLauncherComputer : IMissleLauncherComputer
    {
        public IMissleLauncher MissleLauncher { get ; set ; }

        public MissleLauncherComputer(IMissleLauncher missleLauncher)
        {
            MissleLauncher = missleLauncher;
        }

        public bool CheckMissleQunatity(string misslesToLaounch, int numOfMissles)
        {
            int count = MissleLauncher.MissleInventory.Where(missle => missle.Missletype == misslesToLaounch).Count();
            if (count >= numOfMissles)
            {
                return true;
            }
            return false;
        }

        public void LaounchAllMissles()
        {
            MissleLauncher.MissleLaunch(MissleLauncher.MissleInventory.ToList());
        }

        public void LaunchMissles(string misslesToLaounch, int numOfMissles)
        {
            if (CheckMissleQunatity(misslesToLaounch, numOfMissles))
            {

                var missleToLaunchList = MissleLauncher.MissleInventory.Where(missle => missle.Missletype == misslesToLaounch).Take(numOfMissles).ToList();
                MissleLauncher.MissleLaunch(missleToLaunchList);
            }
            else
            {
                Console.WriteLine("There is not enough Missles to launch");
            }
        }
    }
}
