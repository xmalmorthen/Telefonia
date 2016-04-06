using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GSMApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Controllers
{
    static class gMap
    {
        private static GMapControl mainMap = new GMapControl();
        public static GMapControl MainMap
        {
            get { return gMap.mainMap; }
            set { gMap.mainMap = value; }
        }

        private static GMapOverlay overlays = new GMapOverlay();
        public static GMapOverlay Overlays
        {
            get { return gMap.overlays; }
            set { gMap.overlays = value; }
        }

        public static GMapControl initMap()
        {            
            MainMap.Dock = DockStyle.Fill;
            if (!GMapControl.IsDesignerHosted)
            {
                GMap.NET.CacheProviders.MsSQLPureImageCache ch = new GMap.NET.CacheProviders.MsSQLPureImageCache();
                ch.ConnectionString = GSMApplication.Properties.Settings.Default.GSMPIConnectionString;
                ch.Initialize();
                MainMap.Manager.SecondaryCache = ch;

                try
                {
                    System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                }
                catch
                {
                    MainMap.Manager.Mode = AccessMode.CacheOnly;
                    MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public static void AddMarker(double lat, double lng)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.green_pushpin);
            Overlays.Markers.Add(marker);
            MainMap.Overlays.Add(Overlays);
        }

        public static void AddMarker(List<MarkersModel> markers)
        {
            foreach (MarkersModel item in markers)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(item.Lat,item.Lng), GMarkerGoogleType.green_pushpin);
                Overlays.Markers.Add(marker);
            }
            MainMap.Overlays.Add(Overlays);    
        }


    }
}
