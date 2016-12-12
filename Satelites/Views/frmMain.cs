using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MetroFramework.Forms;
using Satelites.Classes;
using Satelites.Controllers;
using Satelites.Models.CustomMarkers;
using Satelites.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelites.Views
{
    public partial class frmMain : MetroForm
    {
        public DialogResult dlgRes = DialogResult.No;
        public gMapViewLite gMapViewRender;

        private List<GMapMarker> markers {get; set;}

        private enums.frmState _frmState;
        public enums.frmState frmState
        {
            get { return _frmState; }
            set
            {
                _frmState = value;
                this.pnlProc.Visible = value == enums.frmState.Proccessing;
            }
        }

        public frmMain(List<GMapMarker> markers)
        {
            InitializeComponent();

            this.markers = markers;

            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            frmState = enums.frmState.Normal;

            gMapViewRender = new gMapViewLite(markers);
            Application.DoEvents();
            gMapViewRender.Parent = this;
            gMapViewRender.Dock = System.Windows.Forms.DockStyle.Fill;
            gMapViewRender.Location = new System.Drawing.Point(0, 0);
            gMapViewRender.MinimumSize = new Size(0, 0);
            gMapViewRender.Margin = new Padding(3);
            gMapViewRender.TabIndex = 0;            
            pnlMap.Controls.Clear();
            pnlMap.Controls.Add(gMapViewRender);

            gdCells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gdReceivers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            populate();
        }

        private void populate()
        {
            cellsModelBindingSource.DataSource = Populate.Cells(markers.Count());

            Random rnd = new Random();
            foreach (GMapMarker mrkr in markers)
                foreach (PointLatLng item in Populate.MapMarkerModel(mrkr.Position,rnd.Next(100,200)))
                    gMapViewRender.AddTarjet(item);
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMain_Resize(object sender, EventArgs e)
        {
            gdCells.Width = pnlMain.Size.Width / 2;
            gdReceivers.Size = new Size(pnlMain.Size.Width / 2 - 10, pnlMain.Size.Height / 2 - 5);
            gdReceivers.Location = new Point(gdCells.Width + 5, 3);
            pnlMap.Size = new Size(pnlMain.Size.Width / 2 - 10, pnlMain.Size.Height / 2 - 5);
            pnlMap.Location = new Point(gdCells.Width + 5, gdReceivers.Height + 5);
        }

        
    }
}
