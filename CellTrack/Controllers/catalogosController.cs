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


    }
}
