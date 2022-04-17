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
    public class Lists
    {
        public static void BuildLists()
        {
            BuildItems();
            BuildTreasure();
            BuildWeapons();
            BuildMobs();
            BuildPlayer();
            BuildRooms();
        }

        #region Build Lists
        public static void BuildItems()
        {
            using (StreamReader reader = File.OpenText("items.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int ID = int.Parse(reader.ReadLine());
                    string Name = reader.ReadLine();
                    string Description = reader.ReadLine();
                    int Price = int.Parse(reader.ReadLine());
                    bool Required = bool.Parse(reader.ReadLine());
                    bool Equippable = bool.Parse(reader.ReadLine());
                    World.Items.Add(new Item(ID, Name, Description, Price, Required, Equippable));
                }
            }
        }

        public static void BuildTreasure()
        {
            using (StreamReader reader = File.OpenText("treasure.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int ID = int.Parse(reader.ReadLine());
                    string Name = reader.ReadLine();
                    string Description = reader.ReadLine();
                    int Price = int.Parse(reader.ReadLine());
                    bool Required = bool.Parse(reader.ReadLine());
                    bool Equippable = bool.Parse(reader.ReadLine());
                    World.Treasures.Add(new Treasure(ID, Name, Description, Price, Required, Equippable));
                }
            }
        }

        public static void BuildWeapons()
        {
            using (StreamReader reader = File.OpenText("weapons.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int ID = int.Parse(reader.ReadLine());
                    string Name = reader.ReadLine();
                    string Description = reader.ReadLine();
                    int Price = int.Parse(reader.ReadLine());
                    int Damage = int.Parse(reader.ReadLine());
                    bool Required = bool.Parse(reader.ReadLine());
                    bool Equippable = bool.Parse(reader.ReadLine());
                    World.Weapons.Add(new Weapon(ID, Name, Description, Price, Damage, Required, Equippable));
                }
            }
        }

        public static void BuildMobs()
        {
            using (StreamReader reader = File.OpenText("mobs.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int ID = int.Parse(reader.ReadLine());
                    string Name = reader.ReadLine();
                    string Desc = reader.ReadLine();
                    int CHP = int.Parse(reader.ReadLine());
                    int MHP = int.Parse(reader.ReadLine());
                    int ATK = int.Parse(reader.ReadLine());
                    int DEF = int.Parse(reader.ReadLine());
                    Weapon MW = null;
                    List<Item> MI = null;
                    bool LS = bool.Parse(reader.ReadLine());
                    bool CA = bool.Parse(reader.ReadLine());
                    World.Mobs.Add(new Mob(ID, Name, Desc, CHP, MHP, ATK, DEF, MW, MI, LS, CA));
                }
            }
        }

        public static void BuildPlayer()
        {
            using (StreamReader reader = File.OpenText("character.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int ID = int.Parse(reader.ReadLine());
                    string Name = reader.ReadLine();
                    string Desc = reader.ReadLine();
                    int CHP = int.Parse(reader.ReadLine());
                    int MHP = int.Parse(reader.ReadLine());
                    int ATK = int.Parse(reader.ReadLine());
                    int DEF = int.Parse(reader.ReadLine());
                    Weapon MW = null;
                    List<Item> MI = null;
                    bool LS = bool.Parse(reader.ReadLine());
                    bool CA = bool.Parse(reader.ReadLine());
                    World.Players.Add(new Player(ID, Name, Desc, CHP, MHP, ATK, DEF, MW, MI, LS, CA));
                }
            }
        }

        public static void BuildRooms()
        {
            using (StreamReader reader = File.OpenText("rooms.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int ID = int.Parse(reader.ReadLine());
                    string Name = reader.ReadLine();
                    string Description = reader.ReadLine();
                    int Exits = int.Parse(reader.ReadLine());
                    int N = int.Parse(reader.ReadLine());
                    int E = int.Parse(reader.ReadLine());
                    int S = int.Parse(reader.ReadLine());
                    int W = int.Parse(reader.ReadLine());
                    World.Rooms.Add(new Room(ID, Name, Description, Exits, N, E, S, W));
                }
            }
        }

        #endregion

    }
}
