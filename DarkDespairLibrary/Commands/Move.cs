using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Move
    {
        public bool CanMove = true;

        public static void ChangeLocation(Room Location)
        {
            Player.CurrentLocation = Location;
        }

        public static void MoveTo(Room Location)
        {
            ChangeLocation(Location);
        }

        public static void MoveToStart()
        {
            MoveTo(World.Rooms[0]);
        }

    }
}
