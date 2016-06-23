using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class btsModel
    {
        public double lat { get; set; }
        public double lng { get; set; }
        public double accuracy { get; set; }
        public double cellid { get; set; }
        public double lac { get; set; }
        public double mcc { get; set; }
        public double mnc { get; set; }
    }
}
