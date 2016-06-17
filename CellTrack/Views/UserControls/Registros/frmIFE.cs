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

namespace CellTrack.Views.UserControls
{
    public partial class frmIFE : UserControl
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

        public frmIFE()
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

        BackgroundWorker wrker = new BackgroundWorker();
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
            if (!chkNombre.Checked && !chkClave.Checked && !chkCalle.Checked && !chkCP.Checked) {
                MetroMessageBox.Show(this, "Debe seleccionar al menos un campo en donde buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flowLayoutPanel1.Focus();
                return;
            }

            FrmState = enums.frmState.Find;

            Application.DoEvents();

            bsIFE.DataSource = null;

            List<string> searchFields = new List<string>();

            if (chkNombre.Checked) searchFields.Add("nombre");
            if (chkClave.Checked) searchFields.Add("clave");
            if (chkCalle.Checked) searchFields.Add("calle");
            if (chkCP.Checked) searchFields.Add("cp");

            wrkerStruct str = new wrkerStruct()
            {
                idEntidad = ((entidadesModel)bsEntidades.Current).nument,
                searchFields = searchFields,
                cad = txtCad.Text.Trim(),
                exacta = tgExacta.Checked
            };
            
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

            e.Result = IFEController.find(str.idEntidad,
                                          str.searchFields,
                                          str.cad,
                                          str.exacta);
        }

        private void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                List<IFEModel> data = (List<IFEModel>)e.Result;
                ((BackgroundWorker)sender).CancelAsync();

                FrmState = enums.frmState.Normal;

                if (data != null)
                {
                    unFilterList = new List<IFEModel>(data);
                    bsIFE.DataSource = data;
                    lblCantReg.Text = string.Format("[ {0} ] Registros Encontrados", data.Count.ToString());
                }
                else
                    MetroMessageBox.Show(this, "No se encontraron resultados que coincidan con la búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblCantReg.Visible = data.Count > 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            wrker.CancelAsync();
            IFEController.cancelFind();
            FrmState = enums.frmState.Normal;
        }

        private List<IFEModel> unFilterList;
        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string filter = txtFind.Text;

                List<IFEModel> data;
                if (string.IsNullOrEmpty(filter))
                    data = new List<IFEModel>(unFilterList);
                else
                {
                    data = new List<IFEModel>(unFilterList.Where(qry => qry.clave.Contains(filter) ||
                                                                        qry.nombre.Contains(filter) ||
                                                                        qry.fnac.Contains(filter) ||
                                                                        qry.calle.Contains(filter) ||
                                                                        qry.numext.Contains(filter) ||
                                                                        qry.numint.Contains(filter) ||
                                                                        qry.colonia.Contains(filter) ||
                                                                        qry.codpos.Contains(filter) ||
                                                                        qry.nmpio.Contains(filter) ||
                                                                        qry.entidad.Contains(filter)));
                }

                bsIFE.DataSource = data;
            }
            catch (Exception)
            {
            }
        }        
        
    }
}
