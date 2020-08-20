using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Missles
{
    class LongRangeMissle : Missle
    {
        public LongRangeMissle(string MissleType, int MissleLaunchChance)
            :base(MissleType, MissleLaunchChance)
        {

        }
        public override bool MissleLaunchCalc()
        {
            Console.WriteLine("Enter Missle Distance: (0-1500)");
            string userInput = Console.ReadLine();
            int distance;
            while (!int.TryParse(userInput,out distance) && (distance > 1500 || distance < 0))
            {
                Console.WriteLine("Enter valid number (0 - 15000)");
                userInput = Console.ReadLine();
            }

            double hitChance = ((1 - ((double)distance / 1500)) * 100);
            Random rand = new Random();
            return rand.Next(1,100) <= hitChance;

        }
    }
}
