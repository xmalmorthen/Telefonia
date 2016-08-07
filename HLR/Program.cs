using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLR
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                Application.Run(new frmMain());
            }
            catch
            {
                MessageBox.Show("Debe estar conectado a internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
