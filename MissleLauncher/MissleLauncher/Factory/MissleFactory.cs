using MissleLauncher.Missles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Factory
{
    class MissleFactory
    {
        public Missle getMissle(string missleType)
        {
            switch (missleType)
            {
                case null:
                    return null;
                case "TORPEDO":
                    return new Missle("TORPEDO", 100);
                case "BALLISTIC":
                    return new Missle("BALLISTIC", 50);
                case "CRUISE":
                    return new Missle("CRUISE", 20);
                default:
                    return null;
            }
        }
    }
}
