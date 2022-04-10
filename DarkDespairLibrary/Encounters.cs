using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Encounters
    {
        static Random rand = new Random();

        public static void Combat(string name, int health, int power, int defense)
        {
            string MobName = name;
            int MobHealth = health;
            int MobPower = power;
            int MobDefense = defense;

            while (MobHealth > 0 && Player.PlayerHealth > 0)
            {
                Console.WriteLine("Player Health: " + Player.PlayerHealth);
                Console.WriteLine("Enemy Health: " + MobHealth);
                Console.WriteLine("Choose Action:");
                Console.WriteLine("------------------------");
                Console.WriteLine("|  (A)ttack (D)efend   |");
                Console.WriteLine("|  (R)un    (H)eal     |");
                Console.WriteLine("------------------------");
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    int MobDamage = rand.Next(1, MobPower) + rand.Next(1, 20) - (Player.ArmorValue + Player.PlayerDefense);
                    if (MobDamage < 0)
                        MobDamage = 0;
                    int PlayerDamage = (rand.Next(1, Player.WeaponValue) + rand.Next(1, 20) - MobDefense);
                    Console.WriteLine("You attack with your sword for " + PlayerDamage + " damage.");
                    Console.WriteLine("The " + MobName + " attacks you back for " + MobDamage + " damage.");
                    Player.PlayerHealth -= MobDamage;
                    MobHealth -= PlayerDamage;

                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    Console.WriteLine("You defend against the oncoming attack.");
                    int MobDamage = rand.Next(1, MobPower) + rand.Next(1, 6) - (Player.ArmorValue + Player.PlayerDefense);
                    if (MobDamage < 0)
                        MobDamage = 0;
                    int PlayerDamage = (rand.Next(0, 3) - MobDefense);
                    Console.WriteLine("The " + MobName + " attacks you for " + MobDamage + " damage.");
                    Console.WriteLine("During its attack, the " + MobName + "sustains " + PlayerDamage + " damage.");
                    Player.PlayerHealth -= MobDamage;
                    MobHealth -= PlayerDamage;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You are unable to escape the fight.");
                        int MobDamage = rand.Next(1, MobPower) + rand.Next(1, 20) - (Player.ArmorValue + Player.PlayerDefense);
                        if (MobDamage < 0)
                            MobDamage = 0;
                        Console.WriteLine("The " + MobName + "attacked you as you failed to escape for " + MobDamage + " damage.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You successfully escape the battle!");
                        Console.ReadKey();
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (Player.Potion == 0)
                    {
                        Console.WriteLine("You have 0 potions in your inventory.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You have " + Player.Potion + " potion(s) in your inventory.");
                        Console.WriteLine("You are now at full health!");
                        Player.PlayerHealth += 100;
                        Player.Potion -= 1;
                        Console.WriteLine("You are now at " + Player.PlayerHealth + " health! You now have "+ Player.Potion + " potion(s) in your inventory.");
                    }
                }
                Console.ReadKey();
            }
            if (MobHealth <= 0)
            {
                Console.WriteLine("You defeated the " + MobName + "!");
            }
            else
            {
                Console.WriteLine("You were defeated by the " + MobName + "...");
                Console.ReadKey();
                Console.WriteLine("GAME OVER");
                Console.ReadKey();
            }
        }
    }
}
