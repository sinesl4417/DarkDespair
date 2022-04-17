using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Creature
    {
        #region Fields
        private int _ID;
        private string _Name;
        private string _Description;
        private int _CurrentHP;
        private int _MaxHP;
        private int _Attack;
        private int _Defense;
        private bool _IsDead;
        private bool _CanAttack;
        #endregion

        #region Properties
        public int ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public int CurrentHP { get { return _CurrentHP; } set { _CurrentHP = value; } }
        public int MaxHP { get { return _MaxHP; } set { _MaxHP = value; } }
        public int Attack { get { return _Attack; } set { _Attack = value; } }
        public int Defense { get { return _Defense; } set { _Defense = value; } }
        public bool IsDead { get { return _IsDead; } set { _IsDead = value; } }
        public bool CanAttack { get { return _CanAttack; } set { _CanAttack = value; } }
        #endregion

        #region Constructor
        public Creature(int ID, string Name, string Description, int CurrentHP, int MaxHP, int Attack, int Defense, bool IsDead, bool CanAttack)
        {
            this._ID = ID;
            this._Name = Name;
            this._Description = Description;
            this._CurrentHP = CurrentHP;
            this._MaxHP = MaxHP;
            this._Attack = Attack;
            this._Defense = Defense;
            this._IsDead = IsDead;
            this._CanAttack = CanAttack;
        }
        #endregion
    }
}
