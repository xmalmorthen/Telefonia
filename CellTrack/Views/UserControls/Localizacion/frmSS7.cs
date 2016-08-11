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
    public partial class frmSS7 : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                frmState = value;

                splitContainer.Enabled = value != enums.frmState.Find;

                pnlCountDown.Visible = value == enums.frmState.Find;
            }
        }

        private gMapView gMapViewRender = new gMapView(Properties.Settings.Default.MapInitPointLat,Properties.Settings.Default.MapInitPointLng);

        public frmSS7()
        {
            InitializeComponent();
            this.init();            
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            splitContainer.SplitterDistance = 80;

            FrmState = enums.frmState.Normal;

            this.populate();

            gMapViewRender.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(gMapViewRender);
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
                    descrip = string.Format("{0} [ {1} ] - {2}", item.nombre,item.objetivo, item.cacarriers.carrier ),
                    obj = item
                });
            }
            bsObjetivos.DataSource = objetivos;
            cmbTargets.DataSource = bsObjetivos;
        }

        BackgroundWorker wrker;
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                FrmState = enums.frmState.Find;
                wrker = new BackgroundWorker();
                wrker.WorkerSupportsCancellation = true;
                wrker.DoWork += wrker_DoWork;
                wrker.RunWorkerCompleted += wrker_RunWorkerCompleted;
                wrker.RunWorkerAsync(bsObjetivos.Current as PDUModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void wrker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            Application.DoEvents();
            //markersModel marker = PDUController.PDUFind(e.Argument as PDUModel, gMapViewRender.gMap, false, MainMap_OnMarkerEnter, MainMap_OnMarkerLeave);
            //e.Result = marker;

            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

        }

        private void MainMap_OnMarkerEnter(GMapMarker item)
        {
            desmsrecibidos tag = (desmsrecibidos)item.Tag;

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

        markersModel result = null;
        void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FrmState = enums.frmState.Normal;
            if (!e.Cancelled)
            {
                if (((markersModel)e.Result) != null)
                {
                    result = (markersModel)e.Result;
                    gMapViewRender.gMap.MainMap.ZoomAndCenterMarkers(null);
                }
                else {
                    MessageBox.Show(this, "No se obtuvo respuesta, favor de consultar en la ventana de seguimiento mas tarde...", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                wrker.CancelAsync();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            wrker.CancelAsync();
            FrmState = enums.frmState.Normal;
        }

        private void cmbTargets_DropDown(object sender, EventArgs e)
        {
            this.Objetivos();
        }
        
    }
}
