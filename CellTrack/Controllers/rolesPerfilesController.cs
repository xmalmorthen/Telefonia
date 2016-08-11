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
    public static class rolesPerfilesController
    {                
        
        public static List<caperfiles> perfiles {
            get {
                return DALController.Db.caperfiles.Where(qry => qry.isDeleted.Equals(false)).ToList();
            }
        }

        public static List<caroles> roles
        {
            get
            {
                return DALController.Db.caroles.Where(qry => qry.activo.Equals(true) && qry.isDeleted.Equals(false)).ToList();
            }
        }

        public static List<reperfilroles> rolesAsignadosAPerfil(int idPerfil)
        {
            return DALController.Db.reperfilroles.Where(qry => qry.idPerfil.Equals(idPerfil) && qry.caroles.activo.Equals(true) && qry.caroles.isDeleted.Equals(false) ).ToList();
        }

        public static bool insert(caperfiles newItem)
        {
            Boolean returnResult = false;
            try
            {
                newItem.fIns = DateTime.Now;
                DALController.Db.caperfiles.Add(newItem);                
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }

        public static bool edit(caperfiles Item)
        {
            Boolean returnResult = false;
            try
            {
                caperfiles item = DALController.Db.caperfiles.SingleOrDefault(qry => qry.id.Equals(Item.id));
                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} ], es posible que se haya eliminado desde otra instancia", Item.id, Item.perfil, Item.fIns));
                item.perfil = Item.perfil;
                item.activo = Item.activo;
                item.fAct = DateTime.Now;
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }

        internal static bool delete(caperfiles Item)
        {
            Boolean returnResult = false;
            try
            {
                caperfiles item = DALController.Db.caperfiles.SingleOrDefault(qry => qry.id.Equals(Item.id));
                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} ], es posible que se haya eliminado desde otra instancia", Item.id, Item.perfil, Item.fIns));
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

        internal static bool actualizaRoles(int idPerfil, List<int> rolesAsignados)
        {
            Boolean returnResult = false;
            try
            {
                List<reperfilroles> entities = new List<reperfilroles>(rolesAsignados.Count());
                foreach (int item in rolesAsignados)
                {
                    entities.Add( new reperfilroles(){
                        idPerfil = idPerfil,
                        idRol = item,
                        fIns = DateTime.Now
                    });
                }

                DALController.Db.reperfilroles.RemoveRange(DALController.Db.reperfilroles.Where(qry => qry.idPerfil.Equals(idPerfil)).ToList());
                DALController.Db.reperfilroles.AddRange(entities);
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
