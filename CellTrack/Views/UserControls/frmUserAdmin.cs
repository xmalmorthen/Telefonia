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
    public partial class frmUserAdmin : UserControl
    {
        public frmUserAdmin()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            Populate();
        }

        private void Populate()
        {
            usuarioModel model = new usuarioModel(){
                id = usuarioController.usuarioLogueado.info.id,
                NombreCompleto = string.Format("{0} {1} {2}",usuarioController.usuarioLogueado.info.PrimerApellido,usuarioController.usuarioLogueado.info.SegundoApellido,usuarioController.usuarioLogueado.info.Nombres),
                usuario = usuarioController.usuarioLogueado.info.usuario,
                Perfil = usuarioController.usuarioLogueado.info.caperfiles.perfil,
                Grupo = usuarioController.usuarioLogueado.info.cagrupos.grupo,
                esSupervisor = usuarioController.usuarioLogueado.info.esSupervisor ? "Si" : "No",
                active = usuarioController.usuarioLogueado.info.active ? "Activo" : "Inactivo",
                cantidadLocalizaciones = usuarioController.usuarioLogueado.info.cantidadLocalizaciones != null ? usuarioController.usuarioLogueado.info.cantidadLocalizaciones.ToString() : "Ilimitado",
                fIns = usuarioController.usuarioLogueado.info.fIns.ToLongDateString(),
                fAct = usuarioController.usuarioLogueado.info.fAct != null ? ((DateTime)usuarioController.usuarioLogueado.info.fAct).ToLongDateString() : string.Empty
            };
            usuarioModelBindingSource.DataSource = model;
            Objetivos();
        }

        private void Objetivos()
        {
            List<localizationsModel> objetivos = new List<localizationsModel>();
            //Obtener lista de objetivos
            foreach (malocalizations item in objetivosController.getTargets(usuarioController.usuarioLogueado.info.id))
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
            localizationsModelBindingSource.DataSource = objetivos;
            gdObjetivos.DataSource = localizationsModelBindingSource;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPwd.Text.Trim())) 
                if (!string.IsNullOrEmpty(txtPwd2.Text.Trim()))
                {
                    if (!txtPwd.Text.Trim().Equals(txtPwd2.Text.Trim())) {
                        MessageBox.Show(this,"La contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPwd2.SelectAll();
                        txtPwd2.Focus();
                        return;
                    }
                } else {
                    MessageBox.Show(this,"Debe repetir la contraseña", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPwd2.Focus();
                    return;
                }
            else{
                MessageBox.Show(this,"Debe especificar la contraseña", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }

            usuarioController.changePassword(txtPwd.Text.Trim());
        }
    }
}
