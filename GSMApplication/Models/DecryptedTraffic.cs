using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Models
{
    class DecryptedTraffic
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string from;
        public string From
        {
            get { return from; }
            set { from = value; }
        }

        private string to;
        public string To
        {
            get { return to; }
            set { to = value; }
        }

        private string arfcn;
        public string ARFCN
        {
            get { return arfcn; }
            set { arfcn = value; }
        }

        private string provider;
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        private Bitmap img;
        public Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }

        private string context;
        public string Context
        {
            get { return context; }
            set { context = value; }
        }
    }
}
