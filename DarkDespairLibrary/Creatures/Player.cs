using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Player: Creature
    {
        #region Fields
        private Weapon _Weapon;
        private List<Item> _Items;
        private static Room _CurrentLocation;
        #endregion

        #region Properties
        public Weapon EquippedWeapon { get { return _Weapon; } set { _Weapon = value; } }
        public List<Item> Items { get { return _Items; } set { _Items = value; } }
        public static Room CurrentLocation { get { return _CurrentLocation; } set { _CurrentLocation = value; } }
        #endregion

        #region Constructor
        public Player(int ID, string Name, string Description, int CurrentHP, int MaxHP, int Attack, int Defense, Weapon EquippedWeapon, List<Item> Inventory, Room currentLocation, bool IsDead, bool CanAttack) : base(ID, Name, Description, CurrentHP, MaxHP, Attack, Defense, IsDead, CanAttack)
        {
            this._Weapon = EquippedWeapon;
            this._Items = Inventory;
            CurrentLocation = currentLocation;
        }
        #endregion
    }
}
