using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Models
{
    class Targets
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

        private string number;
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private Boolean bound;
        public Boolean Bound
        {
            get { return bound; }
            set { bound = value; }
        }

        private string kc;
        public string Kc
        {
            get { return kc; }
            set { kc = value; }
        }

        private string rdLevel;
        public string RdLevel
        {
            get { return rdLevel; }
            set { rdLevel = value; }
        }

        private string lastAction;
        public string LastAction
        {
            get { return lastAction; }
            set { lastAction = value; }
        }

    }
}
