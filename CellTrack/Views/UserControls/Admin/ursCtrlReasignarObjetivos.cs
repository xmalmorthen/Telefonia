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


        private List<localizationsModel> objetivos = new List<localizationsModel>();
        private void Objetivos()
        {
            List<malocalizations> dataTmp;
            string filter = txtFind.Text;
            if (string.IsNullOrEmpty(filter))
            {
                dataTmp = objetivosController.getTargets();
            }
            else
            {
                dataTmp = objetivosController.getTargets().Where(qry => qry.nombre.Contains(filter) || qry.objetivo.Contains(filter) || string.Format("{0} {1} {2}", qry.causuarios1.Nombres, qry.causuarios1.PrimerApellido, qry.causuarios1.SegundoApellido).Contains(filter) || qry.cacarriers.carrier.Contains(filter) && qry.active.Equals(true) && qry.isDeleted.Equals(false)).ToList();
            }

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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Objetivos();
        }

        private void bsObjetivos_CurrentItemChanged(object sender, EventArgs e)
        {
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            Objetivos();
        }

        private void cmbNotification_DropDown(object sender, EventArgs e)
        {
            bsNotifications.DataSource = usuarioController.usersNotifications;
        }

        private void ursCtrlReasignarObjetivos_Leave(object sender, EventArgs e)
        {
            try
            {
                reasignarObjetivosController.update(objetivos);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
