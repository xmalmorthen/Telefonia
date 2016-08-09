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
using CellTrack.Views.UserControls.Localización;

namespace CellTrack.Views.UserControls
{
    public partial class frmSOKAN : UserControl
    {
        enums.frmState frmState;
        public enums.frmState FrmState
        {
            get { return frmState; }
            set
            {
                frmState = value;
            }
        }

        public frmSOKAN()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            FrmState = enums.frmState.Normal;

            wb.Navigate(Properties.Settings.Default.SOKANUrl);
        }

        private void wb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lblMsgCarga.Visible = true;
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            lblMsgCarga.Visible = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            wb.GoBack();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            wb.GoForward();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            wb.Refresh(WebBrowserRefreshOption.Normal);
        }

    }
}
