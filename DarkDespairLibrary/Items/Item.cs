using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Item
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
        public int ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public int Price { get { return _Price; } set { _Price = value; } }
        public bool Required { get { return _Required; } set { _Required = value; } }
        public bool Equippable { get { return _Equippable; } set { _Equippable = value; } }
        #endregion

        #region Constructor
        public Item(int ID, string Name, string Description, int Price, bool Required, bool Equippable)
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
