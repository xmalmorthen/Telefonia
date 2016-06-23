using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Classes
{
    class OwnSshClient : SshClient
    {
        public OwnSshClient(ConnectionInfo connectionInfo) : base(connectionInfo) { }
        public OwnSshClient(string host, string username, params PrivateKeyFile[] keyFiles) : base(host, username, keyFiles) { }
        public OwnSshClient(string host, string username, string password) : base(host, username, password) { }
        public OwnSshClient(string host, int port, string username, params PrivateKeyFile[] keyFiles) : base(host, port, username, keyFiles) { }
        public OwnSshClient(string host, int port, string username, string password) : base(host, port, username, password) { }
        public object Tag { get; set; }
    }
}
