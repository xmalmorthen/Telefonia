using Duplicator.Controllers;
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
    public partial class frmLogin : Form
    {
        public caUsers user;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Cancel login","Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes ) 
                this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.user = loginController.login(this.txtUser.Text.Trim(), this.txtPass.Text.Trim());
            if (user == null)
            {
                MessageBox.Show(this, "Failed to login, verify the user and / or password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUser.Focus();
            }
            else {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;            
            }
        }
    }
}
