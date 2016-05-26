using CellTrack.Classes;
using CellTrack.Controllers;
using CellTrack.Models.DataBases;
using CellTrack.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack
{
    static class Program
    {
        public static causuarios user = null;   //Variable global que contiene información del ususario logueado

        #region SSHREFERENCES

        private static Dictionary<string, sshCnn> sshCnn = new Dictionary<string, sshCnn>();
        public static Dictionary<string, sshCnn> SshCnn
        {
            get { return sshCnn; }
            set { sshCnn = value; }
        }

        

        private static void closeAllConnections() {
            foreach (KeyValuePair<string, sshCnn> item in Program.SshCnn)
            {
                if (item.Value.SshClient.IsConnected)
                    item.Value.SshClient.Disconnect();
            }
        }

        #endregion SSHREFERENCES

        public static frmDashboard FrmDashboard = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                DAL.Db = new dbgeolocEntities();
                Properties.Settings.Default.mainStyle = new MetroFramework.Components.MetroStyleManager();
                Properties.Settings.Default.mainStyle.Style = MetroFramework.MetroColorStyle.Black;
                Properties.Settings.Default.mainStyle.Theme = MetroFramework.MetroThemeStyle.Light;

                /*frmSshCnn FrmSshCnn = new frmSshCnn();
                if (FrmSshCnn.ShowDialog() == DialogResult.Yes) {
                    frmLogIn FrmLogIn = new frmLogIn();
                    Application.Run(FrmLogIn);
                    if (FrmLogIn.dlgRes == DialogResult.No) Application.Exit();
                }*/

                FrmDashboard = new frmDashboard();

                Application.Run(FrmDashboard);
                Program.closeAllConnections();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas al intentar conectar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();            
        }
    }
}
