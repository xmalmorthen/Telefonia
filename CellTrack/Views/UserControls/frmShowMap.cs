using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Controllers;
using CellTrack.Models.DataBases;
using MetroFramework;
using GMap.NET.WindowsForms;
using GMap.NET;
using MetroFramework.Forms;

namespace CellTrack.Views.UserControls.Localización    
{
    public partial class frmShowMap : MetroForm
    {
        private gMapView gMapViewRender = new gMapView(19.255185, -103.688263);
        
        private investigationModel item {get; set;}

        public frmShowMap(investigationModel item)
        {
            InitializeComponent();

            this.item = item;
            this.investigationModelBindingSource.DataSource = item;
            this.detalleRecibidosModelBindingSource.DataSource = item.detalle;

            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            splitContainer.SplitterDistance = 100;            

            populate();

            gMapViewRender.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(gMapViewRender);
        }

        private void populate()
        {                      
            gMapViewRender.gMap.MarkersOverlays.Clear();
            gMapViewRender.gMap.TriangulationsOverlays.Clear();
            gMapViewRender.gMap.MainMap.Overlays.Clear();

            seguimientoModel obj = new seguimientoModel()
            {
                id = item.id,
                tipo = item.tipo,
                fIns = item.fIns,
                nombre = item.nombre,
                asunto = item.asunto,
                objetivo = item.objetivo,
                Carrier = item.Carrier,
                detalle = item.detalle
            };
            setMarker(obj);

            gMapViewRender.gMap.centerInMarkers();
        }

        private markersModel setMarker(seguimientoModel seguimientoModel)
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
                                              (gMapViewRender.gMap.MarkersOverlays.Markers.Count + 1).ToString(),
                                              seguimientoModel.detalle[0]);
                    gMapViewRender.gMap.CreateCircle(new System.Drawing.PointF((float)marker.Lat, (float)marker.Lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(Color.DarkRed, 2));
                    gMapViewRender.gMap.AddMarker(marker, MarkerTooltipMode.Always);
                }
                else if (seguimientoModel.detalle.Count > 1) {
                    List<PointLatLng> points = new List<PointLatLng>();

                    int iter = 1;
                    int group = 1;

                    Random randomGen = new Random();
                    KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                    foreach (detalleRecibidosModel reg in seguimientoModel.detalle)
                    {
                        Color fill = Color.Green, stroke = Color.Green;

                        if (group == 1 && iter == 1)
                        {
                            fill = Color.Green;
                            stroke = Color.Green;
                        }
                        else if (iter == 1)
                        {
                            KnownColor randomColorName = names[randomGen.Next(names.Length)];
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
                                              (gMapViewRender.gMap.MarkersOverlays.Markers.Count + 1).ToString(),
                                              reg);

                        gMapViewRender.gMap.CreateCircle(new System.Drawing.PointF(float.Parse(reg.LAT), float.Parse(reg.LNG)), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(stroke, 2));
                        gMapViewRender.gMap.AddMarker(marker, GMap.NET.WindowsForms.MarkerTooltipMode.Always);

                        points.Add(new PointLatLng(float.Parse(reg.LAT),float.Parse(reg.LNG)));

                        if (iter == 3)
                        {
                            gMapViewRender.gMap.CreateTriangulation(points, fill, stroke);
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

    }
}
