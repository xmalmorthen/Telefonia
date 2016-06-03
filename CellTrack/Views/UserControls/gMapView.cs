using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellTrack.Controllers;
using GMap.NET.WindowsForms;
using CellTrack.Classes;

namespace CellTrack.Views.UserControls
{
    public partial class gMapView : UserControl
    {
        public gMapController gMap;

        public gMapView(Double lat, Double lng)
        {
            InitializeComponent();

            this.init();

            gMap = new gMapController(lat,lng,tkBarZoom.Value);
            gMap.MainMap.OnMapZoomChanged += MainMap_OnMapZoomChanged;

            this.Controls.Add(gMap.MainMap);
        }

        void MainMap_OnMapZoomChanged()
        {
            tkBarZoom.Value = (int)gMap.MainMap.Zoom;
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;
        }

        private void tkBarZoom_ValueChanged(object sender, EventArgs e)
        {
            gMap.zoom(tkBarZoom.Value);

            btnLessZoom.Enabled = tkBarZoom.Value > gMap.MainMap.MinZoom;
            btnMoreZoom.Enabled = tkBarZoom.Value < gMap.MainMap.MaxZoom;
        }

        private void btnLessZoom_Click(object sender, EventArgs e)
        {
            tkBarZoom.Value = tkBarZoom.Value - 1;
        }

        private void btnMoreZoom_Click(object sender, EventArgs e)
        {
            tkBarZoom.Value = tkBarZoom.Value + 1;
        }

        private void btnCentrar_Click(object sender, EventArgs e)
        {
            gMap.centerInMarkers();
        }

    }
}
