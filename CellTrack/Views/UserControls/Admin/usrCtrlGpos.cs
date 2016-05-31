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
    public partial class usrCtrlGpos : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                splitContainer.Panel1.Enabled = value != enums.frmState.Normal;
                splitContainer.Panel2.Enabled = value == enums.frmState.Normal;

                txtGrupo.Enabled = value == enums.frmState.Add;
                
                frmState = value; 
            }
        }

        public usrCtrlGpos()
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
            cagruposBindingSource.DataSource = gruposController.grupos;
            Grupos();
        }

        private cagrupos newItem;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmState = enums.frmState.Add;
            newItem = cagruposBindingSource.AddNew() as cagrupos;

            newItem.activo = true;
            tgGpoActivo.Checked = true;

            txtGrupo.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            #region FORM VALIDATIONS
            if (string.IsNullOrEmpty(txtGrupo.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar el Nombre del Grupo", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrupo.Focus();
                return;
            }
            #endregion FORM VALIDATIONS

            try
            {
                switch (frmState)
                {
                    case enums.frmState.Add:
                        if (gruposController.grupos.SingleOrDefault(qry => qry.grupo.Equals(txtGrupo.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)) != null)
                            throw new Exception("El grupo ya se encuentra registrado, favor de revisar.");
                        if (!gruposController.insert(newItem))
                            throw new Exception("Ocurrió un error al guardar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                        break;
                    case enums.frmState.Edit:
                        if (!gruposController.edit(cagruposBindingSource.Current as cagrupos))
                            throw new Exception("Ocurrió un error al editar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                        break;
                }
                cagruposBindingSource.CancelEdit();
                FrmState = enums.frmState.Normal;
                Grupos();
                MetroMessageBox.Show(this, "Acción exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grupos()
        {
            cagruposBindingSource.DataSource = gruposController.grupos;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirme la limpieza del formulario, la información introducida se perderá", "Limpiar formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cagruposBindingSource.CancelEdit();
                if (FrmState.Equals(enums.frmState.Add))
                    btnAdd_Click(null, null);
                else {
                    DAL.discardChanges<cagrupos>(((cagrupos)cagruposBindingSource.Current));
                    cagruposBindingSource.ResetCurrentItem();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirme la cancelación", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAL.discardChanges<cagrupos>(((cagrupos)cagruposBindingSource.Current));
                cagruposBindingSource.ResetCurrentItem();
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
                    if (!gruposController.delete(cagruposBindingSource.Current as cagrupos))
                        throw new Exception("Ocurrió un error al eliminar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                    FrmState = enums.frmState.Normal;
                    Grupos();
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
            Grupos();
        }

        private void tgGpoActivo_CheckedChanged(object sender, EventArgs e)
        {
            lblActivo.Text = ((MetroToggle)sender).Checked ? "Activo" : "Inactivo";
        }

    }
}
