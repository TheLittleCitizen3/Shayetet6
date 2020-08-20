using MenuBuilder;
using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissleLauncher.Menus.MainMenuF
{
    class InventoryReportAction : ITakeAction
    {
        public string ActionName { get; set; }
        private IMissleLauncher missleLauncher;

        public InventoryReportAction(IMissleLauncher missleLauncher)
        {
            ActionName = "3. Inventory Report";
            this.missleLauncher = missleLauncher;
        }
        public void Act()
        {
            missleLauncher.PrintMissleInventory();
        }
    }
}
