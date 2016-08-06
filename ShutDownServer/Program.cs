using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownServer
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
                Application.Run(new FrmMain());
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas al conectar al servidor", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            terminateProgramm();   
        }

        private static void terminateProgramm()
        {
            Application.Exit();

            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
    }
}
