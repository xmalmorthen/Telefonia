using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Classes
{
    class scpCnn
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

        private ScpClient scpClient;
        public ScpClient ScpClient
        {
            get { return scpClient; }
            set { scpClient = value; }
        }

        public scpCnn (string user, string pass, string host){
            this.User = user;
            this.Pass = pass;
            this.Host = host;
            this.ScpClient = new ScpClient(this.Host, this.User, this.Pass);
            try 
	        {
                this.ScpClient.Connect();
	        }
	        catch (Exception ex)
	        {
                throw;                
	        }
        }

        ~scpCnn()
        {
            this.ScpClient.Disconnect();
        }

        public Boolean download(string pathFiletoDownload, string pathFiletoSave)
        {
            Boolean result = false;
            try
            {
                string File = pathFiletoDownload; // TODO: Initialize to an appropriate value
                FileInfo fileInfo = new FileInfo(pathFiletoSave);
                this.ScpClient.Download(File, fileInfo);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
       
    }
}


           
