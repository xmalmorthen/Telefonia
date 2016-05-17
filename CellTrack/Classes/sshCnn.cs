using NLog;
using Renci.SshNet;
using System;
using System.Collections.Generic;
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

        private SshClient sshClient;
        public SshClient SshClient
        {
          get { return sshClient; }
          set { sshClient = value; }
        }

        public sshCnn (string user, string pass, string host){
            this.User = user;
            this.Pass = pass;
            this.Host = host;
            this.SshClient = new SshClient(this.Host, this.User, this.Pass);
            try 
	        {
		        this.SshClient.Connect();
	        }
	        catch (Exception ex)
	        {
                throw;                
	        }
        }

        ~sshCnn(){
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
