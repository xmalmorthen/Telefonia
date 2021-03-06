﻿using GSMApplication.Classes;
using GSMApplication.Controllers;
using GSMApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Forms
{
    public partial class GSMPI : Form
    {
        private string fileName = DateTime.Now.ToString("ddMMyyyy_HHmmss");

        public GSMPI()
        {
            InitializeComponent();
            this.initialize();
        }

        private void initialize() {
            string message;
            lblTitle.Text = GSMApplication.Properties.Settings.Default.MCWG_Cnn_lblTitle.Trim();
            lblTitle2.Text = GSMApplication.Properties.Settings.Default.MCWG_Cnn_lblTitle2.Trim();
            this.tmWorkers_Tick(null,null);            
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            if (Online.init(this) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            if (Online.init(this) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

        }       

        private void tmWorkers_Tick(object sender, EventArgs e)
        {
            tmWorkers.Enabled = false;
            tmWorkers.Stop();

            try
            {
                if (!bWInternetConnection.IsBusy) bWInternetConnection.RunWorkerAsync();
                if (!bWSystemConnected.IsBusy) bWSystemConnected.RunWorkerAsync();
                if (!bWExternalPower.IsBusy) bWExternalPower.RunWorkerAsync();
            }
            catch (Exception)
            {

            }

            tmWorkers.Enabled = true;
            tmWorkers.Start();
        }

        private void bWInternetConnection_DoWork(object sender, DoWorkEventArgs e)
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

        private void bWInternetConnection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbInternetConnection.Image = (Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }

        private void bWSystemConnected_DoWork(object sender, DoWorkEventArgs e)
        {
            ResponseModel result = new ResponseModel();
            try
            {
                string message = string.Empty;
                result.Status = system.check.SystemConnected.Check(out message);
                result.Message.Append (message);
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            e.Result = result;
        }

        private void bWSystemConnected_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ResponseModel result = (ResponseModel)e.Result;
            if (!result.Status)
            {
                toolTip.SetToolTip(pbSystemConnected, result.Message.ToString());
                toolTip.SetToolTip(label2, result.Message.ToString());
            }
            this.pbSystemConnected.Image = result.Status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
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
                exceptionHandlerCatch.registerLogException(ex);
            }
            e.Result = result;
        }

        private void bWExternalPower_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbExternalPower.Image = (Boolean)e.Result ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }

    }
}
