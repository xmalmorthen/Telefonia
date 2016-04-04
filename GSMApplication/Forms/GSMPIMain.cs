using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GSMApplication.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Forms
{
    public partial class GSMPIMain : Form
    {
        private void init() {
            this.initStateIcons();
            this.initChartGraph();
            this.initMap();
            this.populate();
        }

        private void initStateIcons() {
            this.pbInternet.Image = InternetCheckConnection.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbSystem.Image = SystemCheckConnected.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbExternalPower.Image = ExternalCheckPower.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbReceivers.Image = CheckReceivers.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbDecipher.Image = CheckDecipher.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbDecipher.Image = CheckDecipher.State() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbmapCacheOnly.Image = !InternetCheckConnection.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }

        private void initChartGraph() {
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            tmGraph.Enabled = true;
            tmGraph.Start();
        }

        private void initMap()
        {
            GMapControl MainMap = new GMapControl();
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

            this.tableLayoutPanel7.Controls.Add(MainMap, 0, 1);
        }

        private void populate()
        {
            this.cellsModelBindingSource.DataSource = Populate.Cells();
            this.tMSICatcherBindingSource.DataSource = Populate.TMSICatcher();
            this.decryptedTrafficBindingSource.DataSource = Populate.DecryptedTraffic();

        }

        public GSMPIMain()
        {
            InitializeComponent();
            this.SuspendLayout();
            this.init();
            this.ResumeLayout(false);
        }

        Random rnd = new Random();
        List<int> points = new List<int>();
        byte iter = 0;
        private void tmGraph_Tick(object sender, EventArgs e)
        {
            iter++;
            points.Add (rnd.Next(100));
            chart.ResetAutoValues();
            if (chart.Series[0].Points.Count > 0) {
                if (iter > 10) {
                    chart.Series[0].Points.RemoveAt(0);
                    chart.ChartAreas[0].AxisX.Minimum = chart.Series[0].Points[0].XValue;
                    chart.ChartAreas[0].AxisX.Maximum = points.Count();                    
                }
            }
            chart.Series[0].Points.AddXY(points.Count(), points[points.Count - 1]);
            chart.Invalidate();

        }



    }
}
