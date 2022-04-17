using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Room
    {
        #region Fields
        private int _ID;
        private string _Name;
        private string _Description;
        private int _Exits;
        private int _North;
        private int _East;
        private int _South;
        private int _West;
        #endregion

        #region Properties
        public int ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public int Exits { get { return _Exits; } set { _Exits = value; } }
        public int North { get { return _North; } set { _North = value; } }
        public int East { get { return _East; } set { _East = value; } }
        public int South { get { return _South; } set { _South = value; } }
        public int West { get { return _West; } set { _West = value; } }
        #endregion

        #region Constructor
        public Room(int ID, string Name, string Description, int Exits, int North, int East, int South, int West)
        {
            this._ID = ID;
            this._Name = Name;
            this._Description = Description;
            this._Exits = Exits;
            this._North = North;
            this._East = East;
            this._South = South;
            this._West = West;
        }
        #endregion
    }
}
