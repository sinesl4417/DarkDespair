using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Mob: Creature
    {
        #region Fields
        private int _ID;
        private string _Name;
        private string _Description;
        private int _CurrentHP;
        private int _MaxHP;
        private int _Attack;
        private int _Defense;
        private Weapon _Weapon;
        private List<Item> _Items;
        private bool _IsDead;
        private bool _CanAttack;
        #endregion

        #region Properties
        public Weapon EquippedWeapon { get { return _Weapon; } set { _Weapon = value; } }
        public List<Item> Items { get { return _Items; } set { _Items = value; } }
        #endregion

        #region Constructor
        public Mob(int ID, string Name, string Description, int CurrentHP, int MaxHP, int Attack, int Defense, Weapon EquippedWeapon, List<Item> Inventory, bool IsDead, bool CanAttack) : base(ID, Name, Description, CurrentHP, MaxHP, Attack, Defense, IsDead, CanAttack)
        {
            this._ID = ID;
            this._Name = Name;
            this._Description = Description;
            this._CurrentHP = CurrentHP;
            this._MaxHP = MaxHP;
            this._Attack = Attack;
            this._Defense = Defense;
            this._Weapon = EquippedWeapon;
            this._Items = Inventory;
            this._IsDead = IsDead;
            this._CanAttack = CanAttack;
        }
        #endregion
    }
}
