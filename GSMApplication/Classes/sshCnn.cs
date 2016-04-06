using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Classes
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
	        catch (Exception)
	        {
		        throw;
	        }
        }

        ~sshCnn(){
            this.SshClient.Disconnect();
        }

        public StringBuilder execute(string command){
            StringBuilder result = new StringBuilder();
            SshCommand output = this.SshClient.RunCommand(command);
            if (!string.IsNullOrEmpty(output.Error))
            {
                throw new Exception(output.Error);
            }
            else {
                result.Append(output.Result);
            }
            return result;
        }
    }
}
