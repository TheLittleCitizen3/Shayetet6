using System;
using System.Collections.Generic;
using System.Linq;

namespace MissleLauncher.MissleLauncher
{
    class MissleLauncher : IMissleLauncher
    {
        public List<IMissle> MissleInventory { get ; set ; }
        public int MissleCount { get ; set ; }

        public void AddMissle(IMissle missle)
        {
            MissleInventory.Add(missle);
            MissleCount++;
            Console.WriteLine($"The Missle {missle.Missletype} was added");
        }

        public void MissleLaunch(string missleType, int missleCount)
        {
            if (ValidateMissleExist(missleType, missleCount))
            {
                
                for (int i = 0; i < missleCount; i++)
                {
                    var missleToLaunch = MissleInventory.SingleOrDefault(item => item.Missletype == missleType);
                    missleToLaunch.Launch();
                }
            }
            else
            {
                Console.WriteLine("There is not enough Missles to launch");
            }

        }

        public void PrintMissleCount()
        {
            Console.WriteLine($"There Are: {MissleCount} missles");
        }

        public void PrintMissleInventory()
        {
            int counter = 1;
            foreach(var missle in MissleInventory)
            {
                Console.WriteLine($"Missle number {counter}: {missle.Missletype}");
            }
        }
        private bool ValidateMissleExist(string missleType, int missleCount)
        {

            
            int count = MissleInventory.Where(missle => missle.Missletype == missleType).Count();
            if (count >= missleCount)
            {
                return true;
            }
            return false;

        }
    }
}
