using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Models
{
    class TMSICatcher
    {
        private string identity;
        public string Identity
        {
            get { return identity; }
            set { identity = value; }
        }

        private string rxLevel;
        public string RxLevel
        {
            get { return rxLevel; }
            set { rxLevel = value; }
        }

        private string aRFCN;
        public string ARFCN
        {
            get { return aRFCN; }
            set { aRFCN = value; }
        }

        private string provider;
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        private string lastAction;
        public string LastAction
        {
            get { return lastAction; }
            set { lastAction = value; }
        }

        private string activ;
        public string Activ
        {
            get { return activ; }
            set { activ = value; }
        }

        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
