using MenuBuilder;
using MenuBuilder.menu;
using MenuBuilder.menu.Validations;
using MissleLauncher.Menus.validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.MainMenuF
{
    class RemoveMissle : ITakeAction
    {
        public string ActionName { get; set; }
        private IMissleLauncher MissleLauncher;
        private List<IInputvalidation> validations;

        public RemoveMissle(IMissleLauncher missleLauncher)
        {
            ActionName = "4. Remove Missle";
            MissleLauncher = missleLauncher;
            validations = new List<IInputvalidation>() { new MissleIndexValidation(missleLauncher), new AllMissleInputValidation() };
        }



        public void Act()
        {
            Console.WriteLine("Press ENTER to REMOVE ALL MISSLES or press the index number of the missle to remove (greater than 0)");
            string userInput = Console.ReadLine();
            while ((!validations[0].Validate(userInput)) && (!validations[1].Validate(userInput)))
            {
                Console.WriteLine("The Index does Not exist or bad input");
                userInput = Console.ReadLine();
            }
            if (userInput == "")
            {
                MissleLauncher.RemoveAllMissles();
            }
            else
            {
                MissleLauncher.RemoveMissle(int.Parse(userInput) - 1);
            }
        }
    }
}

