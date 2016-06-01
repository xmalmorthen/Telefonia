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
        public static bool update(localizationsModel Item)
        {
            Boolean returnResult = false;
            try
            {
                malocalizations item = DAL.Db.malocalizations.SingleOrDefault(qry => qry.id.Equals(Item.id));

                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} | {3} ], es posible que se haya eliminado desde otra instancia",Item.id,Item.nombre,Item.Carrier, Item.objetivo));

                item.idNotification = Item.idNotification;
                item.fAct = DateTime.Now;
                                
                DAL.Db.SaveChanges();
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }
    }
}
