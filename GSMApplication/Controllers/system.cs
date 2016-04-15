using GSMApplication.Classes;
using GSMApplication.Models;
using GSMApplication.Models.DataBase;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GSMApplication.Controllers
{
    public static class system
    {
        public static class check
        {            

            public static class InternetConnection
            {
                public static Boolean Check()
                {
                    try
                    {                        
                        System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                        return false;
                    }
                    return true;
                }
            }

            public static class SystemConnected
            {
                public static Boolean Check(out string message)
                {
                    Boolean result = false;
                    message = string.Empty;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("SystemConnected", out ssh);
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");

                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty));

                        result = output.ToString().Trim().Length > 0;                        
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }
            }

            public static class ExternalPower
            {
                public static Boolean Check()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("ExternalPower", out ssh);
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "ExternalPower");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");

                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty ));

                        result = output.ToString().ToLower().Contains("on-line");
                        if (!result) { 
                            output.Clear();
                            qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "BatteryInformation");
                            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                            output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty ));
                        }
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }
            }

            public static class Receivers
            {
                public static Boolean Check()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("Receivers", out ssh);
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "Ping");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }
            }

            public static class Decipher
            {
                public static Boolean Check()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("Decipher", out ssh);
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "Ping");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }

                public static Boolean State()
                {
                    Boolean result = false;
                    sshCnn ssh = new sshCnn(GSMApplication.Properties.Settings.Default.sshUser, GSMApplication.Properties.Settings.Default.sshPass, GSMApplication.Properties.Settings.Default.sshHost);
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "Ping");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }
            }
        }

        public static class initializing {
            public static Boolean initialzingSystem()
            {
                Boolean result = false;
                sshCnn ssh;
                Program.SshCnn.TryGetValue("initialzingSystem", out ssh);
                try
                {
                    //Verificar el espacio disponible en disco

                    GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                    reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemVolumeInformation");
                    if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                    StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty));

                    using (StringReader reader = new StringReader(output.ToString()))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("total"))
                            {
                                string[] parts = line.Split(' ');
                                string used = parts[parts.Length - 2].Substring(0,parts[parts.Length - 2].Length-1);
                                int volumeUsed = 0;
                                int.TryParse(used,out volumeUsed);
                                string MaxSysVol = bdGSMPI.taParameters.SingleOrDefault(qq => qq.tag == "MaxSystemVolumeUsed").value;
                                if (string.IsNullOrEmpty(MaxSysVol)) throw new Exception("Error al obtener los comandos de la bd");
                                if (volumeUsed >= 95) {
                                    throw new Exception(String.Format("Espacio insuficiente en disco [ Size: {0}, Used: {1}, Avail: {2}, Use: {3}", parts[1], parts[2], parts[3], parts[4]));
                                }
                            }
                        }
                    }
                    result = true;
                }
                catch (Exception ex)
                {
                    exceptionHandlerCatch.registerLogException(ex);
                }
                return result;
            }            

            public static class Receivers
            {
                public static Boolean scanningForReceivers()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("scanningForReceivers", out ssh); 
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "uhdFindDevices");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty));
                        
                        using (StringReader reader = new StringReader(output.ToString()))
                        {
                            string line;

                            Receiver reciver = new Receiver();
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line.Contains("Device Address"))
                                {
                                    line = reader.ReadLine();
                                    if (line.Contains("type"))
                                    {
                                        string[] parts = line.Split(':');
                                        reciver.Type = parts[parts.Length - 1].Trim();
                                    }
                                    line = reader.ReadLine();
                                    if (line.Contains("name"))
                                    {
                                        string[] parts = line.Split(':');
                                        reciver.Name = parts[parts.Length - 1].Trim();
                                    }
                                    line = reader.ReadLine();
                                    if (line.Contains("serial"))
                                    {
                                        string[] parts = line.Split(':');
                                        reciver.Serial = parts[parts.Length - 1].Trim();
                                    }
                                    Recivers.List.Add(reciver);
                                }                                
                            }                            
                        }

                        result = Recivers.List.Count > 0;
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }

                public static Boolean connectionToControllers()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("poweringOnReceivers", out ssh);
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();

                        taParameters MHZ = bdGSMPI.taParameters.SingleOrDefault(_MHZ => _MHZ.tag.Equals("MHZ"));
                        if (MHZ == null) throw new Exception("Error al obtener los comandos de la bd");

                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "uhdUsrpProbe");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");

                        foreach (Receiver item in Recivers.List)
                        {
                            StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim().Replace("{0}", item.Serial) : String.Empty));

                            if (!output.ToString().Contains("No devices found for"))
                            {
                                throw new Exception(String.Format("Serial no encontrado [ Type: {0}, Name: {1}, Serial: {2}", item.Type, item.Name, item.Serial));
                            }

                            using (StringReader reader = new StringReader(output.ToString()))
                            {
                                string line;

                                Receiver reciver = new Receiver();
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (line.Contains("Using FPGA clock rate of"))
                                    {
                                        string[] parts = line.Split(' ');
                                        string clockRte = parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 6);
                                        Double clockRate = Double.Parse(clockRte);

                                        if (!clockRate.Equals(Double.Parse(MHZ.value)))
                                        {
                                            throw new Exception(String.Format("Velocidad de reloj erronea [ Type: {0}, Name: {1}, Serial: {2}", item.Type, item.Name, item.Serial));
                                        }
                                    }
                                }
                            }
                        }
                        result = true;
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }

                public static Boolean poweringOnReceivers()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("connectionToControllers", out ssh);
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }

                public static Boolean connectingToReceivers()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("connectingToReceivers", out ssh); 
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        exceptionHandlerCatch.registerLogException(ex);
                    }
                    return result;
                }
            }            
        }    
    }
}
