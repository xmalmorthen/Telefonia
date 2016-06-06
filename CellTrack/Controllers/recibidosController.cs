using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class recibidosController
    {
        public static List<recibidosModel> smsRecibidos
        {
            get {
                List<mapdu> data = DAL.Db.mapdu.Where(qry => qry.malocalizations.idNotification.Equals(usuarioController.usuarioLogueado.info.id) && qry.toNotify.Equals(true)).ToList();
                //List<masmsrecibidos> data = DAL.Db.masmsrecibidos.ToList();                
                List<recibidosModel> recibidos = new List<recibidosModel>(data.Count());
                foreach (mapdu item in data)
                {
                    recibidos.Add(new recibidosModel()
                    {
                        id = item.id,
                        tipo = item.tipo,
                        idDetalle = item.idDetalle,
                        radio = item.desmsrecibidos.radio,
                        MCC = item.desmsrecibidos.MCC,
                        MNC = item.desmsrecibidos.MNC,
                        LAC = item.desmsrecibidos.LAC,
                        BTS = item.desmsrecibidos.BTS,
                        V = item.desmsrecibidos.V,
                        LAT = item.desmsrecibidos.LAT.ToString(),
                        LNG = item.desmsrecibidos.LNG.ToString(),
                        idLocalizations = item.idLocalizations,
                        idUser = item.malocalizations.idUser,
                        nombre = item.malocalizations.nombre,
                        asunto = item.malocalizations.asunto,
                        objetivo = item.malocalizations.objetivo,
                        Carrier = item.malocalizations.cacarriers.carrier,
                        fIns = item.fIns.ToLongDateString()
                    });
                }
                return recibidos;
            }
        }

        public static List<recibidosModel> smsRecibidosByObjetivo(string objetivo)
        {
            return smsRecibidos.Where(qry => qry.objetivo.Equals(objetivo) ).ToList();
        }


        internal static markersModel setMarker(recibidosModel recibidosModel, gMapController controller)
        {
            markersModel marker = null;
            try
            {
                controller.MarkersOverlays.Clear();
                controller.TriangulationsOverlays.Clear();
                controller.MainMap.Overlays.Clear();

                marker = new markersModel(Double.Parse(recibidosModel.LAT),Double.Parse(recibidosModel.LNG), string.Format("{0} [ {1} ] - {2}",recibidosModel.nombre,recibidosModel.objetivo,recibidosModel.Carrier));
                controller.CreateCircle(new System.Drawing.PointF((float)marker.Lat, (float)marker.Lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, Color.FromArgb(80, 153, 0, 0),new Pen(Color.DarkRed, 2));
                controller.AddMarker(marker);
                controller.setPosition(marker);
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return marker;
        }
    }
}
