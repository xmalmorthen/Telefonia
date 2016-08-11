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
    public static class seguimientoController
    {
        public static List<seguimientoModel> markObjetivos(gMapController controller, PDUModel tarjet, DateTime starDate, DateTime endDate, MarkerEnter OnMarkerEnter, MarkerLeave OnMarkerLeave)
        {
            controller.MarkersOverlays.Clear();
            controller.TriangulationsOverlays.Clear();
            controller.MainMap.Overlays.Clear();

            endDate = endDate.AddHours(24);

            List<mapdu> data = DALController.Db.mapdu.Where(qry => qry.malocalizations.idNotification.Equals(usuarioController.usuarioLogueado.info.id)
                && qry.malocalizations.id.Equals(tarjet.id)
                && (qry.fIns >= starDate && qry.fIns <= endDate)).ToList();


            List<seguimientoModel> seguimiento = new List<seguimientoModel>(data.Count());
            foreach (mapdu item in data)
            {
                List<detalleRecibidosModel>  detalle = new List<detalleRecibidosModel>();

                foreach (desmsrecibidos reg in item.desmsrecibidos)
                {
                    if (detalle.Find(qry => qry.LAT == reg.LAT.ToString() && qry.LNG == reg.LNG.ToString()) == null)
                    {
                        detalle.Add(new detalleRecibidosModel()
                        {
                            id = reg.id,
                            radio = reg.radio,
                            MCC = reg.MCC,
                            MNC = reg.MNC,
                            LAC = reg.LAC,
                            BTS = reg.BTS,
                            V = reg.V,
                            LAT = reg.LAT.ToString(),
                            LNG = reg.LNG.ToString()
                        });
                    }
                }

                seguimientoModel obj = new seguimientoModel()
                {
                    id = item.id,
                    tipo = item.tipo,
                    fIns = item.fIns.ToLongDateString(),
                    nombre = item.malocalizations.nombre,
                    asunto = item.malocalizations.asunto,
                    objetivo = item.malocalizations.objetivo,
                    Carrier = item.malocalizations.cacarriers.carrier,
                    detalle = detalle
                };
                seguimiento.Add(obj);
                setMarker(obj, controller);
            }

            controller.MainMap.ZoomAndCenterMarkers(null);

            controller.MainMap.OnMarkerEnter += OnMarkerEnter;
            controller.MainMap.OnMarkerLeave += OnMarkerLeave;

            return seguimiento;
        }

        private static markersModel setMarker(seguimientoModel seguimientoModel, gMapController controller)
        {
            markersModel marker = null;
            try
            {
                if (seguimientoModel.detalle.Count == 1)
                {
                    marker = new markersModel(Double.Parse(seguimientoModel.detalle[0].LAT),
                                              Double.Parse(seguimientoModel.detalle[0].LNG),
                                              string.Format("{0} [ {1} ] - {2} {3} LAT: {4} - LNG: {5} {6} {7}",
                                                        seguimientoModel.nombre,
                                                        seguimientoModel.objetivo,
                                                        seguimientoModel.Carrier,
                                                        Environment.NewLine,
                                                        seguimientoModel.detalle[0].LAT,
                                                        seguimientoModel.detalle[0].LNG,
                                                        Environment.NewLine,
                                                        seguimientoModel.fIns),
                                              (controller.MarkersOverlays.Markers.Count + 1).ToString(),
                                              seguimientoModel.detalle[0]);
                    controller.CreateCircle(new System.Drawing.PointF((float)marker.Lat, (float)marker.Lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(Color.DarkRed, 2));
                    controller.AddMarker(marker, MarkerTooltipMode.OnMouseOver);
                }
                else if (seguimientoModel.detalle.Count > 1) {
                    List<PointLatLng> points = new List<PointLatLng>();

                    int iter = 1;
                    int group = 1;

                    Random randomGen = new Random();
                    KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                    KnownColor randomColorName = KnownColor.Green;
                    foreach (detalleRecibidosModel reg in seguimientoModel.detalle)
                    {
                        Color fill = Color.Green, stroke = Color.Green;

                        if (group == 1 && iter <= 3)
                        {
                            fill = Color.Green;
                            stroke = Color.Green;
                        }
                        else if (iter == 1)
                        {
                            randomColorName = names[randomGen.Next(names.Length)];
                            fill = stroke = Color.FromKnownColor(randomColorName);
                        }
                        else {
                            fill = stroke = Color.FromKnownColor(randomColorName);
                        }

                        marker = new markersModel(Double.Parse(reg.LAT),
                                              Double.Parse(reg.LNG),
                                              string.Format("{0} [ {1} ] - {2} {3} LAT: {4} - LNG: {5} {6} {7}",
                                                        seguimientoModel.nombre,
                                                        seguimientoModel.objetivo,
                                                        seguimientoModel.Carrier,
                                                        Environment.NewLine,
                                                        reg.LAT,
                                                        reg.LNG,
                                                        Environment.NewLine,
                                                        seguimientoModel.fIns),
                                              (controller.MarkersOverlays.Markers.Count + 1).ToString(),
                                              reg);

                        controller.CreateCircle(new System.Drawing.PointF(float.Parse(reg.LAT), float.Parse(reg.LNG)), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(stroke, 2));
                        controller.AddMarker(marker, GMap.NET.WindowsForms.MarkerTooltipMode.OnMouseOver);

                        points.Add(new PointLatLng(float.Parse(reg.LAT),float.Parse(reg.LNG)));

                        if (iter == 3)
                        {
                            controller.CreateTriangulation(points, fill, stroke);
                            points.Clear();
                        }

                        group = iter == 3 ? group + 1 : group;
                        iter = iter < 3 ? iter + 1 : 1;
                    }
                
                }
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
                foreach (seguimientoModel item in targets)
                {
                    int iter = 1;
                    foreach (detalleRecibidosModel det in item.detalle)
                    {
                        item.LAT += det.LAT;
                        item.LNG += det.LNG;

                        item.LAT += iter < item.detalle.Count() ? Environment.NewLine : "";
                        item.LNG += iter < item.detalle.Count() ? Environment.NewLine : "";
                        
                        iter++;
                    }
                }

                frmReportViewer frmRpt = new frmReportViewer();
                gMapStaticImageGenerate frm = new gMapStaticImageGenerate(controller);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes) {
                    ReportDataSource rds = new ReportDataSource("seguimientoReport", targets.ToList());
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
