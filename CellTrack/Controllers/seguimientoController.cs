using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class seguimientoController
    {
        public static int markObjetivos(gMapController controller, DateTime starDate, DateTime endDate, MarkerEnter OnMarkerEnter, MarkerLeave OnMarkerLeave)
        {
            controller.MarkersOverlays.Clear();
            controller.TriangulationsOverlays.Clear();
            controller.MainMap.Overlays.Clear();

            List<mapdu> data = DAL.Db.mapdu.Where(qry => qry.malocalizations.idNotification.Equals(usuarioController.usuarioLogueado.info.id)
                && (qry.fIns >= starDate && qry.fIns <= endDate)).ToList();
            List<seguimientoModel> seguimiento = new List<seguimientoModel>(data.Count());
            foreach (mapdu item in data)
            {
                seguimientoModel obj = new seguimientoModel()
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
                };
                seguimiento.Add(obj);
                setMarker(obj, controller);
            }
            controller.centerInMarkers();

            controller.MainMap.OnMarkerEnter += OnMarkerEnter;
            controller.MainMap.OnMarkerLeave += OnMarkerLeave;

            return data.Count;
        }

        

        private static markersModel setMarker(seguimientoModel seguimientoModel, gMapController controller)
        {
            markersModel marker = null;
            try
            {
                marker = new markersModel(Double.Parse(seguimientoModel.LAT),
                                          Double.Parse(seguimientoModel.LNG), 
                                          string.Format("{0} [ {1} ] - {2} {3} LAT: {4} - LNG: {5}",seguimientoModel.nombre,seguimientoModel.objetivo,seguimientoModel.Carrier,Environment.NewLine,seguimientoModel.LAT,seguimientoModel.LNG),
                                          seguimientoModel);
                controller.CreateCircle(new System.Drawing.PointF((float)marker.Lat, (float)marker.Lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(Color.DarkRed, 2));
                controller.AddMarker(marker, MarkerTooltipMode.OnMouseOver);
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return marker;
        }
    }
}
