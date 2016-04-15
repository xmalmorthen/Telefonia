using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GSMApplication.Controllers;
using GSMApplication.Models;
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
            this.starWorkers();
            this.initChartGraph();
            this.tableLayoutPanel7.Controls.Add(gMap.initMap(), 0, 1);
            this.populate();

            tmWorkers.Enabled = true;
            tmWorkers.Start();
        }

        private void starWorkers() {
            try
            {
                if (!bwSystem.IsBusy)
                    bwSystem.RunWorkerAsync();
                if (!bWInternet.IsBusy) 
                    bWInternet.RunWorkerAsync();
                if (!bWReceivers.IsBusy) 
                    bWReceivers.RunWorkerAsync();
                if (!bWDecipher.IsBusy) 
                    bWDecipher.RunWorkerAsync();
                if (!bWDecipherState.IsBusy) 
                    bWDecipherState.RunWorkerAsync();
                if (!bWExternalPower.IsBusy)
                    bWExternalPower.RunWorkerAsync();
            }
            catch (Exception)
            {
                //throw;
            }            
        }

        private void tmWorkers_Tick(object sender, EventArgs e)
        {
            tmWorkers.Stop();
            tmWorkers.Enabled = false;

            this.starWorkers();

            tmWorkers.Enabled = true;
            tmWorkers.Start();
        } 


        private void initChartGraph() {
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            tmGraph.Enabled = true;
            tmGraph.Start();
        }

        private void populate()
        {
            this.cellsModelBindingSource.DataSource = Populate.Cells();
            this.tMSICatcherBindingSource.DataSource = Populate.TMSICatcher();
            this.decryptedTrafficBindingSource.DataSource = Populate.DecryptedTraffic();
            gMap.AddMarker(Populate.MapMarkerModel());
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


        private void bwSystem_DoWork(object sender, DoWorkEventArgs e)
        {
            ResponseModel result = new ResponseModel();
            try
            {
                string message = string.Empty;
                result.Status = system.check.SystemConnected.Check(out message);
                result.Message.Append(message);
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bwSystem_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ResponseModel result = (ResponseModel)e.Result;
            if (!result.Status)
            {
                toolTip.SetToolTip(label6, result.Message.ToString());
                toolTip.SetToolTip(pbSystem, result.Message.ToString());
            }
            this.pbSystem.Image = result.Status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }

        private void bWInternet_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.check.InternetConnection.Check();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWInternet_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbInternet.Image = (Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbmapCacheOnly.Image = !(Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            gMap.MainMap.Manager.Mode = AccessMode.CacheOnly;
        }

        private void bWReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.check.Receivers.Check();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWReceivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbReceivers.Image = (Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }

        private void bWDecipher_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.check.Decipher.Check();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWDecipher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbDecipher.Image = (Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }

        private void bWDecipherState_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.check.Decipher.State();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWDecipherState_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbDecipherState.Image = (Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }

        private void bWExternalPower_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.check.ExternalPower.Check();
            }
            catch (Exception ex)
            {

            }
            e.Result = result;
        }

        private void bWExternalPower_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbExternalPower.Image = (Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }    
    }
}
