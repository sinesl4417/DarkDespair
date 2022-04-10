/**
* 3-19-2022
* CSC 153
* Logan Sines
* Text Adventure Game
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DarkDespairLibrary
{
    public class Menus
    {
        public static bool MainMenu()
        {
            Console.WriteLine("1. Create Character");
            Console.WriteLine("2. Play Dark Despair");
            Console.WriteLine("3. Display Files");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Assets.CreateCharacter();
                    return false;
                case "2":
                    Game.PlayDarkDespair();
                    return true;
                case "3":
                    Assets.DisplayFilesMenu();
                    return true;
                case "4":
                    Environment.Exit(0);
                    return false;
                default:
                    Assets.OptionErrorMessage();
                    return true;
            }
        }

        public static bool FilesMenu()
        {
            Console.WriteLine("1. Display Class Info");
            Console.WriteLine("2. Display Created Character Info");
            Console.WriteLine("3. Display Mob Info");
            Console.WriteLine("4. Display Item Info");
            Console.WriteLine("5. Display Weapon Info");
            Console.WriteLine("6. Display Treasure Info");
            Console.WriteLine("7. Return to Main Menu");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Assets.DisplayClassInfo();
                    return true;
                case "2":
                    Lists.DisplayCharacterInfo();
                    return true;
                case "3":
                    Lists.DisplayMobs();
                    return true;
                case "4":
                    Lists.DisplayItems();
                    return true;
                case "5":
                    Lists.DisplayWeapons();
                    return true;
                case "6":
                    Lists.DisplayTreasure();
                    return true;
                case "7":
                    Assets.DisplayMainMenu();
                    return true;
                case "8":
                    Environment.Exit(0);
                    return false;
                default:
                    Assets.OptionErrorMessage();
                    return true;
            }
        }
    }
}
