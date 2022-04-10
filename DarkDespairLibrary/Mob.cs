using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDespairLibrary
{
    public class Mob
    {
        private string _Name;
        private int _Health;
        private int _Power;
        private int _Defense;

        public Mob(string MobName, int MobHealth, int MobPower, int MobDefense)
        {
            _Name = MobName;
            _Health = MobHealth;
            _Power = MobPower;
            _Defense = MobDefense;
        }

        public string MobName
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int MobHealth
        {
            get { return _Health; }
            set { _Health = value; }
        }

        public int MobPower
        {
            get { return _Power; }
            set { _Power = value; }
        }

        public int MobDefense
        {
            get { return _Defense; }
            set { _Defense = value; }
        }
    }
}
