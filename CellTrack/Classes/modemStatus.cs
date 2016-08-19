using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Classes
{
    public static class modemStatus
    {
        private static Boolean free;
        public static Boolean Free
        {
            get { return modemStatus.free; }
        }

        private static sshCnn ssh;
        private void changeStatus() {
            if (Program.SshCnn.TryGetValue("modemSignal", out ssh))
            try
            {
                string cmnd = string.Format("cat {0}", Properties.Settings.Default.modemStatusFileName.Trim());
                StringBuilder response = ssh.script(cmnd);

                

            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
        }

        public static void Occupied() {
            free = false;
        }

        public static void Vacant()
        {
            free = true;
        }

    }
}
