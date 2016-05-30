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
    public static class usuarioController
    {
        public static Boolean verifyLogInUser(string usr, string pwd) {            
            Boolean result = false;
            string md5Pass = md5.Get(pwd);
            causuarios usuario = DAL.Db.causuarios.SingleOrDefault(qry => qry.usuario.Equals(usr) && qry.contrasenia.Equals(md5Pass) && qry.active.Equals(true));

            usuarioLogueado.info = usuario;

            if (usuario != null)
                result = true;
            return result;
        }

        public static causuarios getUserById(int IdUser, Boolean verifyActive = true) {
            causuarios usuario = DAL.Db.causuarios.SingleOrDefault(qry => qry.id.Equals(IdUser));
            return verifyActive == true ? (usuario.active == true ? usuario : null) : usuario;
        }

        public static List<vwusernotifications> usersNotifications
        {
            get {
                return DAL.Db.vwusernotifications.Where(qry => qry.idGpo.Equals(usuarioLogueado.info.idGpo)).ToList();   
            }
        }

        public static class usuarioLogueado {
            public static causuarios info { get; set; }            
        }

        public static List<causuarios> usuarios {
            get {
                return DAL.Db.causuarios.Where(qry => qry.isDeleted.Equals(false)).ToList();
            }
        }

        public static bool insert(causuarios newItem)
        {
            Boolean returnResult = false;
            try
            {
                newItem.contrasenia = md5.Get(newItem.contrasenia);
                newItem.fIns = DateTime.Now;
                DAL.Db.causuarios.Add(newItem);
                DAL.Db.SaveChanges();
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }

        public static bool edit(causuarios Item)
        {
            Boolean returnResult = false;
            try
            {
                causuarios item = DAL.Db.causuarios.SingleOrDefault(qry => qry.id.Equals(Item.id));

                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} | {3} ], es posible que se haya eliminado desde otra instancia", Item.id, Item.usuario, Item.fIns, string.Format("{0} {1} {2}",Item.Nombres,Item.PrimerApellido,Item.SegundoApellido)));

                item.PrimerApellido = Item.PrimerApellido;
                item.SegundoApellido = Item.SegundoApellido;
                item.Nombres = Item.Nombres;
                item.usuario = Item.usuario;
                item.contrasenia = Item.contrasenia;
                item.cantidadLocalizaciones = Item.cantidadLocalizaciones;
                item.active = Item.active;
                item.fAct = DateTime.Now;
                item.idGpo = Item.idGpo;
                item.esSupervisor = Item.esSupervisor;
                item.idPerfil = Item.idPerfil;

                DAL.Db.SaveChanges();
                returnResult = true;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return returnResult;
        }

        internal static bool delete(causuarios Item)
        {
            Boolean returnResult = false;
            try
            {
                causuarios item = DAL.Db.causuarios.SingleOrDefault(qry => qry.id.Equals(Item.id));

                if (item == null) throw new NullReferenceException(string.Format("No se encontró el registro [ {0} | {1} | {2} | {3} ], es posible que se haya eliminado desde otra instancia", Item.id, Item.usuario, Item.fIns, string.Format("{0} {1} {2}", Item.Nombres, Item.PrimerApellido, Item.SegundoApellido)));

                item.isDeleted = true;
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
