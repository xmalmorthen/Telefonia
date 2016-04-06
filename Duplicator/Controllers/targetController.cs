using Duplicator.Models;
using Duplicator.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Duplicator.Controllers
{
    static class targetController
    {
        private static DBDuplicatorDataContext dbDuplicator = new DBDuplicatorDataContext();

        public static Boolean record(caUsers userLogged, duplicatorModel target, out string message)
        {
            Boolean result = false;
            message = string.Empty;
            try
            {
                int maxTargets = int.Parse(dbDuplicator.caConfigurations.SingleOrDefault(qry => qry.tag.Equals(Duplicator.Properties.Settings.Default.maxTargetsTableColName)).value);

                //verificar numero de objetivos permitidos y guardados
                if (dbDuplicator.reUsersDuplicators.Select(qry => qry.idUser == userLogged.id && qry.active == true).Count() >= maxTargets)
                {
                    message = String.Format("{0} existing targets, impossible to add more", maxTargets);
                }
                //verificar si existe target
                else if (dbDuplicator.reUsersDuplicators.SingleOrDefault(qry => qry.idUser.Equals (userLogged.id) &&
                                                                            qry.active.Equals (true) &&
                                                                            qry.maDuplicator.number.Equals (target.Number) &&
                                                                            qry.maDuplicator.carrier.Equals (target.Carrier) &&
                                                                            qry.maDuplicator.country.Equals (target.Country) &&
                                                                            qry.maDuplicator.active.Equals (true)) != null)
                {
                    message = "Target to add already exists";
                }
                //grabar
                else { 
                    /*
                     * TODO: Proceso de grabado
                     */
                    Thread.Sleep(3);

                    /*
                     * GRABAR EN BD
                     */

                    maDuplicator ma = dbDuplicator.maDuplicator.SingleOrDefault(qry => qry.number.Equals(target.Number) && qry.carrier.Equals(target.Carrier) && qry.country.Equals(target.Country));
                    if (ma == null)
                    {
                        ma = new maDuplicator();
                        ma.number = target.Number.Trim().ToUpper();
                        ma.carrier = target.Carrier.Trim().ToUpper();
                        ma.country = target.Country.Trim().ToUpper();
                        ma.active = true;
                        dbDuplicator.maDuplicator.InsertOnSubmit(ma);
                    }
                    else
                    {
                        ma.active = true;
                    }
                    dbDuplicator.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                    reUsersDuplicators re = new reUsersDuplicators();
                    re.idMaDuplicator = ma.id;
                    re.idUser = userLogged.id;
                    re.active = true;

                    dbDuplicator.reUsersDuplicators.InsertOnSubmit(re);                    
                    dbDuplicator.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                    message = "Target successfully added";
                    result = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public static Boolean remove(caUsers userLogged, duplicatorModel target, out string message)
        {
            Boolean result = false;
            message = string.Empty;
            try
            {
                reUsersDuplicators data = dbDuplicator.reUsersDuplicators.SingleOrDefault(qry => qry.idUser.Equals (userLogged.id) && qry.maDuplicator.number.Equals(target.Number) && qry.maDuplicator.carrier.Equals(target.Carrier) && qry.maDuplicator.country.Equals(target.Country));
                if (data != null)
                {
                    /*
                     * TODO: Proceso de borrado
                     */
                    Thread.Sleep(3);

                    /*
                     * GRABAR EN BD
                     */
                    data.active = false;
                    dbDuplicator.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                    message = "Target successfully removed";
                    result = true;
                } else 
                {
                    message = "Target not found";
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
