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
    public static class objetivosController
    {
        public static List<malocalizations> getTargets(int idUser) 
        {
            return DAL.Db.malocalizations.Where(qry => qry.idUser.Equals(idUser) && qry.active.Equals(true)).ToList();
        }

        public static Boolean insertNewTarget(localizationsModel target) {
            Boolean returnResult = false;
            try
            {
                malocalizations item = new malocalizations()
                {
                    idUser = usuarioController.usuarioLogueado.info.id,
                    nombre = target.nombre,
                    asunto = target.asunto,
                    objetivo = target.objetivo,
                    idNotification = target.idNotification,
                    idCarrier = target.idCarrier,
                    agendaDe = target.agendaDe,
                    agendaA = target.agendaA,
                    agendaFrecuencia = target.agendaFrecuencia,
                    fIns = DateTime.Now,
                    active = true
                };

                DAL.Db.malocalizations.Add(item);
                DAL.Db.SaveChanges();
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }

        public static bool editTarget(localizationsModel Item)
        {
            Boolean returnResult = false;
            try
            {
                malocalizations item = DAL.Db.malocalizations.SingleOrDefault(qry => qry.id.Equals(Item.id));

                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} | {3} ], es posible que se haya eliminado desde otra instancia",Item.id,Item.nombre,Item.Carrier, Item.objetivo));

                item.nombre = Item.nombre;
                item.idCarrier = Item.idCarrier;
                item.asunto = Item.asunto;
                item.idNotification = Item.idNotification;
                item.objetivo = Item.objetivo;
                item.agendaDe = Item.agendaDe;
                item.agendaA = Item.agendaA;
                item.agendaFrecuencia = Item.agendaFrecuencia;
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

        internal static bool deleteTarget(localizationsModel Item)
        {
            Boolean returnResult = false;
            try
            {
                malocalizations item = DAL.Db.malocalizations.SingleOrDefault(qry => qry.id.Equals(Item.id));

                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} | {3} ], es posible que se haya eliminado desde otra instancia", Item.id, Item.nombre, Item.Carrier, Item.objetivo));

                item.active = false;
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
