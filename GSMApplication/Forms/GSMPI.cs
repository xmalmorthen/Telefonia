using GSMApplication.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Forms
{
    public partial class GSMPI : Form
    {
        private string fileName = DateTime.Now.ToString("ddMMyyyy_HHmmss");

        public GSMPI()
        {
            InitializeComponent();
            this.initialize();
        }

        private void initialize() { 
            lblTitle.Text = GSMApplication.Properties.Settings.Default.MCWG_Cnn_lblTitle.Trim();
            lblTitle2.Text = GSMApplication.Properties.Settings.Default.MCWG_Cnn_lblTitle2.Trim();

            txtOutputPath.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, GSMApplication.Properties.Settings.Default.OutputBasePath.Trim(), fileName);

            this.pbInternetConnection.Image = InternetCheckConnection.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbSystemConnected.Image = SystemCheckConnected.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbExternalPower.Image = ExternalCheckPower.Check() ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
        }


        private void btnOnline_Click(object sender, EventArgs e)
        {
            if (Online.init(this) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = DateTime.Now.ToString("ddMMyyyy_HHmmss");
                txtOutputPath.Text = Path.Combine(folderBrowserDialog.SelectedPath, fileName);
            }
        }


    }
}
