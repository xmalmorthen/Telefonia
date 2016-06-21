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
    public partial class frmNEXTEL : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                frmState = value;

                tlpProc.Visible = frmState == enums.frmState.Find;
                splitContainer.Enabled = frmState == enums.frmState.Normal;

                lblCantReg.Visible = frmState == enums.frmState.Normal && (bsNEXTEL != null ? bsNEXTEL.Count > 0 : false);
            }
        }

        public frmNEXTEL()
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
        }

        private void tgExacta_CheckedChanged(object sender, EventArgs e)
        {
            lblExacta.Text = ((MetroToggle)sender).Checked ? "SI" : "NO";
        }

        BackgroundWorker wrker = null;
        struct wrkerStruct
        {
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
            if (!chkNombre.Checked && !chkDomicilio.Checked && !chkTel.Checked && !chkRadio.Checked && !chkEmpresa.Checked) {
                MetroMessageBox.Show(this, "Debe seleccionar al menos un campo en donde buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flowLayoutPanel1.Focus();
                return;
            }

            btnCancel.Click += btnCancel_Click;

            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsNEXTEL.DataSource = null;

            List<string> searchFields = new List<string>();

            if (chkNombre.Checked) searchFields.Add("nombre");
            if (chkDomicilio.Checked) searchFields.Add("domicilio");
            if (chkTel.Checked) searchFields.Add("telefono");
            if (chkRadio.Checked) searchFields.Add("radio");
            if (chkEmpresa.Checked) searchFields.Add("empresa");

            wrkerStruct str = new wrkerStruct()
            {
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

            e.Result = NEXTELController.find(str.searchFields,
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
                List<NEXTELModel> data = (List<NEXTELModel>)e.Result;
                ((BackgroundWorker)sender).CancelAsync();

                if (data != null)
                {
                    if (unFilterList != null) unFilterList.Clear();

                    unFilterList = new List<NEXTELModel>(data);
                    bsNEXTEL.DataSource = data;
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

        private List<NEXTELModel> unFilterList;
        private BackgroundWorker wrk = new BackgroundWorker();
        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnCancel.Click += btnCancelFilter_Click;
            
            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsNEXTEL.DataSource = null;
            
            wrk.WorkerSupportsCancellation = true;
            wrk.DoWork += wrk_DoWork;
            wrk.RunWorkerCompleted += wrk_RunWorkerCompleted;
            wrk.RunWorkerAsync(txtFind.Text);

            Application.DoEvents();     
        }

        void wrk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (e.Result != null)
                    bsNEXTEL.DataSource = (List<NEXTELModel>)e.Result;
            }
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

            List<NEXTELModel> data = null;
            if (string.IsNullOrEmpty(filter))
                data = new List<NEXTELModel>(unFilterList);
            else
            {
                data = new List<NEXTELModel>(unFilterList.Where(qry => qry.radio.Contains(filter) ||
                                                                    qry.rfc.Contains(filter) ||
                                                                    qry.empresa.Contains(filter) ||
                                                                    qry.direccion.Contains(filter) ||
                                                                    qry.colonia.Contains(filter) ||
                                                                    qry.cpostal.Contains(filter) ||
                                                                    qry.estado.Contains(filter) ||
                                                                    qry.ciudad.Contains(filter) ||
                                                                    qry.telefono.Contains(filter) ||
                                                                    qry.empresa1.Contains(filter) ||
                                                                    qry.direccion1.Contains(filter) ||
                                                                    qry.colonia1.Contains(filter) ||
                                                                    qry.cpostal1.Contains(filter) ||
                                                                    qry.telefono1.Contains(filter) ||
                                                                    qry.telefono2.Contains(filter) ||
                                                                    qry.empresa3.Contains(filter) ||
                                                                    qry.telefono3.Contains(filter) ||
                                                                    qry.tipocta.Contains(filter) ||
                                                                    qry.digitos.Contains(filter)
                                                                    ));
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
            bsNEXTEL.DataSource = unFilterList;

            FrmState = enums.frmState.Normal;
        }

    }
}