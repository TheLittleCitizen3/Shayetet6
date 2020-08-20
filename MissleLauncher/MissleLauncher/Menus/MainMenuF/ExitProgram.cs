using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.MainMenuF
{
    class ExitProgram : ITakeAction
    {
        public string ActionName { get; set; }

        public ExitProgram()
        {
            ActionName = "5. Exit Program";
        }

        public void Act()
        {
            Console.WriteLine("GG WP");
            System.Environment.Exit(1);
        }
    }
}
