using Duplicator.Controllers;
using Duplicator.Models;
using Duplicator.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicator.Views
{
    public partial class frmDuplicator : Form
    {
        private caUsers userLogged;
        public caUsers UserLogged
        {
            get { return userLogged; }
            set { userLogged = value; }
        }

        public frmDuplicator(caUsers userLogged)
        {
            InitializeComponent();
            this.UserLogged = userLogged;
            this.init();
        }

        private void init()
        {
            administrationToolStripMenuItem.Visible = this.UserLogged.isAdmin;
            this.btnUpdate_Click(null, null);
        }

        private void finalize() {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            duplicatorModelBindingSource.DataSource = duplicatorController.duplicatorList(this.UserLogged.id);

            //dgvDuplicatior.DataSource = 
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            this.finalize();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaUsers FrmcaUsers = new frmCaUsers();
            FrmcaUsers.ShowDialog(this);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.finalize();
            this.Close();
        }

        private void btnAddTarget_Click(object sender, EventArgs e)
        {
            frmAddTarget FrmAddTarget = new frmAddTarget(this.UserLogged);
            if (FrmAddTarget.ShowDialog(this) == System.Windows.Forms.DialogResult.Yes) {
                this.btnUpdate_Click(null, null);
            }
        }

        private void btnRemoveTarget_Click(object sender, EventArgs e)
        {
            duplicatorModel model = (duplicatorModel)duplicatorModelBindingSource.Current;

            frmRemoveTarget FrmRemoveTaget = new frmRemoveTarget(this.UserLogged,model);
            if (FrmRemoveTaget.ShowDialog(this) == System.Windows.Forms.DialogResult.Yes)
            {
                this.btnUpdate_Click(null, null);
            }
        }
    }
}
