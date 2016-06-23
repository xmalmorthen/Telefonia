using CellTrack.Classes;
using CellTrack.Models.DataBases;
using CellTrack.Models.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CellTrack.Controllers.RegistrosControllers
{
    public static class TELMEXController
    {
        private static List<TELMEXModel> dataList = new List<TELMEXModel>();
        private static List<BackgroundWorker> wrkers = new List<BackgroundWorker>();

        public static List<TELMEXModel> find(string idEntidad, string tipo, List<string> searchFields, string cad, Boolean exacta)
        {
            string qry = string.Empty;

            if (tipo.Equals("telbca") || tipo.Equals("telpriv"))
            {
                qry = @"
(
SELECT
    numero,
    CONCAT_WS(' ',nombre,paterno,materno) as nombre,
    direccion,
    cpostal,
    colonia,
    municipio,
    estado ";
            }
            else {
                qry = @"
(
SELECT
    numero,
    direccion,
    municipio,
    central ";
            }

        qry += @"
FROM
    {0}{1}
WHERE
    {2}
)";
            string preFab = exacta ? string.Format(@"= '{0}'",cad) : string.Format(@"LIKE '%{0}%'",cad.Replace(" ","%"));
            string where = string.Empty;
            if (!tipo.Equals("telcas"))
            {
                foreach (string item in searchFields)
                {
                    switch (item.ToLower())
                    {
                        case "nombre":
                            where += string.Format(@"CONCAT_WS(' ',nombre,paterno,materno) {0}", preFab);
                            break;
                        case "numero":
                            where += string.Format(@"{0} numero {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                            break;
                        case "domicilio":
                            where += string.Format(@"{0} direccion {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                            break;
                        case "cp":
                            where += string.Format(@"{0} cpostal {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                            break;
                    }
                }
            }
            else {
                where += string.Format(@"{0} numero {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
            }

            dataList.Clear();

            if (idEntidad.Equals("00"))
            {
                for (int i = 1; i <= (tipo.Equals("telcas") ? 9 : 32); i++)
                {
                    string qryFab = string.Format(qry,tipo,i.ToString("00"), where);

                    BackgroundWorker wrker = new BackgroundWorker();
                    wrker.WorkerSupportsCancellation = true;
                    wrker.DoWork += wrker_DoWork;
                    wrker.RunWorkerCompleted += wrker_RunWorkerCompleted;
                    wrker.RunWorkerAsync(qryFab);
                    wrkers.Add(wrker);
                }
            }
            else {
                string qryFab = string.Format(qry,tipo,idEntidad, where);
                BackgroundWorker wrker = new BackgroundWorker();
                wrker.WorkerSupportsCancellation = true;
                wrker.DoWork += wrker_DoWork;
                wrker.RunWorkerCompleted += wrker_RunWorkerCompleted;
                wrker.RunWorkerAsync(qryFab);
                wrkers.Add(wrker);
            }


            Boolean waith = true;
            while (waith == true)
            {
                waith = false;
                foreach (BackgroundWorker item in wrkers)
                {
                    if (item.IsBusy)
                    {
                        waith = true;
                        Thread.Sleep(1000);
                        break;
                    }
                }
            }
            cancelFind();

            return dataList.Count > 0 ? dataList : null;
        }

        private static void wrker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            string qry = e.Argument.ToString();
            bdRegistrosEntities bd = new bdRegistrosEntities();
            List<TELMEXModel> data = null;
            try
            {
                bd.Database.CommandTimeout = 0;
                data = bd.Database.SqlQuery<TELMEXModel>(qry).ToList();
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            e.Result = data;

            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private static void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                List<TELMEXModel> data = (List<TELMEXModel>)e.Result;
                if (data != null)
                    if (data.Count > 0)
                        lock (dataList)
                        {
                            dataList.AddRange(data);
                        }
                ((BackgroundWorker)sender).CancelAsync();             
            }
        }

        public static void cancelFind() {
            foreach (BackgroundWorker item in wrkers)
                if (item.IsBusy) item.CancelAsync();
            wrkers.Clear();
        }

    }
}
