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
    public class DarkDespairMenus
    {
        public static bool OpeningMenu()
        {
            Console.WriteLine("1. Create Character");
            Console.WriteLine("2. Play Dark Despair");
            Console.WriteLine("3. Display Files");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    DarkDespairAssets.createCharacter();
                    return false;
                case "2":
                    DarkDespairGame.PlayDarkDespair();
                    return true;
                case "3":
                    DarkDespairAssets.DisplayFilesMenu();
                    return true;
                case "4":
                    Environment.Exit(0);
                    return false;
                default:
                    DarkDespairAssets.OptionErrorMessage();
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
            Console.WriteLine("7. Display Potion Info");
            Console.WriteLine("8. Return to Main Menu");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    DarkDespairAssets.DisplayClassInfo();
                    return true;
                case "2":
                    DarkDespairLists.DisplayCharacterInfo();
                    return true;
                case "3":
                    DarkDespairLists.DisplayMobs();
                    return true;
                case "4":
                    DarkDespairLists.DisplayItems();
                    return true;
                case "5":
                    DarkDespairLists.DisplayWeapons();
                    return true;
                case "6":
                    DarkDespairLists.DisplayTreasure();
                    return true;
                case "7":
                    DarkDespairLists.DisplayPotions();
                    return true;
                case "8":
                    DarkDespairAssets.DisplayOpeningMenu();
                    return true;
                case "9":
                    Environment.Exit(0);
                    return false;
                default:
                    DarkDespairAssets.OptionErrorMessage();
                    return true;
            }
        }
    }
}
