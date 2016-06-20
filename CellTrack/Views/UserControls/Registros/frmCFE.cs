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
using MySql.Data.MySqlClient;
using CellTrack.Models.Registros;
using MetroFramework.Controls;
using CellTrack.Controllers.RegistrosControllers;
using System.Threading;

namespace CellTrack.Views.UserControls
{
    public partial class frmCFE : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                frmState = value;

                tlpProc.Visible = frmState == enums.frmState.Find;
                splitContainer.Enabled = frmState == enums.frmState.Normal;

                lblCantReg.Visible = frmState == enums.frmState.Normal && bsCFE.Count > 0;
            }
        }

        public frmCFE()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            splitContainer.SplitterDistance = 150;
            FrmState = enums.frmState.Normal;
            this.populate();
            
            gdIFE.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void populate()
        {
            List<entidadesModel> entidades = new List<entidadesModel>();
            entidades.Add(new entidadesModel()
            {
                noment = "TODAS",
                nument = "00"
            });

            try
            {
                entidades.AddRange(entidadesController.getEntidades);
                bsEntidades.DataSource = entidades;    
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
                throw new NullReferenceException("Error al obtener la lista de entidades");
            }
        }

        private void tgExacta_CheckedChanged(object sender, EventArgs e)
        {
            lblExacta.Text = ((MetroToggle)sender).Checked ? "SI" : "NO";
        }

        BackgroundWorker wrker = null;
        struct wrkerStruct
        {
            public string idEntidad;
            public List<string> searchFields;
            public string cad;
            public Boolean exacta;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCad.Text.Trim())) {
                MetroMessageBox.Show(this, "Debe indicar la cadena a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCad.Focus();
                return;
            }
            if (!chkNombre.Checked && !chkServicio.Checked && !chkDomicilio.Checked) {
                MetroMessageBox.Show(this, "Debe seleccionar al menos un campo en donde buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flowLayoutPanel1.Focus();
                return;
            }

            btnCancel.Click += btnCancel_Click;

            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsCFE.DataSource = null;

            List<string> searchFields = new List<string>();

            if (chkNombre.Checked) searchFields.Add("nombre");
            if (chkServicio.Checked) searchFields.Add("servicio");
            if (chkDomicilio.Checked) searchFields.Add("domicilio");

            wrkerStruct str = new wrkerStruct()
            {
                idEntidad = ((entidadesModel)bsEntidades.Current).nument,
                searchFields = searchFields,
                cad = txtCad.Text.Trim(),
                exacta = tgExacta.Checked
            };

            wrker = new BackgroundWorker();
            wrker.WorkerSupportsCancellation = true;
            wrker.DoWork += wrker_DoWork;
            wrker.RunWorkerCompleted += wrker_RunWorkerCompleted;
            wrker.RunWorkerAsync(str);
            
            Application.DoEvents();
        }

        private void wrker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            wrkerStruct str = (wrkerStruct)e.Argument;

            e.Result = CFEController.find(str.idEntidad,
                                          str.searchFields,
                                          str.cad,
                                          str.exacta);

            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                List<CFEModel> data = (List<CFEModel>)e.Result;
                ((BackgroundWorker)sender).CancelAsync();

                if (data != null)
                {
                    if (unFilterList != null) unFilterList.Clear();

                    unFilterList = new List<CFEModel>(data);
                    bsCFE.DataSource = data;
                    lblCantReg.Text = string.Format("[ {0} ] Registros Encontrados", data.Count.ToString());
                    FrmState = enums.frmState.Normal;
                }
                else
                {
                    FrmState = enums.frmState.Normal;
                    MetroMessageBox.Show(this, "No se encontraron resultados que coincidan con la búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            btnCancel.Click -= btnCancel_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IFEController.cancelFind();
            wrker.CancelAsync();
            FrmState = enums.frmState.Normal;
        }

        private List<CFEModel> unFilterList;
        private BackgroundWorker wrk = new BackgroundWorker();
        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnCancel.Click += btnCancelFilter_Click;
            
            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsCFE.DataSource = null;
            
            wrk.WorkerSupportsCancellation = true;
            wrk.DoWork += wrk_DoWork;
            wrk.RunWorkerCompleted += wrk_RunWorkerCompleted;
            wrk.RunWorkerAsync(txtFind.Text);

            Application.DoEvents();     
        }

        void wrk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
                bsCFE.DataSource = (List<CFEModel>)e.Result;
            btnCancel.Click -= btnCancelFilter_Click;
            FrmState = enums.frmState.Normal;
        }

        void wrk_DoWork(object sender, DoWorkEventArgs e)
        {
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            string filter = (string)e.Argument;

            List<CFEModel> data = null;
            if (string.IsNullOrEmpty(filter))
                data = new List<CFEModel>(unFilterList);
            else
            {
                data = new List<CFEModel>(unFilterList.Where(qry => qry.servicio.Contains(filter) ||
                                                                    qry.nombre.Contains(filter) ||
                                                                    qry.direccion.Contains(filter)));
            }
            e.Result = data;
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            wrk.CancelAsync();
            bsCFE.DataSource = unFilterList;

            FrmState = enums.frmState.Normal;
        }

    }
}
