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
            entidades.AddRange(entidadesController.getEntidades);
            bsEntidades.DataSource = entidades;
        }

        private void tgExacta_CheckedChanged(object sender, EventArgs e)
        {
            lblExacta.Text = ((MetroToggle)sender).Checked ? "SI" : "NO";
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

            List<string> searchFields = new List<string>();

            if (chkNombre.Checked) searchFields.Add("nombre");
            if (chkClave.Checked) searchFields.Add("clave");
            if (chkCalle.Checked) searchFields.Add("calle");
            if (chkCP.Checked) searchFields.Add("cp");

            bsIFE.DataSource = IFEController.find(((entidadesModel)bsEntidades.Current).nument,
                                                    searchFields,
                                                    txtCad.Text.Trim(),
                                                    tgExacta.Checked);
        }        
        
    }
}
