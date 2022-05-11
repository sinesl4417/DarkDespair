using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DarkDespairLibrary
{
    public class World
    {
        #region Object Lists
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Weapon> Weapons = new List<Weapon>();
        public static readonly List<Treasure> Treasures = new List<Treasure>();
        public static readonly List<Potion> Potions = new List<Potion>();
        public static readonly List<Mob> Mobs = new List<Mob>();
        public static readonly List<Player> Players = new List<Player>();
        public static readonly List<Room> Rooms = new List<Room>();
        #endregion

        public static void CreateCharacter()
        {
            //Will add race, class, etc, I just want to get things working.
            StreamWriter OutputFile;
            OutputFile = File.CreateText("character.txt");
            OutputFile.WriteLine("1");
            Console.WriteLine("Enter character name: ");
            OutputFile.WriteLine(Console.ReadLine());
            Console.WriteLine("Creating character...");
            OutputFile.WriteLine("Your player.");
            OutputFile.WriteLine("100");                    //defeault starting value
            OutputFile.WriteLine("100");                    //defeault starting value
            OutputFile.WriteLine("1");                      //defeault starting value
            OutputFile.WriteLine("1");                      //defeault starting value
            OutputFile.WriteLine("0");                      //defeault starting value
            OutputFile.WriteLine("false");
            OutputFile.WriteLine("false");
            OutputFile.Close();
        }
    }
}