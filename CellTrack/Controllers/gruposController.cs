using CellTrack.Classes;
using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Controllers
{
    public static class gruposController
    {                
        
        public static List<cagrupos> grupos {
            get {
                return DALController.Db.cagrupos.Where(qry => qry.isDeleted.Equals(false) ).ToList();
            }
        }

        public static List<cagrupos> activeGrupos
        {
            get
            {
                return DALController.Db.cagrupos.Where(qry => qry.activo.Equals(true) && qry.isDeleted.Equals(false)).ToList();
            }
        }



        public static bool insert(cagrupos newItem)
        {
            Boolean returnResult = false;
            try
            {
                newItem.fIns = DateTime.Now;
                DALController.Db.cagrupos.Add(newItem);
                DALController.Db.SaveChanges();
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }

        public static bool edit(cagrupos Item)
        {
            Boolean returnResult = false;
            try
            {
                cagrupos item = DALController.Db.cagrupos.SingleOrDefault(qry => qry.id.Equals(Item.id));
                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} ], es posible que se haya eliminado desde otra instancia", Item.id, Item.grupo, Item.fIns));
                item.descrip = Item.descrip;
                item.activo = Item.activo;
                item.fAct = DateTime.Now;
                DALController.Db.SaveChanges();
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }

        internal static bool delete(cagrupos Item)
        {
            Boolean returnResult = false;
            try
            {
                cagrupos item = DALController.Db.cagrupos.SingleOrDefault(qry => qry.id.Equals(Item.id));
                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} ], es posible que se haya eliminado desde otra instancia", Item.id, Item.grupo, Item.fIns));
                item.isDeleted = true;
                item.fAct = DateTime.Now;
                DALController.Db.SaveChanges();
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
