using CellTrack.Classes;
using CellTrack.Controllers;
using CellTrack.Models.DataBases;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack
{
    public partial class frmLogIn : MetroForm
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
            set { 
                _frmState = value;

                this.tlpProc.Visible = value != FrmState.Normal;
                this.Enabled = value == FrmState.Normal;
            }
        }


        public frmLogIn()
        {
            InitializeComponent();
            this.init();
        }
        
        private void init()
        {
            visualStyles.apply(this, msmMain);
            frmState = FrmState.Normal;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            frmState = FrmState.Proccesing;

            if (string.IsNullOrEmpty(txtUsr.Text.Trim())) { 
                MetroMessageBox.Show(this, "Debe especificar el nombre de usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsr.Focus();
            } else if (string.IsNullOrEmpty(txtPwd.Text.Trim())){
                MetroMessageBox.Show(this, "Debe especificar la contraseña", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPwd.Focus();
            } else {
                BackgroundWorker bkgnd = new BackgroundWorker();
                bkgnd.DoWork += bkgnd_DoWork;
                bkgnd.RunWorkerCompleted += bkgnd_RunWorkerCompleted;
                bkgnd.RunWorkerAsync();
            }
        }

        void bkgnd_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = usuarioController.verifyLogInUser(txtUsr.Text, txtPwd.Text);
        } 

        void bkgnd_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frmState = FrmState.Normal;
            if (!(Boolean)e.Result) {
                MetroMessageBox.Show(this, "Usuario y/o contraseña incorrectos", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void btnCancel_Click(object sender, EventArgs e)
        {
            dlgRes = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
        
    }
}
