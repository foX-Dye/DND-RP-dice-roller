using System;

namespace dnd_CA_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu primaryMenu = new MainMenu();

            Console.WriteLine("Welcome to the RP dice roller. \nPlease select which dice to roll.");
            Console.WriteLine(primaryMenu.SelectionMenu());
        }
    }
}
