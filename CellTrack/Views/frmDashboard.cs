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

            frmSaldo.Visible = false;
            
            frmUserInformation.refreshUserName();
            frmState = FrmState.Normal;
            //renderControl(new frmUserAdmin());
        }

        private UserControl FrmActive;
        public void renderControl(UserControl ctrl) {
            Application.DoEvents();
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrl.Location = new System.Drawing.Point(0, 0);
            ctrl.MinimumSize = new Size(0, 0);
            ctrl.Margin = new Padding(3);
            ctrl.TabIndex = 0;
            FrmActive = ctrl;
            this.panel.Controls.Clear();
            this.panel.Controls.Add(ctrl);
        }

        public void renderNone() {
            Application.DoEvents();
            FrmActive = null;
            this.panel.Controls.Clear();
        }

        public void showAlert(string message) {
            this._showAlert(string.Empty, message);
        
        }

        public void showAlert(string title, string message)
        {
            this._showAlert(title, message);
        }

        public void showAlert(string title, string message, object tag)
        {
            this._showAlert(title, message, tag);
        }

        private void _showAlert(string message, string title = "", object tag = null)
        {
            if (!string.IsNullOrEmpty(title)) notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = message;
            notifyIcon.Tag = tag;
            notifyIcon.ShowBalloonTip(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAlert("Prueba", "Prueba de Alerta","data");
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            NotifyIcon obj = (NotifyIcon)sender;
            notifycationAction(obj.Tag);
        }

        private void notifycationAction(object tag) {
            string Tag = (string)tag;
            notifyIcon.Visible = false;
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            NotifyIcon obj = (NotifyIcon)sender;
            obj.ShowBalloonTip(1000);
        }

    }
}
