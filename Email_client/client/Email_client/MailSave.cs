using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Email_client
{
    [Serializable]
    public class MailSave
    {
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }


        public MailSave(string from, string subject, string body)
        {
            From = from;
            Subject = subject;
            Body = body;
        }
    }
}
