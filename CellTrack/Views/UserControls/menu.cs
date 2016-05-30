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
using MetroFramework.Controls;
using System.Threading;
using CellTrack.Views.UserControls.Localización;
using MetroFramework;

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
            this.openFrm<frmAdmin>();
        }

        private void btnFinder_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmInvestigacion());
        }

        private void btnDataBases_Click(object sender, EventArgs e)
        {
            mCMRegs.Show((MetroButton)sender, new Point(0, ((MetroButton)sender).Height));
            //Program.FrmDashboard.renderControl(new frmBaseDatos());
        }

        private void btnLocalizations_Click(object sender, EventArgs e)
        {
            mCMLocalizations.Show((MetroButton)sender, new Point(0,((MetroButton)sender).Height));            
        }

        private void openFrm<TForm>() where TForm : UserControl, new()
        {
            Program.FrmDashboard.renderControl(new frmProccessingShow());
            Application.DoEvents();
            Program.FrmDashboard.renderControl(new TForm());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.openFrm<frmObjetivos>();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.IPHostEntry internet = System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                MetroMessageBox.Show(this,"No hay conexión a internet." + Environment.NewLine + "No es posible usar esta función", "Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.openFrm<frmPDU>();
        }
        
    }
}
