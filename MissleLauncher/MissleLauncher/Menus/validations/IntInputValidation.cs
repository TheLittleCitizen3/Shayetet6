﻿using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.validations
{
    class IntInputValidation : IInputvalidation
    {
        public bool Validate(string userInput)
        {
            int num;
            if (!int.TryParse(userInput, out num))
            {
                return false;
            }
            if (num <= 0)
            {
                return false;
            }
            return true;

        }
    }
}
