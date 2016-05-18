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
            pbRecord.Visible = true;
            this.Enabled = false;
            try
            {
                if (String.IsNullOrEmpty(txtNumber.Text.Trim()) && String.IsNullOrEmpty(txtCarrier.Text.Trim()) && String.IsNullOrEmpty(txtCountry.Text.Trim()))
                {
                    MessageBox.Show(this, "Lack complete information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string returnMessage = String.Empty;

                    if (targetController.record(UserLogged, new duplicatorModel()
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
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pbRecord.Visible = false;
            this.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e .KeyChar);             
        }

        private void txtCarrier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
