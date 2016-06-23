﻿using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class modemSignalController
    {
        public static int get { get {
            int signal = 0;

            sshCnn ssh;
            Program.SshCnn.TryGetValue("PDU", out ssh);
            try
            {
                //StringBuilder output = ssh.execute("pwd");
                //StringBuilder output = ssh.execute("bash -l -c '/home/geo/senal.sh'");
                StringBuilder output = ssh.script("senal.sh");

                if (output != null)
                    using (StringReader reader = new StringReader(output.ToString()))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                            if (line.Contains("+CSQ:"))
                            { 
                                string[] parts = line.Split(',');
                                
                                int.TryParse(parts[0].Substring(6),out signal);                            
                            }

                    }
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return signal;
        }}
    }
}