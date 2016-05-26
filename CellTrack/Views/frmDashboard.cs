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
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;
            frmState = FrmState.Normal;

            renderControl(new frmUserAdmin());
        }

        public void renderControl(UserControl ctrl) {
            Application.DoEvents();
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrl.Location = new System.Drawing.Point(0, 0);            
            ctrl.TabIndex = 0;

            this.panel.Controls.Clear();
            this.panel.Controls.Add(ctrl);
        }

    }
}
