using GMap.NET.WindowsForms;
using MetroFramework.Forms;
using Satelites.Classes;
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMain_Resize(object sender, EventArgs e)
        {
            metroGrid2.Width = pnlMain.Size.Width / 2;
            metroGrid1.Size = new Size(pnlMain.Size.Width / 2 - 5, pnlMain.Size.Height / 2 - 5);
            metroGrid1.Location = new Point(metroGrid2.Width + 5, 3);
            pnlMap.Size = new Size(pnlMain.Size.Width / 2 - 5, pnlMain.Size.Height / 2 - 5);
            pnlMap.Location = new Point(metroGrid2.Width + 5, metroGrid1.Height + 5);
        }

        
    }
}
