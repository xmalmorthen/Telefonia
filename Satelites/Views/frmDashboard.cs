using MetroFramework.Forms;
using Satelites.Classes;
using Satelites.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelites.Views
{
    public partial class frmDashboard : MetroForm
    {
        public DialogResult dlgRes = DialogResult.No;
        public gMapView gMapViewRender;

        private enums.frmState _frmState;
        private enums.frmState frmState
        {
            get { return _frmState; }
            set
            {
                _frmState = value;

                this.Enabled = value == enums.frmState.Normal;
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
            this.pnlMain.Controls.Clear();
            this.pnlMain.Dispose();
        }

        private UserControl FrmActive;
        public void renderControl(UserControl ctrl)
        {
            Application.DoEvents();
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrl.Location = new System.Drawing.Point(0, 0);
            ctrl.MinimumSize = new Size(0, 0);
            ctrl.Margin = new Padding(3);
            ctrl.TabIndex = 0;
            FrmActive = ctrl;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(ctrl);
        }

        public void renderNone()
        {
            Application.DoEvents();
            FrmActive = null;
            this.pnlMain.Controls.Clear();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            frmState = enums.frmState.Normal;

            gMapViewRender = new gMapView(Properties.Settings.Default.MapInitPointLat, Properties.Settings.Default.MapInitPointLng);

            renderControl(gMapViewRender);
        }
    }
}
