using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Weapon: Item
    {
        #region Fields
        private int _ID;
        private string _Name;
        private string _Description;
        private int _Price;
        private int _Damage;
        private bool _Required;
        private bool _Equippable;
        #endregion

        #region Properties
        public int Damage { get { return _Damage; } set { _Damage = value; } }
        #endregion

        #region Constructor
        public Weapon(int ID, string Name, string Description, int Price, int Damage, bool Required, bool Equippable) : base(ID, Name, Description, Price, Required, Equippable)
        {
            this._ID = ID;
            this._Name = Name;
            this._Description = Description;
            this._Price = Price;
            this._Damage = Damage;
            this._Required = Required;
            this._Equippable = Equippable;
        }
        #endregion
    }
}
