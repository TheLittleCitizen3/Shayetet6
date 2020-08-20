using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MenuBuilder;
using MenuBuilder.menu;
using MissleLauncher.Factory;
using MissleLauncher.Menus.MainMenuF;
using MissleLauncher.Menus.validations;
using MissleLauncher.MissleLauncher;

namespace MissleLauncher.Menus
{
    class MainMenu
    {

        private StringMenu Menu;


        public MainMenu()
        {
            ///created the dictionery for action
            Dictionary<string, ITakeAction> ActionItems = new Dictionary<string, ITakeAction>();
            IMissleLauncher missleLauncher = new MissleLauncher.MissleLauncher();
            MissleFactory missleFactory = new MissleFactory();
            IMissleLauncherComputer missleLauncherComputer = new MissleLauncherComputer.MissleLauncherComputer(missleLauncher);
            ///create option 1 - add missle
            ITakeAction addMissle = new StoreNewMissle(missleFactory, missleLauncher);
            ActionItems.Add("1", addMissle);
            /// creating option 2 - launch missles
            ITakeAction LaunchMissles = new LaunchMissles(missleLauncherComputer);
            ActionItems.Add("2", LaunchMissles);
            /// creating option 3 - get report
            ITakeAction reportAction = new InventoryReportAction(missleLauncher);
            ActionItems.Add("3", reportAction);
            /// creating option 4 - remove missle
            ITakeAction removeMissle = new RemoveMissle(missleLauncher);
            ActionItems.Add("4", removeMissle);
            /// creating option 5 - exit program
            ITakeAction exitProgram = new ExitProgram();
            ActionItems.Add("5", exitProgram);
            ///creating list of validations
            List<IInputvalidation> inputvalidations = new List<IInputvalidation>() {new IntInputValidation(), new MainMenuValidation()};

            Menu = new StringMenu(ActionItems, inputvalidations);
        }

        public void Start()
        {
            while (true)
            {
                Menu.Start();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            
        }

    }
}
