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
    static class usuarioController
    {
        private static dbgeolocEntities db = new dbgeolocEntities();

        public static Boolean verifyLogInUser(string usr, string pwd, out causuarios user) {            
            Boolean result = false;
            string md5Pass = md5.Get(pwd);
            causuarios usuario = db.causuarios.SingleOrDefault(qry => qry .usuario == usr && qry.contrasenia == md5Pass);
            user = usuario;
            if (usuario != null)
                result = true;
            return result;
        }

        public static List<vwusernotifications> usersNotifications
        {
            get {
                return db.vwusernotifications.ToList();   
            }
        }

    }
}
