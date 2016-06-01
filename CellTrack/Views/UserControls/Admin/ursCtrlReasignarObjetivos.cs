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
    public partial class ursCtrlReasignarObjetivos : UserControl
    {
        public ursCtrlReasignarObjetivos()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            splitContainer.SplitterDistance = 80;

            this.populate();
        }

        private void populate()
        {
            bsNotifications.DataSource = usuarioController.usersNotifications;
            this.Objetivos();
        }

        private void Objetivos()
        {
                //TODO: Implementar el filtrado

            /*string filter = txtFind.Text;
            if (string.IsNullOrEmpty(filter))
                cagruposBindingSource.DataSource = gruposController.grupos;
            else
                cagruposBindingSource.DataSource = gruposController.grupos.Where(qry => qry.grupo.Contains(filter) && qry.isDeleted.Equals(false)).ToList();*/


            List<localizationsModel> objetivos = new List<localizationsModel>();

            /*
             * MODELO DE PRUEBA
             * TODO: Eliminar al implementar
             */
            for (int i = 1; i < 10; i++)
            {
                objetivos.Add(new localizationsModel()
                {
                    id = i,
                    nombre = Guid.NewGuid().ToString(),
                    asunto = Guid.NewGuid().ToString(),
                    objetivo = Guid.NewGuid().ToString().Substring(0,10),
                    idNotification = i,
                    NotificationName = Guid.NewGuid().ToString(),
                    idCarrier = 3,
                    Carrier = "TELCEL",
                    Agenda = string.Format("De {0} a {1} frecuencia {2} min.",10,20,10),
                    agendaDe = 10,
                    agendaA = 22,
                    agendaFrecuencia = 5
                });    
            }

            //Obtener lista de objetivos
            foreach (malocalizations item in objetivosController.getTargets())
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
                    Carrier = string.Format("{0} {1} {2}", userNotification.Nombres, userNotification.PrimerApellido, userNotification.SegundoApellido);
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

        private void btnAccept_Click(object sender, EventArgs e)
        {            
            #region FORM VALIDATIONS
            if (cmbNotification.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "Debe indicar el usuario a notificar", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNotification.Focus();
                return;
            }
            #endregion FORM VALIDATIONS

            try
            {
                reasignarObjetivosController.update(bsObjetivos.Current as localizationsModel);
                bsObjetivos.CancelEdit();
                Objetivos();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Objetivos();
        }

        private void bsObjetivos_CurrentItemChanged(object sender, EventArgs e)
        {
            //btnAccept_Click(null, null);
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            Objetivos();
        }
        
    }
}
