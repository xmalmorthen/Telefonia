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

namespace CellTrack.Views.UserControls
{
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmUserAdmin());
        }

        private void btnConfigs_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmAdmin());
        }

        private void btnFinder_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmInvestigacion());
        }

        private void btnDataBases_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmBaseDatos());
        }

        private void btnLocalizations_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmLocalizacion());
        }
    }
}
