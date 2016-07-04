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
using CellTrack.Views.UserControls.Localización;

namespace CellTrack.Views.UserControls
{
    public partial class frmInvestigacion : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set
            {
                frmState = value;
                splitContainer.Enabled = value != enums.frmState.Find;
                pnlInfo.Visible = value == enums.frmState.Finded;
            }
        }

        public frmInvestigacion()
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
                    descrip = string.Format("{0} [ {1} ] - {2}", item.nombre, item.objetivo, item.cacarriers.carrier),
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
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<investigationModel> investigationList = investigacionController.Find(e.Argument as PDUModel);
            e.Result = investigationList;

            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

        }

        List<investigationModel> result = null;
        void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FrmState = enums.frmState.Normal;
            if (!e.Cancelled)
            {
                if (((List<investigationModel>)e.Result) != null)
                {
                    result = (List<investigationModel>)e.Result;
                    investigationModelBindingSource.DataSource = result;
                    FrmState = enums.frmState.Finded;
                }
                else
                {
                    MetroMessageBox.Show(this, "No se encontraron registros de seguimiento...", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                wrker.CancelAsync();
            }
        }

        private void gdObjetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (((investigationModel)investigationModelBindingSource.Current).detalle.Count > 0)
                {
                    frmShowMap frmMap = new frmShowMap((investigationModel)investigationModelBindingSource.Current);
                    frmMap.ShowDialog(this);
                }
                else
                    MetroMessageBox.Show(this, "No se encontró información de geoubicación...", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
