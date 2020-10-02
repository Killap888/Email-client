using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_client
{
    public partial class FormNewMessage : Form
    {
        public FormNewMessage(string fromMessage, string headerMessage, string bodyMessage, int idMessage)
        {
            InitializeComponent();
            textBoxFrom.Text = fromMessage;
           // textBoxTo.Text = toMessage;
            textBoxHeader.Text = headerMessage;
            textBoxBody.Text = bodyMessage;
        }
    }
}
