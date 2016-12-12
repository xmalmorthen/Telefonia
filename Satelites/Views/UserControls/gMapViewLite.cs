using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Satelites.Controllers;
using GMap.NET.WindowsForms;
using Satelites.Classes;
using GMap.NET.MapProviders;
using MetroFramework.Controls;
using Satelites.Models;
using GMap.NET;
using System.Configuration;
using Satelites.Models.CustomMarkers;
using GMap.NET.WindowsForms.Markers;

namespace Satelites.Views.UserControls
{
    public partial class gMapViewLite : UserControl
    {
        // layers
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");

        // marker
        GMapMarker currentMarker, tmpMarker;

        // polygons
        GMapPolygon polygon;

        // etc
        GMapMarkerRect CurentRectMarker = null;
        bool isMouseDown = false;

        public gMapViewLite(List<GMapMarker> Markers)
        {
            InitializeComponent();
            this.init(); 
           
            foreach (GMapMarker item in Markers)
	        {
                AddTarget(item);    
	        }

            MainMap.ZoomAndCenterMarkers("objects");
        }

#region EVENTS
        void MainMap_OnPositionChanged(PointLatLng point)
        {
            
        }

        void MainMap_OnTileLoadStart()
        {
            MethodInvoker m = delegate()
            {
                ((frmMain)this.ParentForm).frmState = enums.frmState.Proccessing;                
            };
            try
            {
                BeginInvoke(m);
            }
            catch
            {
            }
        }

        void MainMap_OnTileLoadComplete(long ElapsedMilliseconds)
        {
            MethodInvoker m = delegate()
            {
                ((frmMain)this.ParentForm).frmState = enums.frmState.Normal;
            };
            try
            {
                BeginInvoke(m);
            }
            catch
            {
            }
        }

        void MainMap_OnMapZoomChanged()
        {
            zoomTrackBar.Value = (int)(MainMap.Zoom * 100.0);
        }

        void MainMap_OnMapTypeChanged(GMapProvider type)
        {
            cmbMapsType.SelectedItem = type;

            zoomTrackBar.Minimum = MainMap.MinZoom * 100;
            zoomTrackBar.Maximum = MainMap.MaxZoom * 100;
            zoomTrackBar.Value = (int)(MainMap.Zoom * 100.0);
            zoomTrackBar.SmallChange = 100;

            MainMap.ZoomAndCenterMarkers("objects");
        }

        GMapMarker currentTransport;
        void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (item is GMapMarkerRect)
                {
                    GeoCoderStatusCode status;
                    var pos = GMapProviders.GoogleMap.GetPlacemark(item.Position, out status);
                    if (status == GeoCoderStatusCode.G_GEO_SUCCESS && pos != null)
                    {
                        GMapMarkerRect v = item as GMapMarkerRect;
                        {
                            v.ToolTipText = pos.Value.Address;
                        }
                        MainMap.Invalidate(false);
                    }
                }
                else
                {
                    if (item.Tag != null)
                    {
                        if (currentTransport != null)
                        {
                            currentTransport.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            currentTransport = null;
                        }
                        currentTransport = item;
                        currentTransport.ToolTipMode = MarkerTooltipMode.Always;
                    }
                }
            }
        }

        void MainMap_OnMarkerEnter(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Red;

                CurentRectMarker = rc;
            }
        }

        void MainMap_OnMarkerLeave(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.DarkGray;
            }
        }

        GMapPolygon currentPolygon = null;
        void MainMap_OnPolygonEnter(GMapPolygon item)
        {
            currentPolygon = item;
            item.Stroke.Color = Color.Red;
        }

        void MainMap_OnPolygonLeave(GMapPolygon item)
        {
            currentPolygon = null;
            item.Stroke.Color = Color.MidnightBlue;
        }

        GMapRoute currentRoute = null;
        void MainMap_OnRouteEnter(GMapRoute item)
        {
            currentRoute = item;
            item.Stroke.Color = Color.Red;
        }

        void MainMap_OnRouteLeave(GMapRoute item)
        {
            currentRoute = null;
            item.Stroke.Color = Color.MidnightBlue;
        }

        void MainMap_MouseMove(object sender, MouseEventArgs e)
        {

        }

        void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                if (currentMarker != null && currentMarker.IsVisible)
                {
                    currentMarker.Position = MainMap.FromLocalToLatLng(e.X, e.Y);

                    var px = MainMap.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int)MainMap.Zoom);
                    var tile = MainMap.MapProvider.Projection.FromPixelToTileXY(px);
                }
            }
        }

        void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        void MainMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var cc = new GMapMarkerCircle(MainMap.FromLocalToLatLng(e.X, e.Y));
            //objects.Markers.Add(cc);
        }

        void MainMap_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void cmbMapsType_DropDownClosed(object sender, EventArgs e)
        {
            MainMap.MapProvider = cmbMapsType.SelectedItem as GMapProvider;
        }

        private void zoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MainMap.Zoom = zoomTrackBar.Value / 100.0;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            MainMap.ReloadMap();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            MainMap.ZoomAndCenterMarkers("objects");
        }

#endregion EVENTS

#region FUNCTIONS
        void RegeneratePolygon()
        {
            List<PointLatLng> polygonPoints = new List<PointLatLng>();

            foreach (GMapMarker m in objects.Markers)
            {
                if (m is GMapMarkerRect)
                {
                    //m.Tag = polygonPoints.Count;
                    polygonPoints.Add(m.Position);
                }
            }

            if (polygon == null)
            {
                polygon = new GMapPolygon(polygonPoints, "polygon");
                polygon.IsHitTestVisible = true;
                polygons.Polygons.Add(polygon);
            }
            else
            {
                polygon.Points.Clear();
                polygon.Points.AddRange(polygonPoints);

                if (polygons.Polygons.Count == 0)
                {
                    polygons.Polygons.Add(polygon);
                }
                else
                {
                    MainMap.UpdatePolygonLocalPosition(polygon);
                }
            }
        }

        public void AddTarget(GMapMarker marker) {
            Bitmap pin = Properties.Resources.ResourceManager.GetObject("target_green", Properties.Resources.Culture) as Bitmap;
            GMarkerGoogle m = new GMarkerGoogle(marker.Position, pin);
            GMapMarkerRect mBorders = new GMapMarkerRect(marker.Position);
            {
                mBorders.InnerMarker = m;
                if (polygon != null)
                    mBorders.Tag = polygon.Points.Count;
                else
                    mBorders.Tag = 0;
                mBorders.ToolTipMode = MarkerTooltipMode.Always;
                mBorders.isActive = false;
            }
            Placemark? p = null;
            GeoCoderStatusCode status;
            var ret = GMapProviders.GoogleMap.GetPlacemark(marker.Position, out status);
            if (status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
                p = ret;
            if (p != null)
                mBorders.ToolTipText = p.Value.Address;
            else
                mBorders.ToolTipText = marker.Position.ToString();
            m.Tag = mBorders.Tag;
            objects.Markers.Add(m);
            objects.Markers.Add(mBorders);
            RegeneratePolygon();
        }

        public void AddTarjet(PointLatLng position)
        {
            Bitmap pin = Properties.Resources.ResourceManager.GetObject("tower_black", Properties.Resources.Culture) as Bitmap;

            GMarkerGoogle m = new GMarkerGoogle(position, pin);

            Placemark? p = null;

            GeoCoderStatusCode status;
            var ret = GMapProviders.GoogleMap.GetPlacemark(position, out status);
            if (status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
            {
                p = ret;
            }

            if (p != null)
            {
                m.ToolTipText = p.Value.Address;
            }
            else
            {
                m.ToolTipText = position.ToString();
            }

            objects.Markers.Add(m);
        }

#endregion FUNCTIONS

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            if (!GMapControl.IsDesignerHosted)
            {
                // add your custom map db provider
                GMap.NET.CacheProviders.MySQLPureImageCache ch = new GMap.NET.CacheProviders.MySQLPureImageCache();
                ch.ConnectionString = ConfigurationManager.ConnectionStrings["dbsatelitesEntities"].ToString();
                MainMap.Manager.SecondaryCache = ch;
                
                GMapProvider.UserAgent = "SATÉLITES";
                MainMap.Manager.Mode = AccessMode.ServerAndCache;
                MainMap.MapProvider = GMapProviders.OpenStreetMap;
                MainMap.Position = new PointLatLng(Properties.Settings.Default.MapInitPointLat, Properties.Settings.Default.MapInitPointLng);
                MainMap.MinZoom = 0;
                MainMap.MaxZoom = 24;
                MainMap.Zoom = 16;

                GMapToolTip.DefaultFormat.Alignment = StringAlignment.Near;
                GMapToolTip.DefaultStroke.Color = Color.Silver;

                // map events
                {
                    MainMap.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);

                    MainMap.OnTileLoadStart += new TileLoadStart(MainMap_OnTileLoadStart);
                    MainMap.OnTileLoadComplete += new TileLoadComplete(MainMap_OnTileLoadComplete);

                    MainMap.OnMapZoomChanged += new MapZoomChanged(MainMap_OnMapZoomChanged);
                    MainMap.OnMapTypeChanged += new MapTypeChanged(MainMap_OnMapTypeChanged);

                    MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
                    MainMap.OnMarkerEnter += new MarkerEnter(MainMap_OnMarkerEnter);
                    MainMap.OnMarkerLeave += new MarkerLeave(MainMap_OnMarkerLeave);

                    MainMap.OnPolygonEnter += new PolygonEnter(MainMap_OnPolygonEnter);
                    MainMap.OnPolygonLeave += new PolygonLeave(MainMap_OnPolygonLeave);

                    MainMap.OnRouteEnter += new RouteEnter(MainMap_OnRouteEnter);
                    MainMap.OnRouteLeave += new RouteLeave(MainMap_OnRouteLeave);

                    MainMap.MouseMove += new MouseEventHandler(MainMap_MouseMove);
                    MainMap.MouseDown += new MouseEventHandler(MainMap_MouseDown);
                    MainMap.MouseClick += new MouseEventHandler(MainMap_MouseClick);
                    MainMap.MouseUp += new MouseEventHandler(MainMap_MouseUp);
                    MainMap.MouseDoubleClick += new MouseEventHandler(MainMap_MouseDoubleClick);

                }

                cmbMapsType.ValueMember = "Name";
                cmbMapsType.DataSource = GMapProviders.List;
                cmbMapsType.SelectedItem = MainMap.MapProvider;

                zoomTrackBar.Minimum = MainMap.MinZoom * 100;
                zoomTrackBar.Maximum = MainMap.MaxZoom * 100;
                zoomTrackBar.Value = (int)(MainMap.Zoom * 100.0);
                zoomTrackBar.SmallChange = 100;

                // add custom layers  
                {
                    MainMap.Overlays.Add(routes);
                    MainMap.Overlays.Add(polygons);
                    MainMap.Overlays.Add(objects);
                    MainMap.Overlays.Add(top);
                }

                //currentMarker = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.arrow);
                //currentMarker.IsHitTestVisible = false;
                //top.Markers.Add(currentMarker);
            }
            
        }

    }
}
