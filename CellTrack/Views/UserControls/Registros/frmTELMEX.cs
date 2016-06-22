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
using System.Diagnostics;

namespace CellTrack.Views.UserControls
{
    public partial class frmTELMEX : UserControl
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

        public frmTELMEX()
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
            
            gdTELMEX.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void populate()
        {
            bsTipos.DataSource = tipoTELMEXModel.populate;

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
            public string tipo;
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
            if (!chkNombre.Checked && !chkNumero.Checked && !chkDomicilio.Checked && !chkCP.Checked) {
                MetroMessageBox.Show(this, "Debe seleccionar al menos un campo en donde buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flowLayoutPanel1.Focus();
                return;
            }

            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsTELMEX.DataSource = null;

            List<string> searchFields = new List<string>();

            if (chkNombre.Checked) searchFields.Add("nombre");
            if (chkNumero.Checked) searchFields.Add("numero");
            if (chkDomicilio.Checked) searchFields.Add("domicilio");
            if (chkCP.Checked) searchFields.Add("cp");

            wrkerStruct str = new wrkerStruct()
            {
                idEntidad = ((entidadesModel)bsEntidades.Current).nument,
                tipo = ((tipoTELMEXModel)bsTipos.Current).key,
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

            e.Result = TELMEXController.find(str.idEntidad,
                                            str.tipo,
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
                List<TELMEXModel> data = (List<TELMEXModel>)e.Result;
                ((BackgroundWorker)sender).CancelAsync();

                if (data != null)
                {
                    FrmState = enums.frmState.Finded;
                    if (unFilterList != null) 
                        unFilterList.Clear();
                    unFilterList = new List<TELMEXModel>(data);
                    bsTELMEX.DataSource = data;
                }
                FrmState = enums.frmState.Normal;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TELMEXController.cancelFind();
            wrker.CancelAsync();
            FrmState = enums.frmState.Normal;
        }

        private List<TELMEXModel> unFilterList;
        private BackgroundWorker wrk = new BackgroundWorker();
        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnCancel.Click += btnCancelFilter_Click;

            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsTELMEX.DataSource = null;

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
                    bsTELMEX.DataSource = (List<TELMEXModel>)e.Result;
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

            List<TELMEXModel> data = null;
            if (string.IsNullOrEmpty(filter))
                data = new List<TELMEXModel>(unFilterList);
            else
            {
                Boolean preFab = ((tipoTELMEXModel)bsTipos.Current).key.Equals("telcas");
                if (!preFab)
                {
                    data = new List<TELMEXModel>(unFilterList.Where(qry => qry.numero.Contains(filter) ||
                                                                            qry.nombre.Contains(filter) ||
                                                                            qry.direccion.Contains(filter) ||
                                                                            qry.cpostal.Contains(filter) ||
                                                                            qry.colonia.Contains(filter) ||
                                                                            qry.municipio.Contains(filter) ||
                                                                            qry.estado.Contains(filter)));
                }
                else {
                    data = new List<TELMEXModel>(unFilterList.Where(qry => qry.numero.Contains(filter) ||
                                                                                qry.direccion.Contains(filter) ||
                                                                                qry.municipio.Contains(filter) ||
                                                                                qry.central.Contains(filter)));
                
                }
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
            bsTELMEX.DataSource = unFilterList;

            FrmState = enums.frmState.Normal;
        }

        private void bsTipos_CurrentChanged(object sender, EventArgs e)
        {
            Boolean preFab = ((tipoTELMEXModel)((BindingSource)sender).Current).key.Equals("telcas");

            chkNombre.Visible = !preFab;
            chkDomicilio.Visible = !preFab;
            chkCP.Visible = !preFab;

            chkNumero.Checked = preFab;

            if (preFab) bsEntidades.MoveFirst();
            cmbEntidad.Enabled = !preFab;

            gdTELMEX.Columns[1].Visible = !preFab;
            gdTELMEX.Columns[3].Visible = !preFab;
            gdTELMEX.Columns[4].Visible = !preFab;
            gdTELMEX.Columns[6].Visible = !preFab;
            gdTELMEX.Columns[7].Visible = preFab;
        }

        private void bsTELMEX_DataSourceChanged(object sender, EventArgs e)
        {
            if (FrmState == enums.frmState.Normal || FrmState == enums.frmState.Finded)
            {
                lblCantReg.Text = string.Format("[ {0} ] Registros Encontrados", ((BindingSource)sender).Count.ToString());
                if (((BindingSource)sender).Count == 0)
                    MetroMessageBox.Show(this, "No se encontraron resultados que coincidan con la búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
