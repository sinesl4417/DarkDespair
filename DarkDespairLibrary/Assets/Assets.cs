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
        public static void BootGame()
        {
            World.CreateCharacter();
            Lists.BuildLists();
            Game.Start();
        }

        public static string InProgress()
        {
            return "ERROR: Game still in progress...\nClosing program...";
        }

        public static string OptionErrorMessage()
        {
            return "ERROR: Enter a valid option";
        }

        public static string FileErrorMessage()
        {
            return "ERROR: Unable to load file";
        }

        public static void Test() //method used to test things and make sure they're working properly
        {
            Console.WriteLine(World.Rooms[0].ID);
            Console.WriteLine(World.Rooms[0].Name);
            Console.WriteLine(World.Rooms[0].Description);
            Console.WriteLine(World.Rooms[0].North);
            Console.WriteLine(World.Rooms[0].East);
            Console.WriteLine(World.Rooms[0].South);
            Console.WriteLine(World.Rooms[0].West);
            Console.WriteLine(World.Rooms[0].Exits);
            int TestInt = World.Rooms[0].Exits + World.Rooms[0].Exits;
            Console.WriteLine(TestInt);
            Console.ReadKey();
        }

    }
}