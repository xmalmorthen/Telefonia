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
    public partial class frmRemoveTarget : Form
    {
        private caUsers userLogged;
        private caUsers UserLogged
        {
            get { return userLogged; }
            set { userLogged = value; }
        }

        private duplicatorModel target;
        private duplicatorModel Target
        {
            get { return target; }
            set { target = value; }
        }

        public frmRemoveTarget(caUsers userLogged, duplicatorModel model)
        {
            InitializeComponent();
            this.UserLogged = userLogged;
            this.Target = model;
            this.init();
        }

        private void init()
        {
            lblCarrier.Text = this.Target.Carrier;
            lblCountry.Text = this.Target.Country;
            lblNumber.Text = this.Target.Number;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string returnMessage = String.Empty;
            if (MessageBox.Show(this,"Remove Target","Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) {
                if (targetController.remove(UserLogged, this.Target, out returnMessage) == false)
                {
                    MessageBox.Show(this, returnMessage, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show(this, returnMessage, "Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
