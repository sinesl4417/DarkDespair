using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class CurrentLocation
    {
        public static void DisplayCurrentLocation()
        {
            Console.WriteLine("You are at: {0}", Player.CurrentLocation.Name);
        }
    }
}
