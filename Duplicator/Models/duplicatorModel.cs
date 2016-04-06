using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicator.Models
{
    public class duplicatorModel
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string number;
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private string carrier;
        public string Carrier
        {
            get { return carrier; }
            set { carrier = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

    }
}
