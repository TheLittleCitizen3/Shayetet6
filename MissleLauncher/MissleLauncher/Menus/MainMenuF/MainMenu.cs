using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MenuBuilder;
using MenuBuilder.menu;
using MissleLauncher.Menus.MainMenuF;
using MissleLauncher.Menus.validations;
using MissleLauncher.MissleLauncher;

namespace MissleLauncher.Menus
{
    class MainMenu
    {

        public StringMenu Menu{ get; set; }

        //TODO: create ITakeAction for MAIN MENU
        //TODO: create validation class for menu int input

        public MainMenu()
        {
            ///created the dictionery for action
            IMissleLauncher missleLauncher = new MissleLauncher.MissleLauncher();
            ITakeAction reportAction = new InventoryReportAction(missleLauncher);
            string Option3 = "3";
            Dictionary<string, ITakeAction> ActionItems = new Dictionary<string, ITakeAction>();
            ActionItems.Add(Option3, reportAction);
            ///creating list of validations
            List<IInputvalidation> inputvalidations = new List<IInputvalidation>() {new IntInputValidation(), new MainMenuValidation()};

            Menu = new StringMenu(ActionItems, inputvalidations);
        }

        public void start()
        {
            Menu.Start();
        }

    }
}
