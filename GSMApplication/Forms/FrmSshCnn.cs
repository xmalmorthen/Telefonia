using GSMApplication.Classes;
using GSMApplication.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Forms
{
    public partial class FrmSshCnn : Form
    {
        private const int SSHCNN = 10;
        private Boolean frmTerminate = false;
        private Boolean shownError = false;
        private DialogResult dlgRes = DialogResult.Yes;
        private int proccess = 0;

        public FrmSshCnn()
        {
            InitializeComponent();

            bWSystemConnected.RunWorkerAsync();
            bWExternalPower.RunWorkerAsync();
            bWReceivers.RunWorkerAsync();
            bWDecipher.RunWorkerAsync();
            bWInitialzingSystem.RunWorkerAsync();
            bWConnectionToControllers.RunWorkerAsync();
            bWScanningForReceivers.RunWorkerAsync();
            bWPoweringOnReceivers.RunWorkerAsync();
            bWConnectingToReceivers.RunWorkerAsync();
            bWInitializingStack.RunWorkerAsync();
  

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {     
            bWSystemConnected.CancelAsync();
            bWExternalPower.CancelAsync();
            bWReceivers.CancelAsync();
            bWDecipher.CancelAsync();
            bWInitialzingSystem.CancelAsync();
            bWConnectionToControllers.CancelAsync();
            bWScanningForReceivers.CancelAsync();
            bWPoweringOnReceivers.CancelAsync();
            bWConnectingToReceivers.CancelAsync();
            bWInitializingStack.CancelAsync();

            dlgRes = System.Windows.Forms.DialogResult.No;
        }

        private void bWSystemConnected_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("SystemConnected", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "System";
        }

        private void bWExternalPower_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("ExternalPower", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "External Power";
        }

        private void bWReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("Receivers", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "Receivers";
        }

        private void bWDecipher_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("Decipher", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "Decipher";
        }


        private void bWInitialzingSystem_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("initialzingSystem", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "Initialzing System";
        }

        private void bWConnectionToControllers_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("connectionToControllers", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "ConnectionTo Controllers";
        }

        private void bWScanningForReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("scanningForReceivers", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "Scanning For Receivers";
        }

        private void bWPoweringOnReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("poweringOnReceivers", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "Powering On Receivers";
        }

        private void bWConnectingToReceivers_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("connectingToReceivers", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "Connecting To Receivers";
        }

        private void bWInitializingStack_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.SshCnn.Add("initializingStack", new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost));
            e.Result = "Initializing Stack";
        }

        private void bWSystemConnected_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            proccess++;

            if (e.Error != null)
            {
                if (!shownError)
                {
                    shownError = true;
                    MessageBox.Show(this, "System error connection !!!", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnCancel_Click(null, null);
                    this.Close();
                }
            }
            else
            {

                lblInfo.Text = String.Format("Conected to {0} service ...", (string)e.Result);
                pbSshCnn.Value = (proccess * 100) / SSHCNN;

                if (proccess >= SSHCNN)
                {
                    this.DialogResult = this.dlgRes;
                    this.Close();
                }
            }
        }

    }
}
