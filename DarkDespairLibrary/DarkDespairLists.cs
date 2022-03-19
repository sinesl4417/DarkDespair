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
    public class DarkDespairLists
    {
        public static void BuildLists()
        {
            DarkDespairLists.Mobs();
            DarkDespairLists.Items();
            DarkDespairLists.Weapons();
            DarkDespairLists.Treasure();
            DarkDespairLists.Potions();
            DarkDespairLists.CharacterInfo();
        }

        public static List<string> MobList { get; set; } = new List<string>();
        public static List<string> ItemList { get; set; } = new List<string>();
        public static List<string> WeaponList { get; set; } = new List<string>();
        public static List<string> TreasureList { get; set; } = new List<string>();
        public static List<string> PotionsList { get; set; } = new List<string>();
        public static List<string> CharacterInfoList { get; set; } = new List<string>();
        public static List<string> Inventory { get; set; } = new List<string>();

        public static void Mobs()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText(@"C:\ddt\mobs.txt");
                while (inputFile.EndOfStream == false)
                {
                    MobList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                DarkDespairAssets.FileErrorMessage();
            }
        }

        public static void DisplayMobs()
        {
            Console.WriteLine("Mob List: ");
            foreach (string mob in MobList)
            {
                Console.WriteLine(mob);
            }
            Console.ReadLine();
        }

        public static void Items()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText(@"C:\ddt\items.txt");
                while (inputFile.EndOfStream == false)
                {
                    ItemList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                DarkDespairAssets.FileErrorMessage();
            }
        }

        public static void DisplayItems()
        {
            Console.WriteLine("Item List: ");
            foreach (string item in ItemList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void Weapons()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText(@"C:\ddt\weapons.txt");
                while (inputFile.EndOfStream == false)
                {
                    WeaponList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                DarkDespairAssets.FileErrorMessage();
            }
        }

        public static void DisplayWeapons()
        {
            Console.WriteLine("Weapon List: ");
            foreach (string weapon in WeaponList)
            {
                Console.WriteLine(weapon);
            }
            Console.ReadLine();
        }

        public static void Treasure()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText(@"C:\ddt\treasure.txt");
                while (inputFile.EndOfStream == false)
                {
                    TreasureList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                DarkDespairAssets.FileErrorMessage();
            }
        }

        public static void DisplayTreasure()
        {
            Console.WriteLine("Treasure List: ");
            foreach (string treasure in TreasureList)
            {
                Console.WriteLine(treasure);
            }
            Console.ReadLine();
        }

        public static void Potions()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText(@"C:\ddt\potions.txt");
                while (inputFile.EndOfStream == false)
                {
                    PotionsList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                DarkDespairAssets.FileErrorMessage();
            }
        }

        public static void DisplayPotions()
        {
            Console.WriteLine("Potions List: ");
            foreach (string potion in PotionsList)
            {
                Console.WriteLine(potion);
            }
            Console.ReadLine();
        }

        public static void CharacterInfo()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText(@"C:\ddt\charInfo.txt");
                while (inputFile.EndOfStream == false)
                {
                    CharacterInfoList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                DarkDespairAssets.FileErrorMessage();
            }
        }

        public static void DisplayCharacterInfo()
        {
            Console.WriteLine("Created Character Information: ");
            foreach (string info in CharacterInfoList)
            {
                Console.WriteLine(info);
            }
            Console.ReadLine();
        }


        public static void BuildInventory()
        {
            string race = CharacterInfoList.ElementAt(2);
            if (race.IndexOf("human", 0, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                Inventory.Add(WeaponList.ElementAt(2));
            }
            if (race.IndexOf("elf", 0, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                Inventory.Add(WeaponList.ElementAt(3));
            }
            if (race.IndexOf("orc", 0, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                Inventory.Add(WeaponList.ElementAt(1));
            }
            Inventory.Add(PotionsList.ElementAt(0));
        }
    }
}
