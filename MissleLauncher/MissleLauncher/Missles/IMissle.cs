using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher
{
    interface IMissle : IMissleLaunchTech
    {
        string Missletype { get; set; }
        bool MissleLaunched { get; set; }
        public void Launch();
        public bool MissleLaunchCalc();

    }
}
