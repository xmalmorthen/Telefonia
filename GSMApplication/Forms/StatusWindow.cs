using GSMApplication.Controllers;
using GSMApplication.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Forms
{
    public partial class StatusWindow : Form
    {
        private DialogResult dlgRes = DialogResult.OK;

        public StatusWindow()
        {
            InitializeComponent();
        }

        private void StatusWindow_Paint(object sender, PaintEventArgs e)
        {
            Application.DoEvents();
            this.Init();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e) { 
            
        
        }

        private List<Thread> threads = new List<Thread>();
        private List<BackgroundWorker> workers = new List<BackgroundWorker>();

        private void Init()
        {
            var stopWatch = Stopwatch.StartNew();
            
            threads.Add(new Thread(new ThreadStart(initialzingSystem)));
            threads.Add (new Thread(new ThreadStart(connectionToControllers)));
            threads.Add (new Thread(new ThreadStart(scanningForReceivers)));
            threads.Add (new Thread(new ThreadStart(poweringOnReceivers)));
            threads.Add (new Thread(new ThreadStart(connectingToReceivers)));
            threads.Add (new Thread(new ThreadStart(initializingStack)));

            for (int i = 0; i < 6; i++)
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                worker.
            }




            foreach (Thread item in threads)
	        {
                item.Start();                
	        }

            foreach (Thread item in threads)
            {
                item.Join();
            }

            //stopWatch.Elapsed.ToString();
            this.lblReady.Visible = true;

            Random rnd = new Random();
            System.Threading.Thread.Sleep(rnd.Next(5) * 3000);

            this.DialogResult = this.dlgRes;            

            this.Close();
        }

        private void initialzingSystem()
        {
            Random rnd = new Random();
            System.Threading.Thread.Sleep(rnd.Next(5)*1000);

            Boolean status = true;

            GSMPIDataContext bdGSMPI = new GSMPIDataContext();
            reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "ping");
            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
            string response = Command.Execute(qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim());

            /*
             * TODO : IMPLEMENTAR TRATAMIENTO DEL COMANDO
             */

            this.pbInitializingStack.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            dlgRes = status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
        }

        private void initializingStack()
        {
            Random rnd = new Random();
            System.Threading.Thread.Sleep(rnd.Next(5) * 1000);

            Boolean status = true;

            GSMPIDataContext bdGSMPI = new GSMPIDataContext();
            reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "ping");
            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
            string response = Command.Execute(qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim());

            /*
             * TODO : IMPLEMENTAR TRATAMIENTO DEL COMANDO
             */

            dlgRes = System.Windows.Forms.DialogResult.No;
            this.pbInitialzingSystem.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;

            dlgRes = status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
        }

        private void connectingToReceivers()
        {
            Random rnd = new Random();
            System.Threading.Thread.Sleep(rnd.Next(5) * 1000);

            Boolean status = true;

            GSMPIDataContext bdGSMPI = new GSMPIDataContext();
            reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "ping");
            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
            string response = Command.Execute(qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim());

            /*
             * TODO : IMPLEMENTAR TRATAMIENTO DEL COMANDO
             */

            this.pbConnectingToReceivers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;

            dlgRes = status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
        }

        private void poweringOnReceivers()
        {
            Random rnd = new Random();
            System.Threading.Thread.Sleep(rnd.Next(5) * 1000);

            Boolean status = true;

            GSMPIDataContext bdGSMPI = new GSMPIDataContext();
            reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "ping");
            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
            string response = Command.Execute(qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim());

            /*
             * TODO : IMPLEMENTAR TRATAMIENTO DEL COMANDO
             */

            this.pbPoweringOnReceivers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;

            dlgRes = status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;            
        }

        private void scanningForReceivers()
        {
            Random rnd = new Random();
            System.Threading.Thread.Sleep(rnd.Next(5) * 1000);

            Boolean status = true;

            GSMPIDataContext bdGSMPI = new GSMPIDataContext();
            reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "ping");
            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
            string response = Command.Execute(qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim());

            /*
             * TODO : IMPLEMENTAR TRATAMIENTO DEL COMANDO
             */

            this.pbScanningForReceivers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;

            dlgRes = status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
        }

        private void connectionToControllers()
        {
            Random rnd = new Random();
            System.Threading.Thread.Sleep(rnd.Next(5) * 1000);

            Boolean status = true;

            GSMPIDataContext bdGSMPI = new GSMPIDataContext();
            reCommandsParameters qry = bdGSMPI.reCommandsParameters.SingleOrDefault(qq => qq.tag == "ping");
            if (qry == null) throw new Exception("Error al obtener los comandos de la bd");
            string response = Command.Execute(qry.caCommands.command.Trim(), qry.caParameters.parameter.Trim());

            /*
             * TODO : IMPLEMENTAR TRATAMIENTO DEL COMANDO
             */

            this.pbConnectionToControllers.Image = status ? global::GSMApplication.Properties.Resources._1459305043_11 : global::GSMApplication.Properties.Resources._1459304445_101_Warning;

            dlgRes = status == true ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
        }

        private void StatusWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            dlgRes = System.Windows.Forms.DialogResult.No;
            foreach (Thread item in threads)
                if (item.ThreadState != System.Threading.ThreadState.Aborted || item.ThreadState != System.Threading.ThreadState.AbortRequested)
                    item.Abort();
        }


        
    }
}
