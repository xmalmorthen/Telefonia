using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Models
{
    class CellsModel
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

        private string band;
        public string Band
        {
            get { return band; }
            set { band = value; }
        }

        private string rxLevel;
        public string RxLevel
        {
            get { return rxLevel; }
            set { rxLevel = value; }
        }

        private string lac;
        public string LAC
        {
            get { return lac; }
            set { lac = value; }
        }

        private string mcc;
        public string MCC
        {
            get { return mcc; }
            set { mcc = value; }
        }

        private string mnc;
        public string MNC
        {
            get { return mnc; }
            set { mnc = value; }
        }

        private string provider;
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        private string comment;
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

    }
}
