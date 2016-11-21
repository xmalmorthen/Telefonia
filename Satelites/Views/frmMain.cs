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
        public gMapView gMapViewRender;

        private List<GMapMarker> markers {get; set;}

        private enums.frmState _frmState;
        public enums.frmState frmState
        {
            get { return _frmState; }
            set
            {
                _frmState = value;

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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
