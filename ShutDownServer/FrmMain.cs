using MetroFramework.Forms;
using ShutDownServer.Classes;
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

namespace ShutDownServer
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();            
        }

        private void FrmMain_Shown(object sender, EventArgs _e)
        {
            BackgroundWorker bkgnd = new BackgroundWorker();
            bkgnd.DoWork += (s, e) =>
            {
                Application.DoEvents();
                sshCnn cn = new sshCnn(Properties.Settings.Default.sshUser, Properties.Settings.Default.sshPass, Properties.Settings.Default.sshHost);
                cn.script("/home/geo/apagar.sh");
            };

            bkgnd.RunWorkerCompleted += (s, e) =>
            {
                if (e.Error != null) throw new Exception("Error en thread",e.Error);
            };

            bkgnd.RunWorkerAsync();

            tm.Interval = 15000;
            tm.Enabled = true;
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Enabled = false;
            tm.Stop();
            this.Close();
        }
    }
}
