using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Missles
{
    class Missle : IMissle
    {
        public string Missletype { get; set; }
        public int MissleLaunchChance { get ; set; }
        public bool MissleLaunched { get; set ; }

        public Missle(string MissleType, int MissleLaunchChance)
        {
            this.Missletype = MissleType;
            this.MissleLaunchChance = MissleLaunchChance;
        }

        public void Launch()
        {
            if (!MissleLaunchCalc())
            {
                MissleLaunchChance = 0;
            }
            MissleLaunched = true;
            
        }

        public bool MissleLaunchCalc()
        {
            Random rand = new Random();
            return rand.Next(100) <= MissleLaunchChance;
        }
    }
}
