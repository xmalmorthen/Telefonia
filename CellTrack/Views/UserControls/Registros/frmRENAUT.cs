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
    public partial class frmRENAUT : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set {
                frmState = value;

                tlpProc.Visible = frmState == enums.frmState.Find;
                splitContainer.Enabled = frmState == enums.frmState.Normal;
            }
        }

        public frmRENAUT()
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
                MessageBox.Show(this, "Debe indicar la cadena a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCad.Focus();
                return;
            }
            if (!chkNombre.Checked && !chkCelular.Checked) {
                MessageBox.Show(this, "Debe seleccionar al menos un campo en donde buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flowLayoutPanel1.Focus();
                return;
            }

            btnCancel.Click += btnCancel_Click;

            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsRENAUT.DataSource = null;

            List<string> searchFields = new List<string>();

            if (chkNombre.Checked) searchFields.Add("nombre");
            if (chkCelular.Checked) searchFields.Add("celular");

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

            e.Result = RENAUTController.find(str.searchFields,
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
                List<RENAUTModel> data = (List<RENAUTModel>)e.Result;
                ((BackgroundWorker)sender).CancelAsync();

                if (data != null)
                {
                    FrmState = enums.frmState.Finded;
                    if (unFilterList != null) 
                        unFilterList.Clear();
                    unFilterList = new List<RENAUTModel>(data);
                    bsRENAUT.DataSource = data;                    
                }
                FrmState = enums.frmState.Normal;                    
            }
            btnCancel.Click -= btnCancel_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IFEController.cancelFind();
            wrker.CancelAsync();
            FrmState = enums.frmState.Normal;
        }

        private List<RENAUTModel> unFilterList;
        private BackgroundWorker wrk = new BackgroundWorker();
        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnCancel.Click += btnCancelFilter_Click;
            
            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsRENAUT.DataSource = null;
            
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
                FrmState = enums.frmState.Finded;
                if (e.Result != null)
                    bsRENAUT.DataSource = (List<RENAUTModel>)e.Result;
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

            List<RENAUTModel> data = null;
            if (string.IsNullOrEmpty(filter))
                data = new List<RENAUTModel>(unFilterList);
            else
            {
                data = new List<RENAUTModel>(unFilterList.Where(qry => qry.celular.Contains(filter) ||
                                                                    qry.nombre.Contains(filter) ||
                                                                    qry.carrier.Contains(filter) ||
                                                                    qry.numero.Contains(filter) ||
                                                                    qry.tipo.Contains(filter) ||
                                                                    qry.cpp.Contains(filter) ||
                                                                    qry.campo1.Contains(filter) ||
                                                                    qry.campo2.Contains(filter)));
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
            bsRENAUT.DataSource = unFilterList;

            FrmState = enums.frmState.Normal;
        }
       
        private void bsRENAUT_DataSourceChanged(object sender, EventArgs e)
        {
            if (FrmState == enums.frmState.Normal || FrmState == enums.frmState.Finded)
            {
                lblCantReg.Text = string.Format("[ {0} ] Registros Encontrados", ((BindingSource)sender).Count.ToString());
                if (((BindingSource)sender).Count == 0)
                    MessageBox.Show(this, "No se encontraron resultados que coincidan con la búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}