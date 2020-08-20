using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.validations
{
    class IntInputValidation : IInputvalidation
    {
        public bool Validate(string userInput)
        {
            return int.TryParse(userInput, out int num);
        }
    }
}
