using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using CellTrack.Views;
using GMap.NET;
using GMap.NET.WindowsForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace CellTrack.Controllers
{
    public static class toNotifyController
    {
        private static Boolean inProc = false;

        public static void doProccess() {
            if (inProc) return;

            inProc = true;

            mapdu data = DALController.Db.mapdu.FirstOrDefault(qry => qry.malocalizations.idNotification.Equals(usuarioController.usuarioLogueado.info.id)
                && qry.toNotify.Equals(true));

            if (data == null) {
                inProc =false;
                return;
            }

            PDUModel item = new PDUModel()
            {
                id = data.id,
                descrip = string.Empty,
                obj = new malocalizations() { 
                    id = data.malocalizations.id,
                    objetivo = data.malocalizations.objetivo
                }
            };

            markersModel marker = PDUController.PDUFind(item, null,true);
            if (marker != null) { 
                string msg = string.Format(Environment.NewLine + "Nombre: {0}{1}Asunto: {2}{3}Objetivo: {4}",data.malocalizations.nombre,Environment.NewLine,data.malocalizations.asunto,Environment.NewLine,data.malocalizations.objetivo);
                Program.FrmDashboard.showAlert(msg,"Objetivo encontrado", item.id);
            };

            inProc = false;
        }
    }
}
