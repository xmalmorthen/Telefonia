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
        #region GETERS - SETTERS

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

        #endregion GETERS - SETTERS

        #region CONSTRUCTOR - DESTRUCTOR

        public gMapController(Double lat, Double lng, Double zoom)
        {
            MainMap.Dock = DockStyle.Fill;
            MainMap.DragButton = MouseButtons.Left;

            if (!GMapControl.IsDesignerHosted)
            {
                try
                {
                    GMap.NET.CacheProviders.MySQLPureImageCache ch = new GMap.NET.CacheProviders.MySQLPureImageCache();

                    //ch.ConnectionString = Properties.Settings.Default.MapCache;
                    //MainMap.Manager.SecondaryCache = ch;

                    System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                    MainMap.Manager.Mode = AccessMode.ServerAndCache;
                }
                catch
                {
                    MainMap.Manager.Mode = AccessMode.ServerAndCache;
                }

                // config map         
                MainMap.MapProvider = GMapProviders.OpenStreetMap;
                MainMap.Position = new PointLatLng(lat, lng);
                MainMap.MinZoom = 1;
                MainMap.MaxZoom = 24;
                MainMap.Zoom = zoom;
                MainMap.ScaleMode = ScaleModes.Integer;
            }
        }

        ~gMapController() {
            try
            {
                MarkersOverlays.Dispose();
                MarkersOverlays = null;
                TriangulationsOverlays.Dispose();
                TriangulationsOverlays = null;
                MainMap.Dispose();
                MainMap = null;
            }
            catch (Exception)
            {
            }
        }

        public void Dispose(){
            MarkersOverlays.Dispose();
            MarkersOverlays = null;
            TriangulationsOverlays.Dispose();
            TriangulationsOverlays = null;
            MainMap.Dispose();
            MainMap = null;
        }

        #endregion CONSTRUCTOR - DESTRUCTOR

        public void zoom(int value)
        {
            MainMap.Zoom = value;
        }

        public void centerInMarkers()
        {
            double zoom = MainMap.Zoom;
            MainMap.ZoomAndCenterMarkers("Markers");
            MainMap.Zoom = zoom;
        }

        public void changeMapType(GMapProvider type)
        {
            MainMap.MapProvider = type;
        }

        public void setPosition(double lat, double lng)
        {
            MainMap.Position = new PointLatLng(lat, lng);
        }

        public void setPosition(markersModel mark, int? zoom = null)
        {
            MainMap.Position = new PointLatLng(mark.Lat, mark.Lng);
            this.zoom(zoom.GetValueOrDefault(Convert.ToInt16(MainMap.Zoom)));
        }

        #region MARKERS

        private GMarkerGoogle configMarker(double lat, double lng, MarkerTooltipMode toolTipMode, object tag, string mrkLabel = null)
        {
            Bitmap ret = Properties.Resources.ResourceManager.GetObject("target_red", Properties.Resources.Culture) as Bitmap;
            if (!string.IsNullOrEmpty(mrkLabel))
            {
                PointF loc = new PointF(0f, 0f);
                using (Graphics graphics = Graphics.FromImage(ret))
                {
                    using (Font arialFont = new Font("Arial", 18))
                    {
                        graphics.DrawString(mrkLabel, arialFont, Brushes.Black, loc);
                    }
                }
            }
            GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), ret);
            
            if (tag != null)
                marker.Tag = tag;

            if (toolTipMode != MarkerTooltipMode.Never)
            {
                GMapToolTip toolTip = new GMapToolTip(marker);
                toolTip.Format.Alignment = StringAlignment.Near;
                toolTip.Stroke = new Pen(Color.FromArgb(140, Color.DarkRed));
                toolTip.Fill = new SolidBrush(Color.FromArgb(200, Color.WhiteSmoke));
                toolTip.Foreground = new SolidBrush(Color.DarkRed);
                toolTip.TextPadding = new Size(12, 12);
                marker.ToolTip = toolTip;
                marker.ToolTipMode = toolTipMode;
            }
            return marker;
        }

        private void _addMarker(double lat, double lng, string tooltipText, MarkerTooltipMode toolTipMode, object tag, string mrkLabel = null)
        {
            GMarkerGoogle marker = configMarker(lat, lng, toolTipMode, tag, mrkLabel);
            if (!string.IsNullOrEmpty(tooltipText))
                marker.ToolTipText = tooltipText;
            MarkersOverlays.Markers.Add(marker);
            MainMap.Overlays.Add(MarkersOverlays);
        }

        public void AddMarker(double lat, double lng){
            _addMarker(lat, lng,string.Empty, MarkerTooltipMode.Never,null);
        }

        public void AddMarker(double lat, double lng, string tooltipText){
            _addMarker(lat, lng, tooltipText, MarkerTooltipMode.Always,null);
        }

        public void AddMarker(double lat, double lng, string tooltipText, MarkerTooltipMode toolTipMode)
        {
            _addMarker(lat, lng, tooltipText, toolTipMode,null);
        }

        public void AddMarker(double lat, double lng, string tooltipText, MarkerTooltipMode toolTipMode, object tag)
        {
            _addMarker(lat, lng, tooltipText, toolTipMode, tag);
        }

        public void AddMarker(double lat, double lng, string tooltipText, string mrkLabel, MarkerTooltipMode toolTipMode, object tag)
        {
            _addMarker(lat, lng, tooltipText, toolTipMode, tag, mrkLabel);
        }

        public void AddMarker(markersModel mark){
            AddMarker(mark.Lat, mark.Lng);
        }

        public void AddMarker(markersModel mark, MarkerTooltipMode toolTipMode){
            AddMarker(mark.Lat, mark.Lng, mark.Desc, mark.MrkLabel, toolTipMode, mark.Tag);
        }        

        private void _addMarker(List<markersModel> markers, MarkerTooltipMode toolTipMode)
        {
            foreach (markersModel item in markers)
            {
                GMarkerGoogle marker = configMarker(item.Lat, item.Lng, MarkerTooltipMode.Always, item.Tag);
                marker.ToolTipText = item.Desc;
                MarkersOverlays.Markers.Add(marker);
            }
            MainMap.Overlays.Add(MarkersOverlays);
        }

        public void AddMarker(List<markersModel> markers)
        {
            _addMarker(markers, MarkerTooltipMode.Always);            
        }

        public void AddMarker(List<markersModel> markers, MarkerTooltipMode toolTipMode)
        {
            _addMarker(markers, toolTipMode);
        }

        #endregion MARKERS

        #region POLIGONS
        
        private GMapPolygon createCircle(PointF point, double radius, int segments) {
            List<PointLatLng> gpollist = new List<PointLatLng>();
            double seg = Math.PI * 2 / segments;
            radius = radius / 10000;
            int y = 0;
            for (int i = 0; i < segments; i++)
            {
                double theta = seg * i;
                double a = point.X + Math.Cos(theta) * radius;
                double b = point.Y + Math.Sin(theta) * radius;
                PointLatLng gpoi = new PointLatLng(a, b);
                gpollist.Add(gpoi);
            }
            return new GMapPolygon(gpollist, "Triangulacion");
        }

        public void CreateCircle(PointF point, double radius, int segments, Color fillColor, Pen stroke )
        {
            GMapPolygon gpol = createCircle(point,radius,segments);
            gpol.Fill = new SolidBrush(fillColor);
            gpol.Stroke = stroke;
            TriangulationsOverlays.Polygons.Add(gpol);
            MainMap.Overlays.Add(TriangulationsOverlays);
        }

        public void CreateCircle(PointF point, double radius, int segments, Pen stroke)
        {
            GMapPolygon gpol = createCircle(point, radius, segments);
            gpol.Fill = new SolidBrush(Color.FromArgb(0,0,0,0));
            gpol.Stroke = stroke;
            TriangulationsOverlays.Polygons.Add(gpol);
            MainMap.Overlays.Add(TriangulationsOverlays);
        }

        public void CreateTriangulation(List<PointLatLng> points, Color colorFill, Color colorStroke)
        {
            GMapPolygon gpol = new GMapPolygon(points, "Triangulacion");
            gpol.Fill = new SolidBrush(Color.FromArgb(30, colorFill));
            gpol.Stroke = new Pen(colorStroke, 1);
            TriangulationsOverlays.Polygons.Add(gpol);
            MainMap.Overlays.Add(TriangulationsOverlays);
        }
        
        #endregion POLIGONS

    }
}
