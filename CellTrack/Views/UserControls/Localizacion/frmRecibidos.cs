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

namespace CellTrack.Views.UserControls.Localización    
{
    public partial class frmRecibidos : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                frmState = value; 
            }
        }

        private gMapView gMapViewRender = new gMapView(19.255185, -103.688263);

        public frmRecibidos()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            splitContainer.SplitterDistance = 100;
            
            FrmState = enums.frmState.Normal;

            this.populate();

            gMapViewRender.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(gMapViewRender);
        }

        private void populate()
        {            
            this.Objetivos();
        }

        private void Objetivos()
        {
            List<PDUModel> objetivos = new List<PDUModel>();
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
                    Carrier = carrier.carrier;
                }
                catch (Exception)
                {
                    Carrier = "El carrier no se encuentra registrado";
                }

                objetivos.Add(new PDUModel()
                {
                    id = item.id,
                    descrip = string.Format("{0} [ {1} ] - {2}", item.nombre,item.objetivo, item.cacarriers.carrier )
                });
            }
            bsObjetivos.DataSource = objetivos;
            cmbTargets.DataSource = bsObjetivos;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                recibidosModelBindingSource.DataSource = recibidosController.smsRecibidosByObjetivo(((PDUModel)bsObjetivos.Current).descrip.Substring(((PDUModel)bsObjetivos.Current).descrip.IndexOf('[') + 2, 10));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private int? idMarked = null;
        private void recibidosModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!idMarked.Equals((recibidosModelBindingSource.Current as recibidosModel).id))
            {
                idMarked = (recibidosModelBindingSource.Current as recibidosModel).id;
                markersModel marker = recibidosController.setMarker(recibidosModelBindingSource.Current as recibidosModel, gMapViewRender.gMap);
                if (marker == null) throw new NullReferenceException("No se pudo localizar");
            }
        }

        private void cmbTargets_DropDown(object sender, EventArgs e)
        {
            this.Objetivos();
        }
        
    }
}
