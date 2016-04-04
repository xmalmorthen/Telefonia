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
    public partial class frmAddTarget : Form
    {
        private caUsers userLogged;
        private caUsers UserLogged
        {
            get { return userLogged; }
            set { userLogged = value; }
        }

        public frmAddTarget(caUsers userLogged)
        {
            InitializeComponent();
            this.UserLogged = userLogged;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumber.Text.Trim()) && String.IsNullOrEmpty(txtCarrier.Text.Trim()) && String.IsNullOrEmpty(txtCountry.Text.Trim()))
            {
                MessageBox.Show(this, "Lack complete information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string returnMessage = String.Empty;


                if (addtargetController.record(UserLogged, new duplicatorModel()
                {
                    Number = this.txtNumber.Text.Trim(),
                    Carrier = this.txtCarrier.Text.Trim(),
                    Country = this.txtCountry.Text.Trim()
                }, out returnMessage) == false)
                {
                    MessageBox.Show(this, returnMessage, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
