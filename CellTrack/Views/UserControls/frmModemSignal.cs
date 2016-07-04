using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellTrack.Classes;
using CellTrack.Controllers;
using System.Threading;

namespace CellTrack.Views.UserControls
{
    public partial class frmModemSignal : UserControl
    {
        public frmModemSignal()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            wrkr.RunWorkerAsync();
        }

        private void setSignal(int signal) {
            string toolTip = string.Format("Ultima actualización de señal [ {0} ]", DateTime.Now.ToLongTimeString());
            if (signal > 0)
                mpbModemSignal.Value = signal;
            metroToolTip.SetToolTip(lblErr, toolTip);
            metroToolTip.SetToolTip(mpbModemSignal, toolTip);
            lblErr.Visible = signal == 0;
            mpbModemSignal.Visible = signal > 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BackgroundWorker wrk = new BackgroundWorker();
            wrk.WorkerSupportsCancellation = true;
            wrk.DoWork += (_sender, _e) =>
            {
                _e.Result = modemSignalController.get;
            };
            wrk.RunWorkerCompleted += (_sender, _e) =>
            {
                setSignal((int)_e.Result);
            };
            wrk.RunWorkerAsync();
        }

        private void wrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
	        {
	            (sender as BackgroundWorker).ReportProgress(modemSignalController.get); 
                Thread.Sleep(Properties.Settings.Default.ModemSignalRefreshTime);
	        }            
        }

        private void wrkr_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            setSignal(e.ProgressPercentage);
        }
    }
}
