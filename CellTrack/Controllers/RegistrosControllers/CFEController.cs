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
    public static class CFEController
    {
        private static List<CFEModel> dataList = new List<CFEModel>();
        private static List<BackgroundWorker> wrkers = new List<BackgroundWorker>();

        public static List<CFEModel> find(string idEntidad, List<string> searchFields, string cad, Boolean exacta)
        {
            string qry = @"
(
SELECT
    servicio,
    campo1,
    nombre,
    direccion,
    campo2,
    municipio,
    estado
FROM
    cfe{0}
WHERE
    {1}
)";
            string preFab = exacta ? string.Format(@"= '{0}'",cad) : string.Format(@"LIKE '%{0}%'",cad.Replace(" ","%"));
            string where = string.Empty;
            foreach (string item in searchFields)
	        {
		        switch (item.ToLower())
	            {
                    case "nombre":
                        where += string.Format (@"nombre {0}",preFab);
                    break;
                    case "servicio":
                        where += string.Format (@"{0} servicio {1}",!string.IsNullOrEmpty(where) ? " OR " : string.Empty,preFab);
                    break;
                    case "domicilio":
                        where += string.Format (@"{0} direccion {1}",!string.IsNullOrEmpty(where) ? " OR " : string.Empty,preFab);
                    break;                    
	            }
	        }

            dataList.Clear();

            if (idEntidad.Equals("00"))
            {
                for (int i = 1; i <= 32; i++)
                {
                    string qryFab = string.Format(qry, i.ToString("00"), where);

                    BackgroundWorker wrker = new BackgroundWorker();
                    wrker.WorkerSupportsCancellation = true;
                    wrker.DoWork += wrker_DoWork;
                    wrker.RunWorkerCompleted += wrker_RunWorkerCompleted;
                    wrker.RunWorkerAsync(qryFab);
                    wrkers.Add(wrker);
                }
            }
            else {
                string qryFab = string.Format(qry,idEntidad, where);
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
            List<CFEModel> data = null;
            try
            {
                bd.Database.CommandTimeout = 0;
                data = bd.Database.SqlQuery<CFEModel>(qry).ToList();
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
                List<CFEModel> data = (List<CFEModel>)e.Result;
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
