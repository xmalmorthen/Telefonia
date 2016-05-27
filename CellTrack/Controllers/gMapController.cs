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
    static class gMapController
    {
        private static GMapControl mainMap = new GMapControl();
        public static GMapControl MainMap
        {
            get { return gMapController.mainMap; }
            set { gMapController.mainMap = value; }
        }

        private static GMapOverlay overlays = new GMapOverlay();
        public static GMapOverlay Overlays
        {
            get { return gMapController.overlays; }
            set { gMapController.overlays = value; }
        }

        public static GMapControl initMap()
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
                    throw;
                }

                // config map         
                MainMap.MapProvider = GMapProviders.OpenStreetMap;
                MainMap.Position = new PointLatLng(19.255185, -103.688263);
                MainMap.MinZoom = 0;
                MainMap.MaxZoom = 24;
                MainMap.Zoom = 9;

                MainMap.ScaleMode = ScaleModes.Fractional;
            }
            return MainMap;            
        }

        public static void AddMarker(double lat, double lng, string txt)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.red);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = txt;
            Overlays.Markers.Add(marker);
            MainMap.Overlays.Add(Overlays);
        }

        public static void AddMarker(markersModel mark)
        {
            AddMarker(mark.Lat, mark.Lng, mark.Desc);
        }

        public static void AddMarker(List<markersModel> markers)
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

        public static void setPosition(double lat, double lng)
        {
            MainMap.Position = new PointLatLng(lat,lng);
        }

        public static void setPosition(markersModel mark)
        {
            MainMap.Position = new PointLatLng(mark.Lat,mark.Lng);
        }

        public static void zoom(byte value) { 
            
        }


    }
}
