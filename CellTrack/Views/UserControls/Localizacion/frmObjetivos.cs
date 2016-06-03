using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Controllers;
using CellTrack.Models.DataBases;
using MetroFramework;

namespace CellTrack.Views.UserControls
{
    public partial class frmObjetivos : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                splitContainer.Panel1Collapsed = value == enums.frmState.Normal;
                splitContainer.Panel2.Enabled = value == enums.frmState.Normal;

                frmState = value; 
            }
        }

        public frmObjetivos()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            splitContainer.SplitterDistance = 200;

            FrmState = enums.frmState.Normal;

            this.populate();
        }

        private void populate()
        {
            bsCarriers.DataSource = catalogosController.activeCarriers;
            bsNotifications.DataSource = usuarioController.usersNotifications;            
            this.Objetivos();
        }
        
        private void Objetivos()
        {
            List<malocalizations> dataTmp;
            string filter = txtFind.Text;
            if (string.IsNullOrEmpty(filter))
            {
                dataTmp = objetivosController.getTargets(usuarioController.usuarioLogueado.info.id);
            }
            else
            {
                dataTmp = objetivosController.getTargets(usuarioController.usuarioLogueado.info.id).Where(qry => qry.nombre.Contains(filter) || qry.objetivo.Contains(filter) || string.Format("{0} {1} {2}", qry.causuarios1.Nombres, qry.causuarios1.PrimerApellido, qry.causuarios1.SegundoApellido).Contains(filter) || qry.cacarriers.carrier.Contains(filter) && qry.active.Equals(true) && qry.isDeleted.Equals(false)).ToList();
            }

            List<localizationsModel> objetivos = new List<localizationsModel>();
            //Obtener lista de objetivos
            foreach (malocalizations item in dataTmp)
            {
                causuarios userNotification = usuarioController.getUserById(item.idNotification, false);
                string NotificationName = string.Empty;
                try
                {
                    NotificationName = string.Format("{0} {1} {2}", userNotification.Nombres, userNotification.PrimerApellido, userNotification.SegundoApellido);
                }
                catch (Exception)
                {
                    NotificationName = "El usuario de notificación no se encuentra registrado";
                }

                cacarriers carrier = catalogosController.carrierById(item.idCarrier);
                string Carrier = string.Empty;
                try
                {
                    Carrier = carrier.carrier;
                }
                catch (Exception)
                {
                    Carrier = "El carrier no se encuentra registrado";
                }

                objetivos.Add(new localizationsModel()
                {
                    id = item.id,
                    nombre = item.nombre,
                    asunto = item.asunto,
                    objetivo = item.objetivo,
                    idNotification = item.idNotification,
                    NotificationName = NotificationName,
                    idCarrier = item.idCarrier,
                    Carrier = Carrier,
                    agendaDe = item.agendaDe,
                    agendaA = item.agendaA,
                    agendaFrecuencia = item.agendaFrecuencia,
                    Agenda = item.agendaDe != null ? string.Format("De {0} a {1} frecuencia {2} min.", item.agendaDe, item.agendaA, item.agendaFrecuencia) : string.Empty
                });
            }
            bsObjetivos.DataSource = objetivos;
            gdObjetivos.DataSource = bsObjetivos;
        }

        private void txtfrecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private localizationsModel newItem;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmState = enums.frmState.Add;
            newItem = bsObjetivos.AddNew() as localizationsModel;
            cmbAgendaDe.SelectedIndex = -1; //Forzar a limpiar el combo, en el evento de AddingNew del databinding no refleja el cambio
            cmbAgendaA.SelectedIndex = -1; //Forzar a limpiar el combo, en el evento de AddingNew del databinding no refleja el cambio            
        }

        private void bsObjetivos_AddingNew(object sender, AddingNewEventArgs e)
        {
            cmbAgendaDe.SelectedIndex = -1;
            cmbAgendaA.SelectedIndex = -1;
            txtfrecuencia.Text = string.Empty;
            cmbCarrier.SelectedIndex = -1;
            cmbNotification.SelectedIndex = -1;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {            
            #region FORM VALIDATIONS
            if (string.IsNullOrEmpty(txtNombre.Text)) {
                MetroMessageBox.Show(this, "Debe indicar el Nombre", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (cmbCarrier.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "Debe indicar el Carrier", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCarrier.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtAsunto.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar el Asunto", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAsunto.Focus();
                return;
            }

            if (cmbNotification.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "Debe indicar el usuario a notificar", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNotification.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCel.Text))
            {
                MetroMessageBox.Show(this, "Debe indicar el número de celular", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCel.Focus();
                return;
            }

            if (txtCel.Text.Trim().Length != 10)
            {
                MetroMessageBox.Show(this, "Longitud de número de celular incorrecta", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCel.Focus();
                return;
            }
            
            if (cmbAgendaDe.SelectedIndex != -1 || cmbAgendaA.SelectedIndex != -1 || !string.IsNullOrEmpty(txtfrecuencia.Text))
            {
                MetroMessageBox.Show(this, "Debe configurar por completo la agenda", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbAgendaDe.SelectedIndex >= cmbAgendaA.SelectedIndex)
            {
                MetroMessageBox.Show(this, "Configuración de agenda incorrecta el horario de inicio no puede ser mayor o igual al de fin", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion FORM VALIDATIONS

            try
            {
                switch (frmState)
                {
                    case enums.frmState.Add:
                        if (!objetivosController.insertNewTarget(newItem))
                            throw new Exception("Ocurrió un error al guardar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                    break;
                    case enums.frmState.Edit:
                        if (!objetivosController.editTarget(bsObjetivos.Current as localizationsModel))
                            throw new Exception("Ocurrió un error al editar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                        break;
                }
                bsObjetivos.CancelEdit();
                FrmState = enums.frmState.Normal;
                Objetivos();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ( MetroMessageBox.Show(this, "Confirme la cancelación", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (FrmState.Equals(enums.frmState.Add))
                    bsObjetivos.CancelEdit();
                else
                {
                    Objetivos();
                    bsObjetivos.ResetCurrentItem();                    
                }
                FrmState = enums.frmState.Normal;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirme la limpieza del formulario, la información introducida se perderá", "Limpiar formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bsObjetivos.CancelEdit();
                btnAdd_Click(null, null);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Objetivos();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bsObjetivos.Current != null)
                FrmState = enums.frmState.Edit;
            else
                MetroMessageBox.Show(this, "No hay registro para modificar", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Confirme la eliminación", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!objetivosController.deleteTarget(bsObjetivos.Current as localizationsModel))
                        throw new Exception("Ocurrió un error al eliminar, favor de intentarlo de nuevo." + Environment.NewLine + "Si el problema persiste ponerse en contacto con el administrador del sistema");
                    FrmState = enums.frmState.Normal;
                    Objetivos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            Objetivos();
        }        
        
    }
}
