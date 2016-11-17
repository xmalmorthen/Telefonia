using Satelites.Classes;
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

namespace Satelites.Views
{
    public partial class frmSshCnn : MetroForm
    {
        private List<string> cnns = new List<string>(new string[]{
            "satelites1",
            "satelites2",
            "satelites3"
        });

        private List<BackgroundWorker> bkgndWrkrs = new List<BackgroundWorker>();

        private DialogResult dlgRes = DialogResult.Yes;

        public frmSshCnn()
        {
            InitializeComponent();

            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            this.init();
        }

        private void init() {
            foreach (string item in cnns)
            {
                BackgroundWorker wrker = new BackgroundWorker();
                wrker.WorkerSupportsCancellation = true;
                wrker.DoWork += new DoWorkEventHandler(wrker_DoWork);
                wrker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(wrker_RunWorkerCompleted);
                bkgndWrkrs.Add(wrker);
                wrker.RunWorkerAsync(item);
            }
        }

        void wrker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            try
            {                           
                string cnnName = String.Format("{0}", e.Argument.ToString());
                sshCnn cnn = new sshCnn(Properties.Settings.Default.sshUser, Properties.Settings.Default.sshPass, Properties.Settings.Default.sshHost);
                if (Program.SshCnn == null) Program.SshCnn = new Dictionary<string, sshCnn>();
                Program.SshCnn.Add(cnnName, cnn);
                e.Result = cnnName;
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
                throw;
            }
            
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        byte iter = 0;
        Boolean errorShowed = false;
        void wrker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            iter++;
            if (!e.Cancelled)
            {
                if (e.Error != null)
                {
                    if (errorShowed) return;
                    errorShowed = true;
                    btnCancel_Click(null, null);
                    MessageBox.Show(this, "Error al intentar conectar con los dispositivos !!!", "Error de conección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                    this.Close();
                }
                else
                {
                    lblInfo.Text = String.Format("Iniciando servicio {0} ...", (string)e.Result);
                    pbSshCnn.Value = (iter * 100) / bkgndWrkrs.Count;

                    if (iter >= bkgndWrkrs.Count)
                    {
                        this.DialogResult = this.dlgRes;
                        this.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (BackgroundWorker item in bkgndWrkrs)
                item.CancelAsync();
            foreach (KeyValuePair<string, sshCnn> item in Program.SshCnn)
            {
                if (item.Value.SshClient.IsConnected) 
                    item.Value.SshClient.Disconnect();
            }
            dlgRes = System.Windows.Forms.DialogResult.No;
        }

        private void frmSshCnn_Shown(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

    }
}
