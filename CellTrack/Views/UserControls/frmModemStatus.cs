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
    public partial class frmModemStatus : UserControl
    {
        public frmModemStatus()
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

        private void wrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                ((BackgroundWorker)sender).ReportProgress(0, modemStatus.Free);
                Thread.Sleep(1000);
            }
        }

        private void wrkr_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbFree.Visible = modemStatus.Free;
            pbOcuppied.Visible = !(Boolean)e.UserState;
            lbl.Text = (Boolean)e.UserState ? "Desocupado" : "Ocupado";
            //btnFree.Visible = !modemStatus.Free;
        }
    }
}
