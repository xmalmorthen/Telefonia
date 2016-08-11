using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class reasignarObjetivosController
    {
        public static void update(List<localizationsModel> Items)
        {
            try
            {
                foreach (localizationsModel item in Items)
                {
                    malocalizations reg = DALController.Db.malocalizations.SingleOrDefault(qry => qry.id.Equals(item.id) && !qry.idNotification.Equals(item.idNotification));
                    if (reg == null) continue;
                    reg.idNotification = item.idNotification;
                    reg.fAct = DateTime.Now;
                }
                DALController.Db.SaveChanges();
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
        }
    }
}
