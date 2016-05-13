using GSMApplication.Classes;
using GSMApplication.Controllers;
using GSMApplication.Forms;
using GSMApplication.Forms;
using GSMApplication.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication
{
    static class Program
    {

        private static Dictionary<string, sshCnn> sshCnn = new Dictionary<string, sshCnn>();
        public static Dictionary<string, sshCnn> SshCnn
        {
            get { return Program.sshCnn; }
            set { Program.sshCnn = value; }
        }

        private static Dictionary<string, scpCnn> scpCnn = new Dictionary<string, scpCnn>();
        public static Dictionary<string, scpCnn> ScpCnn
        {
            get { return Program.scpCnn; }
            set { Program.scpCnn = value; }
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmSshCnn initSshCnn = new Forms.FrmSshCnn();
            if (initSshCnn.ShowDialog() == DialogResult.Yes)
            {
                GSMPI InitForm = new Forms.GSMPI();
                switch (InitForm.ShowDialog())
                {
                    case DialogResult.Yes:
                        Application.Run(new GSMPIMain());
                        break;
                    case DialogResult.OK:
                        Application.Run(new GSMPIOffline());
                        break;
                }
            }
            try
            {
                foreach (KeyValuePair<string, sshCnn> item in SshCnn)
                    item.Value.SshClient.Disconnect();
            }
            catch (Exception) { }
        }
    }
}
