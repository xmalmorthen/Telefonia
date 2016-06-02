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
                    objetivo = Guid.NewGuid().ToString().Substring(0, 10),
                    idNotification = i,
                    NotificationName = Guid.NewGuid().ToString(),
                    idCarrier = 3,
                    Carrier = "TELCEL",
                    Agenda = string.Format("De {0} a {1} frecuencia {2} min.", 10, 20, 10),
                    agendaDe = 10,
                    agendaA = 22,
                    agendaFrecuencia = 5
                });
            }

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
    }
}
