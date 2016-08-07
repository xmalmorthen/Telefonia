using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace HLR.Views.UserControls
{
    public partial class mapViewer : MetroUserControl
    {
        public GMapControl Map = new GMapControl();

        public mapViewer()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            this.initMap();
            this.initCmb();
            this.initTrackBar();
        }

        private void initTrackBar()
        {
            tkBarZoom.Minimum = Map.MinZoom;
            tkBarZoom.Maximum = Map.MaxZoom;
        }

        private void initCmb()
        {
            cmbMapsTypes.ValueMember = "Name";
            cmbMapsTypes.DataSource = GMapProviders.List;
            cmbMapsTypes.SelectedItem = Map.MapProvider;
        }

        private void initMap()
        {
            Map.Dock = DockStyle.Fill;
            Map.DragButton = MouseButtons.Left;

            if (!GMapControl.IsDesignerHosted)
            {
                try
                {
                    GMap.NET.CacheProviders.MySQLPureImageCache ch = new GMap.NET.CacheProviders.MySQLPureImageCache();

                    //ch.ConnectionString = Properties.Settings.Default.MapCache;
                    //MainMap.Manager.SecondaryCache = ch;

                    System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                    Map.Manager.Mode = AccessMode.ServerAndCache;
                }
                catch
                {
                    Map.Manager.Mode = AccessMode.ServerAndCache;
                }

                // config map         
                Map.MapProvider = GMapProviders.OpenStreetMap;
                Map.Position = new PointLatLng(Properties.Settings.Default.MapInitPointLat, Properties.Settings.Default.MapInitPointLng);
                Map.MinZoom = 1;
                Map.MaxZoom = 24;
                Map.Zoom = tkBarZoom.Value;
                Map.ScaleMode = ScaleModes.Integer;
            }

            this.Controls.Add(Map);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Map.ReloadMap();
            }
            catch (Exception)
            {
            }
            
        }

        private void btnCentrar_Click(object sender, EventArgs e)
        {
            Map.ZoomAndCenterMarkers(null);
            tkBarZoom.Value = (int)Map.Zoom;
        }

        private void btnLessZoom_Click(object sender, EventArgs e)
        {
            tkBarZoom.Value = tkBarZoom.Value - 1;
        }

        private void btnMoreZoom_Click(object sender, EventArgs e)
        {
            tkBarZoom.Value = tkBarZoom.Value + 1;
        }

        private void tkBarZoom_ValueChanged(object sender, EventArgs e)
        {
            Map.Zoom = tkBarZoom.Value;

            btnLessZoom.Enabled = tkBarZoom.Value > Map.MinZoom;
            btnMoreZoom.Enabled = tkBarZoom.Value < Map.MaxZoom;
        }

    }
}
