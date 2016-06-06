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
using GMap.NET.MapProviders;
using MetroFramework.Controls;

namespace CellTrack.Views.UserControls
{
    public partial class gMapView : UserControl
    {
        public gMapController gMap;

        public gMapView(Double lat, Double lng)
        {
            InitializeComponent();

            gMap = new gMapController(lat, lng, tkBarZoom.Value);
            this.init();            
        }

        void MainMap_OnMapZoomChanged()
        {
            tkBarZoom.Value = (int)gMap.MainMap.Zoom;
        }

        void MainMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnCentrar_Click(null, null);
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            gMap.MainMap.OnMapZoomChanged += MainMap_OnMapZoomChanged;
            gMap.MainMap.MouseDoubleClick += MainMap_MouseDoubleClick;
            gMap.changeMapType(GMapProviders.GoogleMap);
            this.Controls.Add(gMap.MainMap);

            cmbMapsTypes.ValueMember = "Name";
            cmbMapsTypes.DataSource = GMapProviders.List;
            cmbMapsTypes.SelectedItem = gMap.MainMap.MapProvider;
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

        private void cmbMapsTypes_DropDownClosed(object sender, EventArgs e)
        {
            gMap.changeMapType(((MetroComboBox)sender).SelectedItem as GMapProvider);
        }

    }
}
