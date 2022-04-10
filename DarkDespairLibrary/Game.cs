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
    public class Game
    {
        public static void PlayDarkDespair()
        {
            Lists.BuildInventory();
            string userInput;
            Console.WriteLine("You wake up in a dark, damp room... \nYou feel vegetation on the walls.\nYou find what feels to be a lantern of sorts... light it? (Y/N): ");
            userInput = Console.ReadLine();
            do
            {
                if (userInput.ToLower() == "y")
                {
                    Game.PrisonOpening();
                }

                if (userInput.ToLower() == "n")
                {
                    Console.WriteLine("You choose the to remain in the dark.\nYou drift back to sleep...\nYou feel something large grab you, then a sharp, intense pain, then everything fades away...\nGAME OVER");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("ERROR: Enter a valid option");
                    Console.ReadLine();
                    Game.PlayDarkDespair();
                }

            } while (true);
        }

        public static void PrisonOpening()
        {
            string userInput;
            Console.WriteLine("The lantern flickers on. You see you are in a small, cavernous room with an iron bar door.\nYou see a Blue Troll passed out in front of the door with a key ring at its side.\nGrab the key and free yourself? (Y/N): ");
            userInput = Console.ReadLine();
            do
            {
                if (userInput.ToLower() == "y")
                {
                    Console.WriteLine("Leaving your cell leads you to a larger room.");
                    Console.WriteLine("You see your belongings, which include a backpack with one health potion in it and your " + Lists.Inventory.ElementAt(0) + ".");
                    Console.WriteLine("You grab your things and exit the cell...");
                    Lists.Inventory.Add(Lists.ItemList.ElementAt(1));
                    Console.WriteLine(Lists.ItemList.ElementAt(1) + " was added to your backpack.");
                    Console.WriteLine();
                    Game.StartingRoom();

                }

                if (userInput.ToLower() == "n")
                {
                    Console.WriteLine("You stand in your cell, awaiting futher judgement.\nA large Red Troll walks by your cell, mistaking the passed out Blue Troll as a consequence of your actions, then swiftly stabs you in the heart.\nYou drift away...\nGAME OVER");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("ERROR: Enter a valid option");
                    Console.ReadLine();
                    Game.PrisonOpening();
                }

            } while (true);
        }

        public static void StartingRoom()
        {
            string userInput;
            Console.WriteLine("You see four doors. One to the north, south, east, and west. Which door do you choose to go through? (N/E/S/W): ");
            userInput = Console.ReadLine();
            do
            {
                if (userInput.ToLower() == "n")
                {
                    Console.WriteLine("You walk through the northernmost door.");
                    Game.RoomN1();
                }

                if (userInput.ToLower() == "e")
                {
                    Console.WriteLine("You walk through the easternmost door.");
                    Game.RoomE1();
                }

                if (userInput.ToLower() == "s")
                {
                    Console.WriteLine("You walk through the southernmost door.");
                    Game.RoomS1();
                }

                if (userInput.ToLower() == "w")
                {
                    Console.WriteLine("You walk through the westernmost door.");
                    Game.RoomW1();
                }

                else
                {
                    Console.WriteLine("ERROR: Enter a valid option");
                    Console.ReadLine();
                    Game.StartingRoom();
                }
            } while (true);
        }

        public static bool RoomN1()
        {
            Console.WriteLine("You walk through the northernmost door.");
            Console.WriteLine("You see a long, rocky hallway leading to another door further north.");
            Console.WriteLine("You see a few rocks that can be used for cover, and a " + Assets.MobList[1].MobName + " by the northern door");
            Console.WriteLine("1. Use your " + Lists.Inventory.ElementAt(0) + " to fight the " + Assets.MobList[1].MobName + ".");
            Console.WriteLine("2. Go back in the southern door you entered in.");
            Console.WriteLine("3. Hide behind a rock and wait to see if the " + Assets.MobList[1].MobName + " will leave.");
            Console.WriteLine("Choose your action (1-3): ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You engage in battle with " + Assets.MobList[1].MobName + "!");
                    Encounters.Combat(Assets.MobList[1].MobName, Assets.MobList[1].MobHealth, Assets.MobList[1].MobPower, Assets.MobList[1].MobDefense);
                    Console.WriteLine("After defeating the " + Assets.MobList[1].MobName + ", you continue to the end of the hallway and enter the door...");
                    RoomN2();
                    return false;
                case "2":
                    Console.WriteLine("You head back through the door, back to the prison cell you escaped from.");
                    StartingRoom();
                    return false;
                case "3":
                    Console.WriteLine("You wait for hours until you eventually fall asleep.");
                    Console.WriteLine("The " + Assets.MobList[1].MobName + "dicovers you, and kills you in your sleep.");
                    Console.WriteLine("GAME OVER");
                    Environment.Exit(0);
                    return false;
                default:
                    Assets.OptionErrorMessage();
                    return true;
            }
        }

        public static void RoomE1()
        {
            Assets.InProgress();
        }

        public static void RoomS1()
        {
            Assets.InProgress();
        }

        public static void RoomW1()
        {
            Assets.InProgress();
        }

        public static void RoomN2()
        {
            Assets.InProgress();
        }
    }
}