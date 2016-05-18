using Duplicator.Models;
using Duplicator.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicator.Controllers
{
    static class targetController
    {
        private static DBDuplicatorDataContext dbDuplicator = new DBDuplicatorDataContext();

        private static Boolean doRecord = false;
        private static string messageWorker = string.Empty;
        public static Boolean record(caUsers userLogged, duplicatorModel target, out string message)
        {
            Boolean result = false;
            message = string.Empty;
            try
            {
                if (dbDuplicator.reUsersDuplicators.SingleOrDefault(qry => qry.idUser.Equals(userLogged.id) &&
                                                                            qry.active.Equals(true) &&
                                                                            qry.maDuplicator.number.Equals(target.Number) &&
                                                                            qry.maDuplicator.carrier.Equals(target.Carrier) &&
                                                                            qry.maDuplicator.country.Equals(target.Country) &&
                                                                            qry.maDuplicator.active.Equals(true)) != null)
                {
                    message = "Target to add already exists";
                }
                //grabar
                else
                {
                    /*
                     * Proceso de grabado
                     */
                    BackgroundWorker wrkr = new BackgroundWorker();
                    wrkr.WorkerReportsProgress = true;
                    wrkr.WorkerSupportsCancellation = true;
                    wrkr.DoWork += wrkr_DoWork;
                    wrkr.RunWorkerCompleted += wrkr_RunWorkerCompleted;
                    wrkr.RunWorkerAsync();

                    while (wrkr.IsBusy)
                    {
                        Application.DoEvents();
                    }

                    if (!doRecord) throw new Exception(messageWorker);

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
            catch (Exception ex)
            {                
                message = ex.Message;
            }
            return result;
        }

        static void wrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
            e.Result = false;
        }

        static void wrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((Boolean)e.Result)
                doRecord = true;
            else 
                messageWorker = "PDU modem not detected. Try again, if the problem persists please contact your system administrator.";
        }

        public static Boolean remove(caUsers userLogged, duplicatorModel target, out string message)
        {
            Boolean result = false;
            message = string.Empty;
            try
            {
                reUsersDuplicators data = dbDuplicator.reUsersDuplicators.SingleOrDefault(qry => qry.idUser.Equals (userLogged.id) && qry.maDuplicator.number.Equals(target.Number) && qry.maDuplicator.carrier.Equals(target.Carrier) && qry.maDuplicator.country.Equals(target.Country) && qry.active == true);
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
