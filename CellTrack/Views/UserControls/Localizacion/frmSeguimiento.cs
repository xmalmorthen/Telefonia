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
using GMap.NET.WindowsForms;

namespace CellTrack.Views.UserControls.Localización    
{
    public partial class frmSeguimiento : UserControl
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

        public frmSeguimiento()
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

            dtPeriodoDe.MaxDate = DateTime.Now;
            dtPeriodoA.MaxDate = DateTime.Now;

            dtPeriodoDe.Value = dtPeriodoDe.MaxDate;
            dtPeriodoA.Value = dtPeriodoA.MaxDate;

            //btnReport.Location = new Point(splitContainer.Panel2.Left + 10, splitContainer.Panel2.Top + 110);

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

        private List<seguimientoModel> targets = null;
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                targets = seguimientoController.markObjetivos(gMapViewRender.gMap,(PDUModel)bsObjetivos.Current,dtPeriodoDe.Value.Date, dtPeriodoA.Value.Date, MainMap_OnMarkerEnter, MainMap_OnMarkerLeave);
                if (targets.Count == 0)
                    MessageBox.Show(this, "No se encontraron puntos para mostrar...", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReport.Visible = targets.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainMap_OnMarkerEnter(GMapMarker item)
        {
            detalleRecibidosModel tag = (detalleRecibidosModel)item.Tag;

            lblRadio.Text = tag.radio;
            lblMCC.Text = tag.MCC;
            lblMNC.Text = tag.MNC;
            lblLAC.Text = tag.LAC;
            lblBTS.Text = tag.BTS;
            lblV.Text = tag.V;

            pnlInfoTarget.Visible = true;
        }

        private void MainMap_OnMarkerLeave(GMapMarker item)
        {
            pnlInfoTarget.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            seguimientoController.makeReport(gMapViewRender.gMap, targets);
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            btnReport.Location = new Point(splitContainer.Panel2.Left + 20, splitContainer.Panel2.Top + 50);
        }

        private void cmbTargets_DropDown(object sender, EventArgs e)
        {
            this.Objetivos();
        }
    }
}
