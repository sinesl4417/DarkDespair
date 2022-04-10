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
    public class Assets
    {
        public static Mob[] MobList = new Mob[5];

        public static void CreateMobs()
        {
            MobList[0] = new Mob("Infected Rat", 1, 0, 0);
            MobList[1] = new Mob("Green Troll", 20, 1, 1);
            MobList[2] = new Mob("Blue Troll", 50, 5, 2);
            MobList[3] = new Mob("Purple Troll", 100, 10, 4);
            MobList[4] = new Mob("Cyclops", 250, 20, 20);
        }

        public static void BuildWorld()
        {
            CreateMobs();
        }

        public static void BootUp()
        {
            Assets.BuildWorld();
            Lists.BuildLists();
            Assets.DisplayMainMenu();
        }

        public static string OptionErrorMessage()
        {
            return "ERROR: Enter a valid option";
        }

        public static string FileErrorMessage()
        {
            return "ERROR: Unable to load file";
        }

        public static void InProgress()
        {
            Console.WriteLine("Game still in progress...\nReturning to main menu...");
            Console.ReadLine();
            Assets.DisplayMainMenu();
        }

        public static void DisplayMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menus.MainMenu();
            }
        }

        public static void DisplayFilesMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menus.FilesMenu();
            }
        }

        public static string FirstName()
        {
            return Lists.CharacterInfoList.ElementAt(0);
        }

        public static string LastName()
        {
            return Lists.CharacterInfoList.ElementAt(1);
        }

        public static string Race()
        {
            return Lists.CharacterInfoList.ElementAt(2);
        }

        public static string CharacterName()
        {
            return Lists.CharacterInfoList.ElementAt(3);
        }

        public static void CreateCharacter()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText(@"C:\ddt\charInfo.txt");
            Console.WriteLine("Enter your first name: ");
            string fname = Console.ReadLine();
            outputFile.WriteLine(fname);
            Console.WriteLine("Enter your last name: ");
            string lname = Console.ReadLine();
            outputFile.WriteLine(lname);
            Console.WriteLine("Would you like to play as a human, orc, or elf?: ");
            string charrace = Console.ReadLine();
            do
            {
                if (charrace.ToLower() == "human")
                {
                    outputFile.WriteLine(charrace);
                    break;
                }

                if (charrace.ToLower() == "orc")
                {
                    outputFile.WriteLine(charrace);
                    break;
                }

                if (charrace.ToLower() == "elf")
                {
                    outputFile.WriteLine(charrace);
                    break;
                }

                else
                {
                    Assets.OptionErrorMessage();
                }
            } while (true);

            Console.WriteLine("Enter your character's name: ");
            string charname = Console.ReadLine();
            outputFile.WriteLine(charname);
            outputFile.Close();
            Console.WriteLine(fname + " " + lname + "'s character information: \nName: " + charname + "\nRace: " + charrace);
            Console.ReadLine();
            Assets.DisplayMainMenu();
        }

        public static void DisplayClassInfo()
        {
            StreamReader inputFile;
            string readClass;
            try
            {
                inputFile = File.OpenText(@"C:\ddt\class.txt");
                readClass = inputFile.ReadToEnd();
                Console.WriteLine("Class info:");
                Console.WriteLine(readClass);
                inputFile.Close();
            }
            catch (Exception)
            {
                Assets.FileErrorMessage();
            }
            Console.WriteLine();
        }

        public static void Test()
        {

        }

    }
}