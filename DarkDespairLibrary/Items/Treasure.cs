using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Treasure: Item
    {
        #region Fields
        private int _ID;
        private string _Name;
        private string _Description;
        private int _Price;
        private bool _Required;
        private bool _Equippable;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public Treasure(int ID, string Name, string Description, int Price, bool Required, bool Equippable) : base(ID, Name, Description, Price, Required, Equippable)
        {
            this._ID = ID;
            this._Name = Name;
            this._Description = Description;
            this._Price = Price;
            this._Required = Required;
            this._Equippable = Equippable;
        }
        #endregion
    }
}
