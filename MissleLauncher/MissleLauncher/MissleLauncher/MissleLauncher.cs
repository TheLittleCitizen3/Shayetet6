using System;
using System.Collections.Generic;
using System.Linq;

namespace MissleLauncher.MissleLauncher
{
    class MissleLauncher : IMissleLauncher
    {
        public List<IMissle> MissleInventory { get ; set ; }
        public int MissleInventoryCount { get ; set ; }

        public MissleLauncher()
        {
            MissleInventory = new List<IMissle>();
            MissleInventoryCount = default;

        }

        public void AddMissle(IMissle missle)
        {
            MissleInventory.Add(missle);
            MissleInventoryCount++;
            Console.WriteLine($"The Missle {missle.Missletype} was added");
        }

        public void MissleLaunch(List<IMissle> MisslesToLaounch)
        {
            int countOfMissleToLaunch = MisslesToLaounch.Count();
            int countOfSuccessfulLaunch = default;
            foreach (var missle in MisslesToLaounch)
            {
                var missleInLauncher = MissleInventory.Find(m => m == missle);
                missleInLauncher.Launch();
                if (isLaunchedSuccessfully(missleInLauncher))
                {
                    countOfSuccessfulLaunch++;
                    MissleInventory.Remove(missleInLauncher);
                    MissleInventoryCount--;
                }

            }
            Console.WriteLine($"{countOfSuccessfulLaunch} Missles successfully fired out of: {countOfMissleToLaunch}");
        }

        public void PrintMissleCount()
        {
            Console.WriteLine($"There Are: {MissleInventoryCount} missles");
        }

        public void PrintMissleInventory()
        {
            int counter = 1;
            if (MissleInventory.Count == 0)
            {
                Console.WriteLine("there are no missles loaded");
            }
            foreach(var missle in MissleInventory)
            {
                Console.WriteLine($"Missle number {counter}: {missle.Missletype}");
            }
        }
        private bool isLaunchedSuccessfully(IMissle missle)
        {
            if (missle.MissleLaunched && missle.MissleLaunchChance == 0)
            {
                return false;
            }
            return true;
        }
    }
}
