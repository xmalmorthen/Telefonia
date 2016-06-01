using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellTrack.Models;
using CellTrack.Classes;
using CellTrack.Controllers;
using MetroFramework.Controls;
using CellTrack.Models.DataBases;
using MetroFramework;

namespace CellTrack.Views.UserControls.Admin
{
    public partial class usrCtrlPerfilesRoles : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {

                splitContainer.Panel2Collapsed = value != enums.frmState.Normal;

                txtPerfil.ReadOnly = value == enums.frmState.Normal;
                SelectRol.ReadOnly = value == enums.frmState.Normal;
                tgGpoActivo.Enabled = value != enums.frmState.Normal;
                
                splitContainer.Panel2.Enabled = value == enums.frmState.Normal;

                pnlBtnsActions.Enabled = value != enums.frmState.Normal;
                btnSelectAll.Enabled = value != enums.frmState.Normal;
                btnSelectionNone.Enabled = value != enums.frmState.Normal;

                txtPerfil.Enabled = value == enums.frmState.Add;
                
                frmState = value; 
            }
        }

        public usrCtrlPerfilesRoles()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            FrmState = enums.frmState.Normal;

            this.populate();
        }

        private void populate()
        {
            try
            {
                Perfiles();
                Roles();
            }
            catch (Exception){}            
        }

        private void Perfiles()
        {
            string filter = txtFind.Text;
            if (string.IsNullOrEmpty(filter)) 
                caperfilesBindingSource.DataSource = rolesPerfilesController.perfiles;
            else
                caperfilesBindingSource.DataSource = rolesPerfilesController.perfiles.Where(qry => qry.perfil.Contains(filter) && qry.isDeleted.Equals(false)).ToList();
        }

        private void Roles()
        {
            carolesBindingSource.DataSource = rolesPerfilesController.roles;
            foreach (reperfilroles item in  rolesPerfilesController.rolesAsignadosAPerfil(((caperfiles)caperfilesBindingSource.Current).id))
            {
                foreach (DataGridViewRow row in gdRolesAsignados.Rows)
                {
                    if (row.Cells[0].Value.Equals(item.idRol))
                    {
                        row.Cells[6].Value = true;
                        break;
                    }
                }
            }
        }

        private caperfiles newItem;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmState = enums.frmState.Add;
            newItem = caperfilesBindingSource.AddNew() as caperfiles;

            newItem.activo = true;
            tgGpoActivo.Checked = true;

            btnSelectAll_Click(btnSelectionNone, null);

            txtPerfil.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            #region FORM VALIDATIONS
            if (string.IsNullOrEmpty(txtPerfil.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar el Nombre del Perfil", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPerfil.Focus();
                return;
            }
            #endregion FORM VALIDATIONS

            try
            {
                switch (FrmState)
                {
                    case enums.frmState.Add:
                        if (rolesPerfilesController.perfiles.SingleOrDefault(qry => qry.perfil.Equals(txtPerfil.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)) != null)
                            throw new Exception("El grupo ya se encuentra registrado, favor de revisar.");
                        if (!rolesPerfilesController.insert(newItem))
                            throw new Exception("Ocurrió un error al guardar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                        break;
                    case enums.frmState.Edit:
                        if (!rolesPerfilesController.edit(caperfilesBindingSource.Current as caperfiles))
                            throw new Exception("Ocurrió un error al editar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                        break;
                }

                List<int> rolesAsignados = new List<int>();
                foreach (DataGridViewRow item in gdRolesAsignados.Rows)
                {
                    if (item.Cells[6].Value != null)
                        if (!item.Cells[6].Value.Equals(false))
                            rolesAsignados.Add(int.Parse(item.Cells[0].Value.ToString()));
                }

                int idPerfil = FrmState == enums.frmState.Add ? newItem.id : ((caperfiles)caperfilesBindingSource.Current).id;

                if (!rolesPerfilesController.actualizaRoles(idPerfil, rolesAsignados))
                    throw new Exception("Ocurrió un error al guardar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");


                caperfilesBindingSource.CancelEdit();
                FrmState = enums.frmState.Normal;
                Perfiles();
                MetroMessageBox.Show(this, "Acción exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirme la limpieza del formulario, la información introducida se perderá", "Limpiar formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                caperfilesBindingSource.CancelEdit();
                if (FrmState.Equals(enums.frmState.Add))
                    btnAdd_Click(null, null);
                else {
                    DAL.discardChanges<caperfiles>(((caperfiles)caperfilesBindingSource.Current));
                    caperfilesBindingSource.ResetCurrentItem();

                    Roles();
                    btnEdit_Click(null, null);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirme la cancelación", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (FrmState.Equals(enums.frmState.Add))
                    caperfilesBindingSource.CancelEdit();
                else
                {
                    DAL.discardChanges<caperfiles>(((caperfiles)caperfilesBindingSource.Current));
                    caperfilesBindingSource.ResetCurrentItem();
                }
                FrmState = enums.frmState.Normal;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (((caperfiles)caperfilesBindingSource.Current) != null)
            {
                FrmState = enums.frmState.Edit;
                gdRolesAsignados.Focus();
            }
            else
                btnAdd_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Confirme la eliminación", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!rolesPerfilesController.delete(caperfilesBindingSource.Current as caperfiles))
                        throw new Exception("Ocurrió un error al eliminar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                    FrmState = enums.frmState.Normal;
                    Perfiles();
                    MetroMessageBox.Show(this, "Acción exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Perfiles();
        }

        private void tgGpoActivo_CheckedChanged(object sender, EventArgs e)
        {
            lblActivo.Text = ((MetroToggle)sender).Checked ? "Activo" : "Inactivo";
        }

        private void btnRefreshRoles_Click(object sender, EventArgs e)
        {
            Roles();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            Boolean? value = null;
            if (((MetroButton)sender).Name.Equals("btnSelectAll"))
                value = true;

            foreach (DataGridViewRow item in gdRolesAsignados.Rows)
                item.Cells[6].Value = value;
        }

        private void caperfilesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Roles();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            Perfiles();
        }

    }
}
