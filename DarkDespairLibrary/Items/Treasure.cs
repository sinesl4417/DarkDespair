using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Treasure: Item
    {
        public Treasure(int ID, string Name, string Description, int Price, bool Required, bool Equippable) : base(ID, Name, Description, Price, Required, Equippable)
        {

        }
    }
}
