using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class PDUModel
    {
        public int id { get; set; }
        public string descrip { get; set; }

        public malocalizations obj;
    }

    public class BTSDataBaseModel
    { 
        public string radio {get;set;}
        public string mcc {get;set;}
        public string mnc {get;set;}
        public string lac {get;set;}
        public string cellid {get;set;}
        public string rnc {get;set;}
        public string enbi { get; set; }
    }
}
