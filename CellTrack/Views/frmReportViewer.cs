using CellTrack.Classes;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Views
{
    public partial class frmReportViewer : MetroForm
    {
        public frmReportViewer()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
        }

    }
}
