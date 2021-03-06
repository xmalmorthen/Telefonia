﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using HLR.Views.UserControls;
using HLR.Controllers;
using MetroFramework;
using HLR.Models;
using HLR.Classes;
using enums;
using System.Threading;
using HLR.Models.DataBase;

namespace HLR
{
    public partial class frmMain : MetroForm
    {
        frmState frmState;
        public frmState FrmState
        {
            get { return frmState; }
            set
            {
                frmState = value;

                pnlCell.Visible = frmState == frmState.Normal;
                pnlJob.Visible = frmState == frmState.Find;
                btnNewFind.Visible = frmState == frmState.Finded;
                pnlSuper.Enabled = !(FrmState == enums.frmState.Lock || FrmState == enums.frmState.Locked);
                pnlInternet.Visible = FrmState == enums.frmState.Lock || FrmState == enums.frmState.Locked;
            }
        }

        public mapViewer MapViewer = new mapViewer();

        public frmMain()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            wrkrInternet.RunWorkerAsync();

            FrmState = enums.frmState.Normal;
            MapViewer.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(MapViewer);
            
            txtCell.Focus();
            txtCell.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string msisdn = txtCell.Text.Trim();

            if (!string.IsNullOrEmpty(msisdn))
            {
                if (msisdn.Length == txtCell.MaxLength)
                {
                    FrmState = frmState.Find;
                    wrkr.RunWorkerAsync(msisdn);
                    return;
                }
                else
                    MetroMessageBox.Show(this, "Formato de número incorrecto, se esperan 14 dígitos..." + Environment.NewLine + "Ej. +5213121220990", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MetroMessageBox.Show(this, "Debe especificar el número de celular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtCell.Focus();
        }

        private void wrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker wrkr = (BackgroundWorker)sender;

            if (wrkr.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            string msisdn = (string)e.Argument;

            try
            {
                HLRModel.submitSyncLookupRequest response = submitSyncLookupRequestController.invoque(msisdn);

                wrkr.ReportProgress(50);

                if (response != null)
                {
                    if (response.success)
                    {
                        List<googleGeolocApiModel> googleApiResponseList = new List<googleGeolocApiModel>();
                        foreach (HLR.Models.HLRModel.resultsModel item in response.results)
	                    {
                            mahlr dataModel = new mahlr() { 
                                msisdncountrycode = item.msisdncountrycode,
                                msisdn = item.msisdn,
                                statuscode = item.statuscode,
                                hlrerrorcodeid = item.hlrerrorcodeid,
                                subscriberstatus = item.subscriberstatus,
                                imsi = item.imsi,
                                mccmnc = item.mccmnc,
                                mcc = item.mcc,
                                mnc = item.mnc,
                                msin = item.msin,
                                servingmsc = item.servingmsc,
                                servinghlr = item.servinghlr,
                                originalnetworkname = item.originalnetworkname,
                                originalcountryname = item.originalcountryname,
                                originalcountrycode = item.originalcountrycode,
                                originalcountryprefix = item.originalcountryprefix,
                                originalnetworkprefix = item.originalnetworkprefix,
                                roamingnetworkname = item.roamingnetworkname,
                                roamingcountryname = item.roamingcountryname,
                                roamingcountrycode = item.roamingcountrycode,
                                roamingcountryprefix = item.roamingcountryprefix,
                                roamingnetworkprefix = item.roamingnetworkprefix,
                                portednetworkname = item.portednetworkname,
                                portedcountryname = item.portedcountryname,
                                portedcountrycode = item.portedcountrycode,
                                portedcountryprefix = item.portedcountryprefix,
                                portednetworkprefix = item.portednetworkprefix,
                                isvalid = item.isvalid,
                                isroaming = item.isroaming,
                                isported = item.isported,
                                usercharge = item.usercharge,
                                inserttime = item.inserttime,
                                storage = item.storage,
                                route = item.route,
                                Interface  = item.Interface,
                                fInis = DateTime.Now
                            };

                            googleApiGeoReference googleApi = new googleApiGeoReference();

                            Double cellid = 0;
                            Double lac = 0;
                            Double mcc = Double.Parse(dataModel.mcc);
                            Double mnc = Double.Parse(dataModel.mnc);
                            string message = string.Empty;

                            dataModel.cellid = cellid;
                            dataModel.lac = lac;

                            googleGeolocApiModel googleApiResponse = googleApi.invoque(cellid, lac, mcc, mnc, out message);
                            if (googleApiResponse == null)
                                throw new NullReferenceException(message);

                            googleApiResponseList.Add(googleApiResponse);
                        }
                        e.Result = googleApiResponseList;
                    }
                    else throw new NullReferenceException("No se obtuvo respuesta del API");
                }                
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
                throw;
            }
            wrkr.ReportProgress(100);
        }

        private void wrkr_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker wrkr = (BackgroundWorker)sender;
            if (!wrkr.CancellationPending)
                pbJob.Value = e.ProgressPercentage;
        }

        private void wrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker wrkr = (BackgroundWorker)sender;
            if (!e.Cancelled) {
                if (e.Error != null)
                    MetroMessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else {
                    googleGeolocApiModel googleApiResponse = (googleGeolocApiModel)e.Result;
                }
            }
            FrmState = frmState.Finded;
        }

        private void btnNewFind_Click(object sender, EventArgs e)
        {
            FrmState = frmState.Normal;
        }

        frmState lastState;
        private void wrkrInternet_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!(Boolean)e.UserState && FrmState != enums.frmState.Lock )
            {
                lastState = FrmState;
                FrmState = enums.frmState.Lock;
            }
            else if ((Boolean)e.UserState && FrmState == enums.frmState.Lock)
            {
                FrmState = lastState;
                MapViewer.btnRefresh.PerformClick();
                ucDoHealthCheck.btnRefresh.PerformClick();
            }
        }

        private void wrkrInternet_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean onLine = false;
            while (true)
            {
                try
                {
                    System.Net.IPHostEntry internet = System.Net.Dns.GetHostEntry("www.google.com");
                    onLine = true;
                }
                catch
                {
                    onLine = false;
                }
                ((BackgroundWorker)sender).ReportProgress(0, onLine);
                Thread.Sleep(1000);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            wrkr.CancelAsync();
            FrmState = enums.frmState.Normal;
        }

    }
}
