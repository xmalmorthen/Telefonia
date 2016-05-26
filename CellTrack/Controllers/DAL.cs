using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class DAL
    {
        private static dbgeolocEntities db;
        public static dbgeolocEntities Db
        {
            get { return DAL.db; }
            set { DAL.db = value; }
        }
    }
}
