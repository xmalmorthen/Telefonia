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

            mapdu data = DAL.Db.mapdu.FirstOrDefault(qry => qry.malocalizations.idNotification.Equals(usuarioController.usuarioLogueado.info.id)
                && qry.toNotify.Equals(true));

            if (data == null) return;

            PDUModel item = new PDUModel()
            {
                id = data.id,
                obj = new malocalizations() { 
                    id = data.malocalizations.id,
                    objetivo = data.malocalizations.objetivo
                }
            };

            PDUController.PDUFind(item, null,true);

            inProc = false;
        }
    }
}
