using Duplicator.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicator.Models
{
    static class caUsersModel
    {
        private static DBDuplicatorDataContext dbDuplicator = new DBDuplicatorDataContext();

        public static List<caUsers> getUsers() {
            try
            {
                return dbDuplicator.GetTable<caUsers>().Where(qry => qry.active == true).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Boolean insertUser(caUsers data) {
            Boolean result = false;
            try
            {
                if (dbDuplicator.caUsers.SingleOrDefault(qry => qry.user.Equals(data.user.Trim()) && qry.active == true) == null) {
                    data.active = true;

                    dbDuplicator.caUsers.InsertOnSubmit(data);
                    dbDuplicator.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    result = true;    
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public static Boolean editUser(caUsers data) {
            Boolean result = false;
            try
            {
                caUsers reg = dbDuplicator.caUsers.SingleOrDefault(qry => qry.id.Equals(data.id));
                if (reg != null){
                    reg.password = data.password;
                    reg.fAct = DateTime.Now;
                    dbDuplicator.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    result = true;    
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public static Boolean deleteUser(caUsers data) { 
            Boolean result = false;
            try
            {
                caUsers reg = dbDuplicator.caUsers.SingleOrDefault(qry => qry.id.Equals(data.id));
                if (reg != null){
                    reg.active = false;
                    reg.fAct = DateTime.Now;
                    dbDuplicator.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    result = true;    
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;        
        }
        

    }
}
