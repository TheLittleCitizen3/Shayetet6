using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.validations
{
    class MissleIndexValidation : IInputvalidation
    {
        private IMissleLauncher MissleLauncher;
        private int IndexToCheck;
        

        public MissleIndexValidation(IMissleLauncher missleLauncher)
        {
            MissleLauncher = missleLauncher;
            
        }
        public bool Validate(string userInput)
        {

            if (!int.TryParse(userInput, out IndexToCheck))
            {
                return false;
            }
            if (IndexToCheck > MissleLauncher.MissleInventory.Count || IndexToCheck < 0)
            {
                return false;
            }
            return true;
        }
    }
}
