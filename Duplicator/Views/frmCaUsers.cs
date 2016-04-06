using Duplicator.classes;
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
    public partial class frmCaUsers : Form
    {
        public enum frmState
        {
            Normal,
            Add,
            Edit,
            Delete
        }
        private frmState state;
        private frmState State
        {
            get { return state; }
            set { 
                state = value;

                this.btnAdd.Enabled = state == frmState.Normal ? true : false;
                this.btnEdit.Enabled = state == frmState.Normal && caUsersBindingSource.Count > 0 ? true : false;
                this.btnDelete.Enabled = state == frmState.Normal && caUsersBindingSource.Count > 0 ? true : false;

                this.tlpUserForm.Enabled = state == frmState.Add || state == frmState.Edit ? true : false;
                this.dgvUsers.Enabled = state == frmState.Normal ? true : false;

                this.txtUser.Enabled = state == frmState.Edit ? false : true;
                this.txtPass.Text = string.Empty;
                this.txtConfirm.Text = string.Empty;
            }
        }

        public frmCaUsers()
        {
            InitializeComponent();
            this.init();

        }

        private void init()
        {
            this.populateGrid();
            this.State = frmState.Normal;
        }

        private void populateGrid() {
            try
            {
                caUsersBindingSource.DataSource = caUsersModel.getUsers();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to obtain information from the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void caUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDuplicatorDataSet1.caUsers' Puede moverla o quitarla según sea necesario.
            this.caUsersTableAdapter.Fill(this.dBDuplicatorDataSet.caUsers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Confirm delete user", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.State = frmState.Delete;
                if (!caUsersModel.deleteUser(selectItem))
                {
                    MessageBox.Show(this, "User not found", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.populateGrid();
                    this.State = frmState.Normal;
                    MessageBox.Show(this, "User deleted", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.State = frmState.Edit;
            this.txtPass.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.State = frmState.Add;

            this.txtUser.Text = string.Empty;
            this.txtPass.Text = string.Empty;
            this.txtConfirm.Text = string.Empty;

            this.txtUser.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUser.Text.Trim()))
            {
                MessageBox.Show(this,"Required information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUser.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtPass.Text.Trim()))
            {
                MessageBox.Show(this, "Required information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPass.Focus();
            }
            else if (!this.txtPass.Text.Trim().Equals(this.txtConfirm.Text.Trim()))
            {
                MessageBox.Show(this, "Passwords do not match", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPass.Text = string.Empty;
                this.txtConfirm.Text = string.Empty;
                this.txtPass.Focus();
            }
            else {
                try
                {
                    if (this.State == frmState.Add)
                    {
                        if (!caUsersModel.insertUser(new caUsers()
                        {
                            user = this.txtUser.Text.Trim(),
                            password = Hash.Encode(this.txtPass.Text.Trim())
                        }))
                        {
                            MessageBox.Show(this, "Previously registered user, please review", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.populateGrid();
                            this.State = frmState.Normal;
                            MessageBox.Show(this, "User added", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else {
                        if (!caUsersModel.editUser(new caUsers()
                        {
                            id = this.selectItem.id,
                            password = Hash.Encode(this.txtPass.Text.Trim())
                        }))
                        {
                            MessageBox.Show(this, "User not found", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.State = frmState.Normal;
                            MessageBox.Show(this, "User updated", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception)
                {
                    //throw;
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.State = frmState.Normal;
        }

        private caUsers selectItem;
        private void caUsersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.selectItem = ((caUsers)((BindingSource)sender).Current);
            try
            {
                this.txtUser.Text = this.selectItem.user;
            }
            catch (Exception) { }
        }

        
    }
}
