using CellTrack.Models;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
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

        private GMapOverlay overlays = new GMapOverlay("Markers");
        public GMapOverlay Overlays
        {
            get { return  overlays; }
            set {  overlays = value; }
        }

        public gMapController(Double lat, Double lng, Double zoom)
        {
            MainMap.Dock = DockStyle.Fill;
            if (!GMapControl.IsDesignerHosted)
            {
                try
                {
                    System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                }
                catch
                {
                    
                    //GMap.NET.CacheProviders.SQLitePureImageCache MySQLPureImageCache ch = new GMap.NET.CacheProviders.MySQLPureImageCache();
                    //ch.ConnectionString = @"server=sql2008;User Id=trolis;Persist Security Info=True;database=gmapnetcache;password=trolis;";
                    //MainMap.Manager.SecondaryCache = ch;

                    //throw;
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
                Overlays.Dispose();
                Overlays = null;
                MainMap.Dispose();
                MainMap = null;
            }
            catch (Exception)
            {
            }
        }

        public void AddMarker(double lat, double lng, string txt)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.red);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = txt;
            Overlays.Markers.Add(marker);
            MainMap.Overlays.Add(Overlays);
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
                Overlays.Markers.Add(marker);
            }
            MainMap.Overlays.Add(Overlays);
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
            MainMap.ZoomAndCenterMarkers("Markers");
        }

    }
}
