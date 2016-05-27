﻿using CellTrack.Classes;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Views
{
    public partial class frmSshCnn : MetroForm
    {
        private List<BackgroundWorker> bkgndWrkrs = new List<BackgroundWorker>();

        private DialogResult dlgRes = DialogResult.Yes;

        public frmSshCnn()
        {
            InitializeComponent();

            msmMain = Properties.Settings.Default.mainStyle;
            this.StyleManager = msmMain;

            this.init();
        }

        private void init() {
            for (int i = 0; i < 1; i++)
            {
                BackgroundWorker wrker = new BackgroundWorker();
                wrker.WorkerSupportsCancellation = true;
                wrker.DoWork += wrker_DoWork;
                wrker.RunWorkerCompleted += wrker_RunWorkerCompleted;
                bkgndWrkrs.Add(wrker);
                wrker.RunWorkerAsync();
            }            
        }

        void wrker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string cnnName = String.Format("Enlace {0}", Guid.NewGuid().ToString());
                Program.SshCnn.Add(cnnName, new sshCnn(Properties.Settings.Default.sshUser, Properties.Settings.Default.sshPass, Properties.Settings.Default.sshHost));
                e.Result = cnnName;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        byte iter = 0;
        void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            iter++;

            if (e.Error != null)
            {
                btnCancel_Click(null, null);
                MessageBox.Show(this, "Error al intentar conectar con los dispositivos !!!", "Error de conección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.No;
                this.Close();
            }
            else
            {
                lblInfo.Text = String.Format("Iniciando servicio {0} ...", (string)e.Result);
                pbSshCnn.Value = (iter * 100) / bkgndWrkrs.Count;

                if (iter >= bkgndWrkrs.Count)
                {
                    this.DialogResult = this.dlgRes;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (BackgroundWorker item in bkgndWrkrs)
                item.CancelAsync();
            foreach (KeyValuePair<string, sshCnn> item in Program.SshCnn)
            {
                if (item.Value.SshClient.IsConnected) 
                    item.Value.SshClient.Disconnect();
            }
            dlgRes = System.Windows.Forms.DialogResult.No;
        }

    }
}