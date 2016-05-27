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
                return DAL.Db.vwusernotifications.ToList();   
            }
        }

        public static class usuarioLogueado {
            public static causuarios info { get; set; }            
        }

    }

}
