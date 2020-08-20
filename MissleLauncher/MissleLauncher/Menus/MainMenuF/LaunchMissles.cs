using MenuBuilder;
using MenuBuilder.menu;
using MissleLauncher.Menus.validations;
using MissleLauncher.MissleLauncher;
using MissleLauncher.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.MainMenuF
{
    class LaunchMissles : ITakeAction
    {
        public string ActionName { get ; set ; }
        private IMissleLauncherComputer MissleLauncherComputer;
        List<IInputvalidation> validations;

        public LaunchMissles(IMissleLauncherComputer missleLauncherComputer)
        {
            ActionName = "2. Launch Missles";
            MissleLauncherComputer = missleLauncherComputer;
            validations = new List<IInputvalidation>() { new MissleStringValidation(), new IntInputValidation() };
        }
        public void Act()
        {
            string misslesList = Resources.misslesList;
            Console.WriteLine($"Enter Missle Type ({misslesList}):");
            string missleType = Console.ReadLine().ToUpper();
            while (!validations[0].Validate(missleType))
            {
                Console.WriteLine("Please enter valid missle type");
                missleType = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Enter Number of {missleType} missles to launch:");
            string missleToLaunchString = Console.ReadLine();
            while (!validations[1].Validate(missleToLaunchString))
            {
                Console.WriteLine("Please Enter valid number greater than 0");
                missleToLaunchString = Console.ReadLine();
            }
            int misslesToLaunch = int.Parse(missleToLaunchString);
            MissleLauncherComputer.LaunchMissles(missleType, misslesToLaunch);
        }
    }
}
