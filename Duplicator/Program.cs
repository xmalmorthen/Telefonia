using Duplicator.Models.DataBase;
using Duplicator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicator
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

            frmLogin FrmLogin = new frmLogin();
            if (FrmLogin.ShowDialog() == DialogResult.Yes)
            {
                caUsers user = FrmLogin.user;
                FrmLogin.Close();
                Application.Run(new frmDuplicator(user));
            }
            else {
                Application.Exit();
            }
        }
    }
}
