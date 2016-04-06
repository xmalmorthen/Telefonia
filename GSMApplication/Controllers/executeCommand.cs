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
        public static StringBuilder Execute(string command, string parameters)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                ProcessStartInfo cmnd = new ProcessStartInfo(command, parameters);
                cmnd.UseShellExecute = false;
                cmnd.CreateNoWindow = true;
                cmnd.WindowStyle = ProcessWindowStyle.Hidden;
                cmnd.RedirectStandardOutput = true;

                Process process = new Process();
                process.StartInfo = cmnd;
                process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    // Prepend line numbers to each line of the output.
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        result.Append(e.Data);
                    }
                });

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();
                process.Close();
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
