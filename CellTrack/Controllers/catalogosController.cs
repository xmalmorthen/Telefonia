using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class catalogosController
    {
        public static List<vwactivecarriers> activeCarriers
        {
            get
            {
                return DAL.Db.vwactivecarriers.ToList();
            }
        }

        public static cacarriers carrierById(int idCarrier, Boolean verifyActive = true)
        {
            cacarriers carrier = DAL.Db.cacarriers.SingleOrDefault(qry => qry.id.Equals(idCarrier));
            return verifyActive == true ? (carrier.active == true ? carrier : null) : carrier;
        }


    }
}
