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
        private int _ID;
        private string _Name;
        private string _Description;
        private int _Price;
        private int _ValueChanged;
        private bool _Required;
        private bool _Equippable;
        #endregion

        #region Properties
        public int ValueChanged { get { return _ValueChanged; } set { _ValueChanged = value; } }
        #endregion

        #region Constructor
        public Potion(int ID, string Name, string Description, int Price, int ValueChanged, bool Required, bool Equippable) : base(ID, Name, Description, Price, Required, Equippable)
        {
            this._ID = ID;
            this._Name = Name;
            this._Description = Description;
            this._Price = Price;
            this._ValueChanged = ValueChanged;
            this._Required = Required;
            this._Equippable = Equippable;
        }
        #endregion
    }
}
