using Duplicator.classes;
using Duplicator.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicator.Controllers
{
    static class loginController
    {
        private static DBDuplicatorDataContext dbDuplicator = new DBDuplicatorDataContext();

        public static caUsers login(string usr, string pass){
            try
            {
                return dbDuplicator.caUsers.SingleOrDefault(qry => qry.user.Equals(usr) && qry.password.Equals(Hash.Encode(pass)) && qry.active == true);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
