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
    public class DarkDespairGame
    {
        public static void PlayDarkDespair()
        {
            Console.WriteLine(DarkDespairAssets.CharCreationWarning());
            DarkDespairLists.BuildInventory();
            string userInput;
            Console.WriteLine("You wake up in a dark, damp room... \nYou feel vegetation on the walls.\nYou find what feels to be a lantern of sorts... light it? (Y/N): ");
            userInput = Console.ReadLine();
            do
            {
                if (userInput.ToLower() == "y")
                {
                    DarkDespairGame.PrisonOpening();
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
                    DarkDespairGame.PlayDarkDespair();
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
                    Console.WriteLine("You see your belongings, which include a backback with one " + DarkDespairLists.Inventory.ElementAt(1) + " in it and your " + DarkDespairLists.Inventory.ElementAt(0) + ".");
                    Console.WriteLine("You grab your things and exit the cell...");
                    DarkDespairGame.StartingRoom();

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
                    DarkDespairGame.PrisonOpening();
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
                    DarkDespairGame.RoomN1();
                }

                if (userInput.ToLower() == "e")
                {
                    Console.WriteLine("You walk through the easternmost door.");
                    DarkDespairGame.RoomE1();
                }

                if (userInput.ToLower() == "s")
                {
                    Console.WriteLine("You walk through the southernmost door.");
                    DarkDespairGame.RoomS1();
                }

                if (userInput.ToLower() == "w")
                {
                    Console.WriteLine("You walk through the westernmost door.");
                    DarkDespairGame.RoomW1();
                }

                else
                {
                    Console.WriteLine("ERROR: Enter a valid option");
                    Console.ReadLine();
                    DarkDespairGame.StartingRoom();
                }
            } while (true);
        }

        public static bool RoomN1()
        {
            string userInput;
            Console.WriteLine("You walk through the northernmost door.");
            Console.WriteLine("You see a long, rocky hallway leading to another door further north.");
            Console.WriteLine("You see a few rocks that can be used for cover, and a " + DarkDespairLists.MobList.ElementAt(1) + " by the northern door");
            Console.WriteLine("1. Use your " + DarkDespairLists.Inventory.ElementAt(0) + " to fight the " + DarkDespairLists.MobList.ElementAt(1) + ".");
            Console.WriteLine("2. Go back in the southern door you entered in.");
            Console.WriteLine("3. Hide behind a rock and wait to see if the " + DarkDespairLists.MobList.ElementAt(1) + " will leave.");
            Console.WriteLine("Choose your action (1-3): ");
            switch (Console.ReadLine())
            {
                case "1":
                    int PlayerHealth = 100;
                    int MobHealth = 30;
                    Console.WriteLine("You engage in battle with the " + DarkDespairLists.MobList.ElementAt(1) + ".");
                    while (PlayerHealth > 0 && MobHealth > 0)
                    {
                        int UserAttack = new Random().Next(5, 10);
                        int MobAttack = new Random().Next(3, 6);
                        int BlockedAttack = new Random().Next(0, 1);
                        Console.WriteLine("Your health: " + PlayerHealth);
                        Console.WriteLine(DarkDespairLists.MobList.ElementAt(1) + "'s health: " + MobHealth);
                        Console.WriteLine("Attack (A) or Block (B): ");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == "a")
                        {
                            Console.WriteLine("You attacked for " + UserAttack + " damage!");
                            MobHealth -= UserAttack;
                            Console.WriteLine(DarkDespairLists.MobList.ElementAt(1) + " attacked you for " + MobAttack + " damage!");
                            PlayerHealth -= MobAttack;
                        }
                        if (userInput.ToLower() == "b")
                        {
                            Console.WriteLine("You blocked the " + DarkDespairLists.MobList.ElementAt(1) + "'s attack with your " + DarkDespairLists.Inventory.ElementAt(0) + ".");
                            Console.WriteLine(DarkDespairLists.MobList.ElementAt(1) + " attacked you for " + BlockedAttack + " damage!");
                            PlayerHealth -= BlockedAttack;
                        }
                    }
                    if (PlayerHealth > 0)
                    {
                        Console.WriteLine("You defeated the " + DarkDespairLists.MobList.ElementAt(1) + "!");
                        Console.WriteLine("Your health: " + PlayerHealth);
                        Console.ReadLine();
                        Console.WriteLine("You continued on throught the door to the north...");
                        DarkDespairGame.RoomN2();
                    }
                    else if (PlayerHealth == 0)
                    {
                        Console.WriteLine("You were defeated by the " + DarkDespairLists.MobList.ElementAt(1) + "!");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    return false;
                case "2":
                    Console.WriteLine("You head back through the door, back to the prison cell you escaped from.");
                    StartingRoom();
                    return false;
                case "3":
                    Console.WriteLine("You wait for hours until you eventually fall asleep.");
                    Console.WriteLine("The " + DarkDespairLists.MobList.ElementAt(1) + "dicovers you, and kills you in your sleep.");
                    Console.WriteLine("GAME OVER");
                    Environment.Exit(0);
                    return false;
                default:
                    DarkDespairAssets.OptionErrorMessage();
                    return true;
            }
        }

        public static void RoomE1()
        {
            DarkDespairAssets.InProgress();
        }

        public static void RoomS1()
        {
            DarkDespairAssets.InProgress();
        }

        public static void RoomW1()
        {
            DarkDespairAssets.InProgress();
        }

        public static void RoomN2()
        {
            DarkDespairAssets.InProgress();
        }
    }
}