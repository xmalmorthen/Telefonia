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

            tmGetModemSignal_Tick(null, null);

            tmGetModemSignal.Interval = 500;
            tmGetModemSignal.Enabled = true;
            tmGetModemSignal.Start();            
        }

        private void tmGetModemSignal_Tick(object sender, EventArgs e)
        {
            pbFree.Visible = modemStatus.Free;
            pbOcuppied.Visible = !modemStatus.Free;
            lbl.Text = modemStatus.Free ? "Desocupado" : "Ocupado";
            btnFree.Visible = !modemStatus.Free;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tmGetModemSignal_Tick(null, null);
        }
    }
}
