using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.menu;
using Microsoft.Win32.SafeHandles;

namespace MissleLauncher.Menus.validations
{
    class MainMenuValidation : IInputvalidation
    {
        public bool Validate(string userInput)
        {
            int choice = int.Parse(userInput);
            return choice >= 3 && choice <= 3;
        }
    }
}
