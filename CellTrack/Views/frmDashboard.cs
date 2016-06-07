using CellTrack.Classes;
using CellTrack.Views.UserControls;
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
    public partial class frmDashboard : MetroForm
    {
        public DialogResult dlgRes = DialogResult.No;
        
        private enum FrmState
        {
            Normal,
            Proccesing
        }

        private FrmState _frmState;
        private FrmState frmState
        {
            get { return _frmState; }
            set
            {
                _frmState = value;
                
                this.Enabled = value == FrmState.Normal;
            }
        }

        public frmDashboard()
        {
            InitializeComponent();

            this.FormClosed += frmDashboard_FormClosed;

            this.init();
        }

        void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.panel.Controls.Clear();
            this.panel.Dispose();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;
            frmUserInformation.refreshUserName();
            frmState = FrmState.Normal;
            renderControl(new frmUserAdmin());
        }

        private UserControl FrmActive;
        public void renderControl(UserControl ctrl) {
            Application.DoEvents();
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrl.Location = new System.Drawing.Point(0, 0);            
            ctrl.TabIndex = 0;
            FrmActive = ctrl;

            this.panel.Controls.Clear();
            this.panel.Controls.Add(ctrl);
        }

    }
}
