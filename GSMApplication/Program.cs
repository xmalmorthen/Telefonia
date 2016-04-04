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
        public static GSMPIDataContext bdGSMPI = new GSMPIDataContext();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GSMPI InitForm = new Forms.GSMPI();
            if ( InitForm.ShowDialog() == DialogResult.Yes ) Application.Run(new GSMPIMain());
        }
    }
}
