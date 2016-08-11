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
using System.Threading;
using CellTrack.Models;
using CellTrack.Controllers;

namespace CellTrack.Views.UserControls
{
    public partial class UCDoHealthCheck : MetroUserControl
    {
        public UCDoHealthCheck()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            bkwkr.RunWorkerAsync(Properties.Settings.Default.DoHealthCheck);
        }

        private void bkwkr_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker wrkr = (BackgroundWorker)sender;
            TimeSpan timeSleep = (TimeSpan)e.Argument; 
            while (true)
            {
                if (wrkr.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                wrkr.ReportProgress(0, DoHealthCheckController.get);

                Thread.Sleep(timeSleep);
            }           
        }

        private void bkwkr_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker wrkr = (BackgroundWorker)sender;

            HLRModel.doHealthCheck response = e.UserState as HLRModel.doHealthCheck;

            this.changeHealtCheckStatus(response);
        }

        private void changeHealtCheckStatus(HLRModel.doHealthCheck response)
        {
            label10.Text = "HealthCheck";
            if (response != null) {
                if (response.success) {
                    this.pictureBox0.Image = response.results.system.state.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox1.Image = response.results.routes.states.IP1.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox2.Image = response.results.routes.states.ST2.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox3.Image = response.results.routes.states.SV3.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox4.Image = response.results.routes.states.IP4.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox5.Image = response.results.routes.states.XT5.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox6.Image = response.results.routes.states.XT6.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox7.Image = response.results.routes.states.NT7.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    this.pictureBox8.Image = response.results.routes.states.LC1.Equals("up") ? global::CellTrack.Properties.Resources._1459305043_11 : global::CellTrack.Properties.Resources._1459304445_101_Warning;
                    flowLayoutPanel1.Visible = true;
                    return;
                }
            }
            flowLayoutPanel1.Visible = false;
            label10.Text = "HealthCheck [ Error - No se obtuvo respuesta del API ]";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.changeHealtCheckStatus(DoHealthCheckController.get);
        }
    }
}
