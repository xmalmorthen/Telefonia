using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Controllers
{
    static class Command
    {
        public static string Execute(string command, string parameters) {
            string result = null;
            try
            {
                ProcessStartInfo cmnd = new ProcessStartInfo(command, parameters);
                cmnd.UseShellExecute = false;
                cmnd.CreateNoWindow = true;
                cmnd.WindowStyle = ProcessWindowStyle.Hidden;
                cmnd.RedirectStandardOutput = true;
                using (Process process = Process.Start(cmnd))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception)
            {
                /*
                 * TODO: IMPLEMENTAR NLOG
                 */
                throw;
            }
            return result;
        }

    }
}
