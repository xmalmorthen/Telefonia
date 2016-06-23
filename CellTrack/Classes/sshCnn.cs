using NLog;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CellTrack.Classes
{
    class sshCnn
    {              
        private string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string pass;
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private string host;
        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        private OwnSshClient sshClient;
        public OwnSshClient SshClient
        {
          get { return sshClient; }
          set { sshClient = value; }
        }

        public sshCnn (string user, string pass, string host){
            this.User = user;
            this.Pass = pass;
            this.Host = host;
            this.SshClient = new OwnSshClient(this.Host, this.User, this.Pass);
            try 
	        {
                this.SshClient.Tag = Program.KeepAliveWrkers.Count + 1;
                this.SshClient.ConnectionInfo.Encoding = Encoding.UTF8;
                this.SshClient.KeepAliveInterval = Properties.Settings.Default.sshTimeOut;
                this.SshClient.ConnectionInfo.Timeout = Properties.Settings.Default.sshTimeOut;
		        this.SshClient.Connect();

                BackgroundWorker wrk = new BackgroundWorker();
                wrk.WorkerSupportsCancellation = true;
                wrk.DoWork += wrk_DoWork;
                wrk.RunWorkerAsync(this.SshClient);
                Program.KeepAliveWrkers.Add((int)this.SshClient.Tag, wrk);
	        }
	        catch (Exception ex)
	        {
                throw;                
	        }
        }

        void wrk_DoWork(object sender, DoWorkEventArgs e)
        {
            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            SshClient sshclient = (SshClient)e.Argument;

            while (true) {
                Thread.Sleep(Properties.Settings.Default.sshSendKeepAliveTime);
                sshclient.SendKeepAlive();
            }

            if (((BackgroundWorker)sender).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        ~sshCnn(){
            BackgroundWorker wrk;
            if (Program.KeepAliveWrkers.TryGetValue((int)this.SshClient.Tag, out wrk))
                wrk.CancelAsync();
            this.SshClient.Disconnect();
        }

        public StringBuilder execute(string command){
            StringBuilder result = new StringBuilder();

            SshCommand output = this.SshClient.RunCommand(String.Format("{0} {1}",Properties.Settings.Default.superUserCommand,command));
            if (!string.IsNullOrEmpty(output.Error))
            {
                throw new Exception(output.Error);
            }
            else {
                result.Append(output.Result);
            }
            return result;
        }

        public StringBuilder script(string command)
        {
            return execute(string.Format("bash -l -c './{0}' 2>&1", command));
        }

        public StringBuilder asyncExecute(string command) {
            StringBuilder result = new StringBuilder();
            SshCommand cmd = this.SshClient.CreateCommand(String.Format("{0} {1}",Properties.Settings.Default.superUserCommand,command));
                
            var asyncResult = cmd.BeginExecute(new AsyncCallback((s) =>
                {
                    
                }), null);
            while (!asyncResult.IsCompleted)
                Thread.Sleep(100);
            cmd.EndExecute(asyncResult);
            return result;
        }
    }
}
