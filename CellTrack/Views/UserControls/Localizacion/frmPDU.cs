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
    public partial class frmPDU : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                frmState = value;

                splitContainer.Enabled = value != enums.frmState.Find;

                pnlCountDown.Visible = value == enums.frmState.Find;
                tmCountDown.Enabled = value == enums.frmState.Find;
                /*if (value == enums.frmState.Find)
                {
                    lblCountDown.Text = Properties.Settings.Default.PDUCountDown;
                    tmCountDown.Start();
                }
                else
                    tmCountDown.Stop();*/
            }
        }

        private gMapView gMapViewRender = new gMapView(Properties.Settings.Default.MapInitPointLat,Properties.Settings.Default.MapInitPointLng);

        public frmPDU()
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
            markersModel marker = PDUController.PDUFind(e.Argument as PDUModel, gMapViewRender.gMap);
            e.Result = marker;

            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

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

        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            /*int cnt =  int.Parse(lblCountDown.Text) - 1;
            lblCountDown.Text = (cnt).ToString("00");
            if (cnt == 0)
            {
                FrmState = enums.frmState.Normal;
                if (result == null)
                    MessageBox.Show(this, "No se obtuvo respuesta, favor de consultar en los recibidos mas tarde...", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
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
