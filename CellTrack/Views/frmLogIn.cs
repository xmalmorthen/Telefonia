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
                MessageBox.Show(this, "Debe especificar el nombre de usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsr.Focus();
            } else if (string.IsNullOrEmpty(txtPwd.Text.Trim())){
                MessageBox.Show(this, "Debe especificar la contraseña", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            e.Result = usuarioController.verifyLogInUser(txtUsr.Text, txtPwd.Text);
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        } 

        void bkgnd_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                frmState = FrmState.Normal;

                if (e.Error != null) throw new EntitySqlException("Error al intentar conectar",e.Error);

                if (!(Boolean)e.Result)
                {
                    MessageBox.Show(this,"Usuario y/o contraseña incorrectos", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dlgRes = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
            }
        }
        
        void btnCancel_Click(object sender, EventArgs e)
        {
            dlgRes = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void frmLogIn_Shown(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        
    }
}
