using GSMApplication.Classes;
using GSMApplication.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    catch
                    {
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
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty ));

                        //acpi -b {Battery 0: Full, 100%}
                        //acpi -a {Adapter 0: on-line}

                        result = output.ToString().ToLower().Contains("on-line");
                        if (!result) { 
                            output.Clear();
                            qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "BatteryInformation");
                            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                            output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters != null ? qry.caParameters.parameter.Trim() : String.Empty ));
                            message = output.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
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
                        StringBuilder output = ssh.execute("ls");
                        result = output.ToString().Contains("tmp");
                    }
                    catch (Exception)
                    {
                        throw;
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
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception)
                    {
                        throw;
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
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception)
                    {
                        throw;
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
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception)
                    {
                        throw;
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
                    GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                    reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                    if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                    StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                    result = !output.ToString().Contains("Unreachable");
                }
                catch (Exception)
                {
                    throw;
                }
                return result;
            }

            public static Boolean connectionToControllers()
            {
                Boolean result = false;
                sshCnn ssh;
                Program.SshCnn.TryGetValue("connectionToControllers", out ssh);                
                try
                {
                    GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                    reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                    if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                    StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                    result = !output.ToString().Contains("Unreachable");
                }
                catch (Exception)
                {
                    throw;
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
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return result;
                }

                public static Boolean poweringOnReceivers()
                {
                    Boolean result = false;
                    sshCnn ssh;
                    Program.SshCnn.TryGetValue("poweringOnReceivers", out ssh); 
                    try
                    {
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception)
                    {
                        throw;
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
                        GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                        reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                        if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                        StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                        result = !output.ToString().Contains("Unreachable");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return result;
                }
            }
            public static Boolean initializingStack()
            {
                Boolean result = false;
                sshCnn ssh;
                Program.SshCnn.TryGetValue("initializingStack", out ssh); 
                try
                {
                    GSMPIDataContext bdGSMPI = new GSMPIDataContext();
                    reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "SystemConnected");
                    if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
                    StringBuilder output = ssh.execute(String.Format("{0} {1}", qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim()));

                    result = !output.ToString().Contains("Unreachable");
                }
                catch (Exception)
                {
                    throw;
                }
                return result;                
            }
        }    
    }
}
