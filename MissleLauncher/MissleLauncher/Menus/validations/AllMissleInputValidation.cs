using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.validations
{
    class AllMissleInputValidation : IInputvalidation
    {
        public bool Validate(string userInput)
        {
            if (userInput == "")
            {
                return true;
            }
            return false;
        }
    }
}
