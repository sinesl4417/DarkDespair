using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Potion: Item
    {
        #region Fields
        private int _ValueChanged;
        #endregion

        #region Properties
        public int ValueChanged { get { return _ValueChanged; } set { _ValueChanged = value; } }
        #endregion

        #region Constructor
        public Potion(int ID, string Name, string Description, int Price, int ValueChanged, bool Required, bool Equippable) : base(ID, Name, Description, Price, Required, Equippable)
        {
            this._ValueChanged = ValueChanged;
        }
        #endregion
    }
}
