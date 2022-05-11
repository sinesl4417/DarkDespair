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
        private int _Damage;
        #endregion

        #region Properties
        public int Damage { get { return _Damage; } set { _Damage = value; } }
        #endregion

        #region Constructor
        public Weapon(int ID, string Name, string Description, int Price, int Damage, bool Required, bool Equippable) : base(ID, Name, Description, Price, Required, Equippable)
        {
            this._Damage = Damage;
        }
        #endregion
    }
}
