using CellTrack.Classes;
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
            mCMCuenta.StyleManager = msmMain;
            frmState = FrmState.Normal;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            mCMCuenta.Show(btnUser, new Point(0,btnUser.Height));
        }
    }
}
