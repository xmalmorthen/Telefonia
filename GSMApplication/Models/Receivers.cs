using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Models
{
    public static class Recivers {
        private static List<Receiver> list = new List<Receiver>();
        public static List<Receiver> List
        {
            get { return Recivers.list; }
            set { Recivers.list = value; }
        }
        
    }

    public class Receiver
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string serial;
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }
    }
}
