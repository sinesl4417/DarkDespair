using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Game
    {
        public static void Start()
        {
            Console.WriteLine("D: Display Current Location");
            string UserInput = Console.ReadLine();
            do
            {
                if (UserInput.ToLower() == "d")
                {
                    CurrentLocation.DisplayCurrentLocation();
                }

            }while (true);

        }
    }
}
