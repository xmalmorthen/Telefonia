using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Models
{
    class SharpRandom
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string identity;
        public string Identity
        {
            get { return identity; }
            set { identity = value; }
        }

        private string kc;
        public string Kc
        {
            get { return kc; }
            set { kc = value; }
        }

        private string rxLevel;
        public string RxLevel
        {
            get { return rxLevel; }
            set { rxLevel = value; }
        }

        private string lastAction;
        public string LastAction
        {
            get { return lastAction; }
            set { lastAction = value; }
        }

    }
}
