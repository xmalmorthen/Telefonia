using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satelites.Models
{
    class receiversModel
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string arfcn;
        public string ARFCN
        {
            get { return arfcn; }
            set { arfcn = value; }
        }

        private string cellId;
        public string CellId
        {
            get { return cellId; }
            set { cellId = value; }
        }

        private string rxLevel;
        public string RxLevel
        {
            get { return rxLevel; }
            set { rxLevel = value; }
        }

        private string err;
        public string ERR
        {
            get { return err; }
            set { err = value; }
        }
        
        private string mode;
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

    }
}
