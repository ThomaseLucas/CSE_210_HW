using System;
namespace Develop04
{
    class Menu
    {
        private string _userinput;

        public int DisplayMenu()
        {
            Console.WriteLine("Menu Options: \n1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit");
            Console.Write("Select a choice from the menu: ");
            _userinput = Console.ReadLine();
            int userInputInt = int.Parse(_userinput);
            return userInputInt;

        }
    }
}