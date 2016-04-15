using GSMApplication.Controllers;
using GSMApplication.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Forms
{
    public partial class StatusWindow : Form
    {
        private DialogResult dlgRes = DialogResult.Yes;

        public StatusWindow()
        {
            InitializeComponent();
        }

        private void StatusWindow_Paint(object sender, PaintEventArgs e)
        {            
            this.Init();
        }        

        private void Init()
        {
            bWInitialzingSystem.RunWorkerAsync();
            bWConnectionToControllers.RunWorkerAsync();
            bWScanningForReceivers.RunWorkerAsync();            
            bWConnectingToReceivers.RunWorkerAsync();

            while (bWInitialzingSystem.IsBusy ||
                    bWConnectionToControllers.IsBusy ||
                    bWScanningForReceivers.IsBusy ||
                    bWPoweringOnReceivers.IsBusy ||
                    bWConnectingToReceivers.IsBusy
            )
            {
                Application.DoEvents();
                if (this.frmTerminate)
                {
                    break;
                }
                Thread.Sleep(500);
            }

            if (this.dlgRes != System.Windows.Forms.DialogResult.Yes) {
                MessageBox.Show(this, "Unable to continue, please review the devices...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = this.dlgRes;            
            this.Close();
        }


        private Boolean frmTerminate = false;
        private void StatusWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                bWInitialzingSystem.CancelAsync();
                bWConnectionToControllers.CancelAsync();
                bWScanningForReceivers.CancelAsync();
                bWPoweringOnReceivers.CancelAsync();
                bWConnectingToReceivers.CancelAsync();
                dlgRes = System.Windows.Forms.DialogResult.No;
                frmTerminate = true;
            }
            
        }

        private void bWInitialzingSystem_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.initializing.initialzingSystem();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWInitialzingSystem_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Boolean status = (Boolean)e.Result;

            this.pbInitialzingSystem.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            dlgRes = dlgRes == System.Windows.Forms.DialogResult.Yes && status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;

            pBProgress();
        }

        private void bWConnectionToControllers_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.initializing.Receivers.connectionToControllers();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWConnectionToControllers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Boolean status = (Boolean)e.Result;
            this.pbConnectionToControllers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            dlgRes = dlgRes == System.Windows.Forms.DialogResult.Yes && status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;

            pBProgress();            
        }

        private void bWScanningForReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.initializing.Receivers.scanningForReceivers();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWScanningForReceivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Boolean status = (Boolean)e.Result;
            this.pbScanningForReceivers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            dlgRes = dlgRes == System.Windows.Forms.DialogResult.Yes && status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
            
            pBProgress();

            bWPoweringOnReceivers.RunWorkerAsync();
        }

        private void bWPoweringOnReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.initializing.Receivers.poweringOnReceivers();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWPoweringOnReceivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Boolean status = (Boolean)e.Result;
            this.pbPoweringOnReceivers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            dlgRes = dlgRes == System.Windows.Forms.DialogResult.Yes && status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;

            pBProgress();
        }

        private void bWConnectingToReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean result = false;
            try
            {
                result = system.initializing.Receivers.connectingToReceivers();
            }
            catch (Exception)
            {

            }
            e.Result = result;
        }

        private void bWConnectingToReceivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Boolean status = (Boolean)e.Result;
            this.pbConnectingToReceivers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            dlgRes = dlgRes == System.Windows.Forms.DialogResult.Yes && status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;

            pBProgress();
        }

        private const int STATUS_COUNT = 5;
        private int progress = 0;
        private void pBProgress() {
            Application.DoEvents();
            progress++;
            pB.Value = (progress * 100) / STATUS_COUNT;
        }
        
    }
}
