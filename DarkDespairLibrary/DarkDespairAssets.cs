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
    public class DarkDespairAssets
    {
        public static void BootUp()
        {
            DarkDespairLists.BuildLists();
            DarkDespairAssets.DisplayOpeningMenu();
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
            DarkDespairAssets.DisplayOpeningMenu();
        }

        public static void DisplayOpeningMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = DarkDespairMenus.OpeningMenu();
            }
        }

        public static void DisplayFilesMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = DarkDespairMenus.FilesMenu();
            }
        }

        public static string FirstName()
        {
            return DarkDespairLists.CharacterInfoList.ElementAt(0);
        }

        public static string LastName()
        {
            return DarkDespairLists.CharacterInfoList.ElementAt(1);
        }

        public static string Race()
        {
            return DarkDespairLists.CharacterInfoList.ElementAt(2);
        }

        public static string CharacterName()
        {
            return DarkDespairLists.CharacterInfoList.ElementAt(3);
        }

        public static string CharCreationWarning()
        {
            return "If you have not created a character, you will be given the default names.";
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
                    DarkDespairAssets.OptionErrorMessage();
                }
            } while (true);

            Console.WriteLine("Enter your character's name: ");
            string charname = Console.ReadLine();
            outputFile.WriteLine(charname);
            outputFile.Close();
            Console.WriteLine(fname + " " + lname + "'s character information: \nName: " + charname + "\nRace: " + charrace);
            Console.ReadLine();
            DarkDespairAssets.DisplayOpeningMenu();
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
                DarkDespairAssets.FileErrorMessage();
            }
            Console.WriteLine();
        }

        public static void Test()
        {

        }

    }
}