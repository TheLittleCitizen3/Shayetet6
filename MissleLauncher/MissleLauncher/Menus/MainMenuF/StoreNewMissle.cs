using MenuBuilder;
using MissleLauncher.Factory;
using MissleLauncher.Menus.validations;
using MissleLauncher.Missles;
using MissleLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Resources;
using System.Text;


namespace MissleLauncher.Menus.MainMenuF
{
    class StoreNewMissle : ITakeAction
    {
        public string ActionName { get; set; }
        private MissleFactory MissleFactory;
        private IMissleLauncher MissleLauncher;
        private string MissleType;
        private MissleStringValidation validation;

        public StoreNewMissle(MissleFactory missleFactory, IMissleLauncher missleLauncher )
        {
            ActionName = "1. Add Missle";
            MissleFactory = missleFactory;
            MissleLauncher = missleLauncher;
            MissleType = default;
            validation = new MissleStringValidation();
        }
        public void Act()
        {
            string misslesList = Resources.misslesList;
            Console.WriteLine($"Enter The Missle Type To Add: ({misslesList})");
            MissleType = Console.ReadLine().ToUpper();
            while (!validation.Validate(MissleType))
            {
                Console.WriteLine("Please enter valid missle type:");
                MissleType = Console.ReadLine().ToUpper();
            }
            Missle missle = MissleFactory.getMissle(MissleType);
            MissleLauncher.AddMissle(missle);
        }
    }
}
