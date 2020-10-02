using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Email_client
{
    public class ImapServerData
    {
        // imap
        public string Server { get; set; }
        public int Port { get; set; }
        public bool SSL { get; set; }
    }
}
