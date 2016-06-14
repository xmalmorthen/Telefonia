using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using CellTrack.Views;
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
    public static class seguimientoController
    {
        public static List<seguimientoModel> markObjetivos(gMapController controller, DateTime starDate, DateTime endDate, MarkerEnter OnMarkerEnter, MarkerLeave OnMarkerLeave)
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

            return seguimiento;
        }

        private static markersModel setMarker(seguimientoModel seguimientoModel, gMapController controller)
        {
            markersModel marker = null;
            try
            {
                marker = new markersModel(Double.Parse(seguimientoModel.LAT),
                                          Double.Parse(seguimientoModel.LNG),
                                          string.Format("{0} [ {1} ] - {2} {3} LAT: {4} - LNG: {5} {6} {7}", 
                                                    seguimientoModel.nombre, 
                                                    seguimientoModel.objetivo,
                                                    seguimientoModel.Carrier, 
                                                    Environment.NewLine, 
                                                    seguimientoModel.LAT, 
                                                    seguimientoModel.LNG, 
                                                    Environment.NewLine,
                                                    seguimientoModel.fIns),
                                          (controller.MarkersOverlays.Markers.Count + 1).ToString(),
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

        public static void makeReport(gMapController controller,List<seguimientoModel> targets)
        {
            try
            {
                gMapStaticImageGenerate frm = new gMapStaticImageGenerate(controller);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes) {

                    ReportDataSource rds = new ReportDataSource("seguimientoReport", targets.ToList());

                    frmReportViewer frmRpt = new frmReportViewer();

                    frmRpt.reportViewer.LocalReport.ReportEmbeddedResource = "CellTrack.Reports.seguimientoReport.rdlc";

                    frmRpt.reportViewer.LocalReport.SetParameters(new ReportParameter("txtSegTitle", string.Format("{0} | {1} | {2}", targets[0].objetivo, targets[0].nombre, targets[0].Carrier), true));
                    frmRpt.reportViewer.LocalReport.SetParameters(new ReportParameter("txtSegTitle2", string.Format("{0}", targets[0].asunto), true));


                    frmRpt.reportViewer.LocalReport.EnableExternalImages = true;
                    frmRpt.reportViewer.LocalReport.SetParameters(new ReportParameter("mapImage", "file:///" + frm.FullPathMap, true));
                    
                    frmRpt.reportViewer.LocalReport.DataSources.Add(rds);

                    frmRpt.reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    frmRpt.reportViewer.ZoomPercent = 100;
                    frmRpt.reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
                    
                    frmRpt.reportViewer.LocalReport.Refresh();
                    
                    frmRpt.ShowDialog();            
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        
    }
}
