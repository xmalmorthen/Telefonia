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
    public static class NEXTELController
    {
        private static List<NEXTELModel> dataList = new List<NEXTELModel>();
        private static List<BackgroundWorker> wrkers = new List<BackgroundWorker>();

        public static List<NEXTELModel> find(List<string> searchFields, string cad, Boolean exacta)
        {
            string qry = @"
(
SELECT
    radio,
    empresa,
    rfc,
    empresa1,
    tipocta,
    direccion,
    colonia,
    cpostal,
    telefono,
    direccion1,
    colonia1,
    ciudad,
    estado,
    cpostal1,
    telefono1,
    nombre,
    telefono2,
    empresa3,
    digitos,
    telefono3,
    registro
FROM
    nextel
WHERE
    {0}
)";
            string preFab = exacta ? string.Format(@"= '{0}'",cad) : string.Format(@"LIKE '%{0}%'",cad.Replace(" ","%"));
            string where = string.Empty;
            foreach (string item in searchFields)
	        {
		        switch (item.ToLower())
	            {
                    case "radio":
                        where += string.Format(@"radio {0}", preFab);
                    break;
                    case "empresa":
                        where += string.Format(@"{0} empresa {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                        where += string.Format(@"{0} empresa1 {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                        where += string.Format(@"{0} empresa3 {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                    break;
                    case "nombre":
                        where += string.Format(@"{0} nombre {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                    break;
                    case "domicilio":
                        where += string.Format(@"{0} direccion {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                        where += string.Format(@"{0} direccion1 {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                    break;
                    case "telefono":
                    where += string.Format(@"{0} telefono {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                    where += string.Format(@"{0} telefono1 {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                    where += string.Format(@"{0} telefono2 {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                    where += string.Format(@"{0} telefono3 {1}", !string.IsNullOrEmpty(where) ? " OR " : string.Empty, preFab);
                    break;
	            }
	        }

            dataList.Clear();

            string qryFab = string.Format(qry, where);
            BackgroundWorker wrker = new BackgroundWorker();
            wrker.WorkerSupportsCancellation = true;
            wrker.DoWork += wrker_DoWork;
            wrker.RunWorkerCompleted += wrker_RunWorkerCompleted;
            wrker.RunWorkerAsync(qryFab);
            wrkers.Add(wrker);

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
            List<NEXTELModel> data = null;
            try
            {
                bd.Database.CommandTimeout = 0;
                data = bd.Database.SqlQuery<NEXTELModel>(qry).ToList();
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            e.Result = data;
        }

        private static void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                List<NEXTELModel> data = (List<NEXTELModel>)e.Result;
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
