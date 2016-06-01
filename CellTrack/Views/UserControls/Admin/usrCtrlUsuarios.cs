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
    public partial class usrCtrlUsuarios : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                splitContainerUsuarios.Panel1.Enabled = value != enums.frmState.Normal;
                splitContainerUsuarios.Panel2Collapsed = value != enums.frmState.Normal;

                txtPwd.Text = "";

                frmState = value; 
            }
        }

        public usrCtrlUsuarios()
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
            caperfilesBindingSource.DataSource = catalogosController.perfiles;
            cagruposBindingSource.DataSource = gruposController.activeGrupos;
            Usuarios();
        }

        private void tgSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            lblSupervisor.Text = ((MetroToggle)sender).Checked ? "Si" : "No";
        }

        private void tgActivo_CheckedChanged(object sender, EventArgs e)
        {
            lblActivo.Text = ((MetroToggle)sender).Checked ? "Activo" : "Inactivo";
        }

        private causuarios newItem;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmState = enums.frmState.Add;
            newItem = causuariosBindingSource.AddNew() as causuarios;
            cmbPerfil.SelectedIndex = -1; //Forzar a limpiar el combo, en el evento de AddingNew del databinding no refleja el cambio
            cmbGpo.SelectedIndex = -1; //Forzar a limpiar el combo, en el evento de AddingNew del databinding no refleja el cambio            

            newItem.active = true;
            tgUserActivo.Checked = true;

            txtNombre.Focus();
        }

        private void txtCantLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            #region FORM VALIDATIONS
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar el/los Nombre(s)", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPAp.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar el Primer Apellido", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPAp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar el nombre de usuario", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            if (FrmState == enums.frmState.Add && string.IsNullOrEmpty(txtPwd.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar la contraseña", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPwd.Focus();
                return;
            }

            if (cmbPerfil.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "Debe asignar un Perfil", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPerfil.Focus();
                return;
            }

            if (cmbGpo.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "Debe asociar el usuario a un grupo", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGpo.Focus();
                return;
            }
                        
            #endregion FORM VALIDATIONS

            try
            {
                Boolean verifySupervisor = FrmState == enums.frmState.Add ? newItem.esSupervisor : (causuariosBindingSource.Current as causuarios).esSupervisor;
                int idGpo = FrmState == enums.frmState.Add ? newItem.idGpo : (causuariosBindingSource.Current as causuarios).idGpo;
                string usr = FrmState == enums.frmState.Add ? newItem.usuario : (causuariosBindingSource.Current as causuarios).usuario;

                if (FrmState == enums.frmState.Add)
                {
                    if (usuarioController.usuarios.Count(qry => qry.usuario.Equals(txtUser.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)) > 0)
                        throw new Exception("El usuario ya se encuentra registrado, favor de revisar.");
                }
                else
                {
                    if (usuarioController.usuarios.Count(qry => qry.id != (causuariosBindingSource.Current as causuarios).id && qry.usuario.Equals(txtUser.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)) > 0)
                        throw new Exception("El usuario ya se encuentra registrado, favor de revisar.");
                }

                if (verifySupervisor)
                    if (usuarioController.usuarios.Count(qry => qry.idGpo.Equals(idGpo) && qry.esSupervisor.Equals(true) && qry.active.Equals(true) && qry.usuario != usr) > 0)
                        throw new Exception("Ya se encuentra un usuario como supervisor del grupo, imposible hacer la asignación.");

                switch (FrmState)
                {
                    case enums.frmState.Add:
                        newItem.contrasenia = txtPwd.Text.Trim();
                        newItem.cantidadLocalizaciones = int.Parse(txtCantLoc.Text);

                        if (!usuarioController.insert(newItem))
                            throw new Exception("Ocurrió un error al guardar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                        break;
                    case enums.frmState.Edit:
                        if (!string.IsNullOrEmpty(txtPwd.Text))
                            (causuariosBindingSource.Current as causuarios).contrasenia = md5.Get(txtPwd.Text.Trim());

                        (causuariosBindingSource.Current as causuarios).cantidadLocalizaciones = int.Parse(txtCantLoc.Text);

                        if (!usuarioController.edit(causuariosBindingSource.Current as causuarios))
                            throw new Exception("Ocurrió un error al editar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                        break;
                }
                causuariosBindingSource.CancelEdit();
                FrmState = enums.frmState.Normal;
                Usuarios();
                MetroMessageBox.Show(this, "Acción exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuarios()
        {
            string filter = txtFind.Text.Trim();
            if (string.IsNullOrEmpty(filter))
                causuariosBindingSource.DataSource = usuarioController.usuarios;
            else
                causuariosBindingSource.DataSource = usuarioController.usuarios.Where(qry => string.Format("{0} {1} {2} {3} {4}", qry.Nombres, qry.PrimerApellido, qry.SegundoApellido, qry.usuario.ToUpper(), qry.cagrupos.descrip.ToUpper()).Trim().Contains(filter)  && qry.isDeleted.Equals(false) && qry.cagrupos.activo.Equals(true) && qry.cagrupos.isDeleted.Equals(false)).ToList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirme la limpieza del formulario, la información introducida se perderá", "Limpiar formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                causuariosBindingSource.CancelEdit();
                if (FrmState.Equals(enums.frmState.Add))
                    btnAdd_Click(null, null);
                else {
                    DAL.discardChanges<causuarios>(((causuarios)causuariosBindingSource.Current));
                    causuariosBindingSource.ResetCurrentItem();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirme la cancelación", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (FrmState.Equals(enums.frmState.Add))
                    causuariosBindingSource.CancelEdit();
                else
                {
                    DAL.discardChanges<causuarios>(((causuarios)causuariosBindingSource.Current));
                    causuariosBindingSource.ResetCurrentItem();
                }
                FrmState = enums.frmState.Normal;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            FrmState = enums.frmState.Edit;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Confirme la eliminación", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!usuarioController.delete(causuariosBindingSource.Current as causuarios))
                        throw new Exception("Ocurrió un error al eliminar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                    FrmState = enums.frmState.Normal;
                    Usuarios();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Usuarios();
        }
       
        private void cmbPerfil_DropDown(object sender, EventArgs e)
        {
            caperfilesBindingSource.DataSource = catalogosController.perfiles;
        }

        private void cmbGpo_DropDown(object sender, EventArgs e)
        {
            cagruposBindingSource.DataSource = gruposController.activeGrupos;
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            Usuarios();
        }

    }
}
