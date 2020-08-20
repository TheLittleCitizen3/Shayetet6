using MenuBuilder.menu;
using MissleLauncher.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.validations
{
    class MissleStringValidation : IInputvalidation
    {
        private MissleFactory MissleFactory;

        public MissleStringValidation()
        {
            MissleFactory = new MissleFactory();
        }
        public bool Validate(string userInput)
        {
            if (MissleFactory.getMissle(userInput) == null)
            {
                return false;
            }
            return true;
        }
    }
}
