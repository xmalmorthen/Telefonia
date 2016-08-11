using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class investigacionController
    {
        public static List<investigationModel> Find(PDUModel item)
        {
            List<investigationModel> returnResult = null;
            try
            {
                List<mapdu> regs = DALController.Db.mapdu.Where(qry => qry.malocalizations.isDeleted.Equals(false) && qry.malocalizations.objetivo.Equals(item.obj.objetivo) ).ToList();

                if (regs.Count > 0) returnResult = new List<investigationModel>();

                foreach (mapdu reg in regs)
                {
                    List<detalleRecibidosModel> detalle = new List<detalleRecibidosModel>();
                    foreach (desmsrecibidos det in reg.desmsrecibidos)
                    {
                        detalle.Add(new detalleRecibidosModel()
                        {
                            BTS = det.BTS,
                            id = det.id,
                            LAC = det.LAC,
                            LAT = det.LAT.ToString(),
                            LNG = det.LNG.ToString(),
                            MCC = det.MCC,
                            MNC = det.MNC,
                            radio = det.radio,
                            V = det.V
                        });
                    }
                    returnResult.Add(new investigationModel()
                    {
                        asunto = reg.malocalizations.asunto,
                        Carrier = reg.malocalizations.cacarriers.carrier,
                        detalle = detalle,
                        fIns = string.Format("{0} {1}",reg.fIns.ToLongDateString(),reg.fIns.ToLongTimeString()),
                        id = reg.id,
                        nombre = reg.malocalizations.nombre,
                        objetivo = reg.malocalizations.objetivo,
                        tipo = reg.tipo
                    });
                }
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }

            return returnResult;
        }

    }
}
