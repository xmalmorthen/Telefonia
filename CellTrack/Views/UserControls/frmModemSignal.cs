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

            tmGetModemSignal_Tick(null, null);

            tmGetModemSignal.Interval = 60000;
            tmGetModemSignal.Enabled = true;
            tmGetModemSignal.Start();            
        }

        private void tmGetModemSignal_Tick(object sender, EventArgs e)
        {
            int signal = modemSignalController.get;
            string toolTip = string.Format("Ultima actualización de señal [ {0} ]", DateTime.Now.ToLongTimeString());
            if (signal > 0)
                mpbModemSignal.Value = signal;
            metroToolTip.SetToolTip(lblErr, toolTip);
            metroToolTip.SetToolTip(mpbModemSignal,toolTip);
            lblErr.Visible = signal == 0;
            mpbModemSignal.Visible = signal > 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tmGetModemSignal_Tick(null, null);
        }
    }
}
