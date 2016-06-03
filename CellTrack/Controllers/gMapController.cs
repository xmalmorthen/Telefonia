using CellTrack.Models;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Controllers
{
    public class gMapController
    {
        private GMapControl mainMap = new GMapControl();
        public GMapControl MainMap
        {
            get { return  mainMap; }
            set {  mainMap = value; }
        }

        private GMapOverlay markersOverlays = new GMapOverlay("Markers");
        public GMapOverlay MarkersOverlays
        {
            get { return  markersOverlays; }
            set {  markersOverlays = value; }
        }

        private GMapOverlay triangulationsOverlays = new GMapOverlay("Triangulations");
        public GMapOverlay TriangulationsOverlays
        {
            get { return triangulationsOverlays; }
            set { triangulationsOverlays = value; }
        }

        public gMapController(Double lat, Double lng, Double zoom)
        {
            MainMap.Dock = DockStyle.Fill;
            if (!GMapControl.IsDesignerHosted)
            {
                try
                {
                    System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                    MainMap.Manager.Mode = AccessMode.ServerAndCache;
                }
                catch
                {
                    GMap.NET.CacheProviders.MySQLPureImageCache ch = new GMap.NET.CacheProviders.MySQLPureImageCache();

                    ch.ConnectionString = Properties.Settings.Default.MapCache;
                    MainMap.Manager.SecondaryCache = ch;
                    MainMap.Manager.Mode = AccessMode.CacheOnly;
                }

                // config map         
                MainMap.MapProvider = GMapProviders.OpenStreetMap;
                MainMap.Position = new PointLatLng(lat, lng);
                MainMap.MinZoom = 1;
                MainMap.MaxZoom = 24;
                MainMap.Zoom = zoom;

                //MainMap.ScaleMode = ScaleModes.Fractional;
            }
        }

        ~gMapController() {
            try
            {
                MarkersOverlays.Dispose();
                MarkersOverlays = null;
                MainMap.Dispose();
                MainMap = null;
            }
            catch (Exception)
            {
            }
        }

        public void AddMarker(double lat, double lng, string txt)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.target_red);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = txt;
            MarkersOverlays.Markers.Add(marker);
            MainMap.Overlays.Add(MarkersOverlays);
        }

        public void AddMarker(markersModel mark)
        {
            AddMarker(mark.Lat, mark.Lng, mark.Desc);
        }

        public void AddMarker(List<markersModel> markers)
        {
            foreach (markersModel item in markers)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(item.Lat,item.Lng), GMarkerGoogleType.red);
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = item.Desc;
                MarkersOverlays.Markers.Add(marker);
            }
            MainMap.Overlays.Add(MarkersOverlays);
        }

        public void setPosition(double lat, double lng)
        {
            MainMap.Position = new PointLatLng(lat,lng);
        }

        public void setPosition(markersModel mark, int? zoom = null)
        {
            MainMap.Position = new PointLatLng(mark.Lat,mark.Lng);
            this.zoom(zoom.GetValueOrDefault(Convert.ToInt16(MainMap.Zoom)));
        }

        public void zoom(int value) {
            MainMap.Zoom = value;
        }

        public void centerInMarkers() {
            double zoom = MainMap.Zoom;
            MainMap.ZoomAndCenterMarkers("Markers");
            MainMap.Zoom = zoom;
        }

        public void CreateCircle(PointF point, double radius, int segments)
        {
            List<PointLatLng> gpollist = new List<PointLatLng>();
            double seg = Math.PI * 2 / segments;

            int y = 0;
            for (int i = 0; i < segments; i++)
            {
                double theta = seg * i;
                double a = point.X + Math.Cos(theta) * radius;
                double b = point.Y + Math.Sin(theta) * radius;
                PointLatLng gpoi = new PointLatLng(a, b);
                gpollist.Add(gpoi);
            }
            GMapPolygon gpol = new GMapPolygon(gpollist, "Triangulacion");
            gpol.Fill = new SolidBrush(Color.FromArgb(100,100,100,100));
            gpol.Stroke = new Pen(Color.Red, 1);
            TriangulationsOverlays.Polygons.Add(gpol);
            MainMap.Overlays.Add(TriangulationsOverlays);
        }

    }
}
