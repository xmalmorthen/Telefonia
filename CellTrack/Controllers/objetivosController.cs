using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class objetivosController
    {
        public static List<malocalizations> getTargets {
            get {
                return DAL.Db.malocalizations.ToList();            
            }
        }
    }
}
