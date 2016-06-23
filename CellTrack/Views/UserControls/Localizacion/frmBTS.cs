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
    public partial class frmBTS : UserControl
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

        public frmBTS()
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

            gMapViewRender.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(gMapViewRender);
        }

        private List<btsModel> targets = null;
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string message = string.Empty;

                if (! btsController.getApiGeoReference(
                                                        gMapViewRender.gMap,
                                                        double.Parse(txtCELLID.Text.Trim()),
                                                        double.Parse(txtLAC.Text.Trim()),
                                                        double.Parse(txtMCC.Text.Trim()),
                                                        double.Parse(txtMNC.Text.Trim()),
                                                        out message
                                                        ) 
                    )
                    MetroMessageBox.Show(this, message, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCELLID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClearTargets_Click(object sender, EventArgs e)
        {
            gMapViewRender.gMap.MarkersOverlays.Clear();
            gMapViewRender.gMap.TriangulationsOverlays.Clear();
            gMapViewRender.gMap.MainMap.Overlays.Clear();
        }
        
    }
}
