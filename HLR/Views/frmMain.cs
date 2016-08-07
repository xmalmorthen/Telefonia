using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using HLR.Views.UserControls;

namespace HLR
{
    public partial class frmMain : MetroForm
    {
        public mapViewer MapViewer = new mapViewer();

        public frmMain()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            MapViewer.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(MapViewer);
        }
    }
}
