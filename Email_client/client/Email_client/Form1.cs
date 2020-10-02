using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Net.Mail;
using Joshi.Utils.Imap;
using System.IO;
using ImapX;
using ImapX.Enums;
using ImapX.Authentication;
using ImapX.EncodingHelpers;
using ImapX.Parsing;
using ImapX.Collections;
using ImapX.Authentication;
using System.Net.Mail;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;


namespace Email_client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        public bool succesAutorization = false;
        public string userLogin = " ";
        public string userPassword = " ";
        ImapServerData ImapServerData = new ImapServerData();
        SmtpServerData SmtpServerData = new SmtpServerData();

        private void MainForm_Load(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo(@"Saves"); // папка с файлами 

            foreach (FileInfo file in dir.GetFiles())
            {
                comboBoxAccounts.Items.Add(file.Name);
            }
            //comboBoxAccounts.SelectedIndex = 0;
        }

        public void clientDataServer(string hostServer, int portServer, bool sSlServer)
        {
            ImapServerData.Server = hostServer;
            ImapServerData.Port = portServer;
            ImapServerData.SSL = sSlServer;
        }

        public void smtpClientDataServer(string smtpServer, int smtpPort, bool sSlSmtp)
        {
            SmtpServerData.Server = smtpServer;
            SmtpServerData.Port = smtpPort;
            SmtpServerData.SSL = sSlSmtp;
        }

        public void autorization(string login, string pass)//авторизация
        {
            login = comboBoxAccounts.Text;
            //login = textBoxLogin.Text.ToString();
            pass = maskedTextBoxPass.Text.ToString();
            var client = new ImapClient(ImapServerData.Server, ImapServerData.Port, ImapServerData.SSL);
            if (client.Connect())
            {

                if (client.Login(login, pass))
                {
                    succesAutorization = true;
                    labelAutorization.Text = "Авторизация прошла успешно";
                    userLogin = login;
                    userPassword = pass;
                }
                else
                {
                    succesAutorization = false;
                    MessageBox.Show("Проверьте правильность введенных данных");
                }
            }
            else
            {
                // connection not successful
                MessageBox.Show("Подключение не удалось, проверьте ваше интернет-соединение!");
            }
        }        

        private void buttonLoadMessage_Click(object sender, EventArgs e)//загрузка списка сообщений
        {
            var client = new ImapClient(ImapServerData.Server, ImapServerData.Port, ImapServerData.SSL);
            listBoxMessage.Items.Clear();

            if (client.Connect())
            {
                if (client.Login(userLogin, userPassword))
                {         
                    foreach (ImapX.Message m in client.Folders["INBOX"].Search("All", MessageFetchMode.Full))
                    {
                        listBoxMessage.Items.Add(string.Format("{0}({1})||| {2}", m.From.Address, m.From.DisplayName, m.Subject));
                    }                    
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных");
                }
            }
            else
            {
                MessageBox.Show("Подключение не удалось, проверьте ваше интернет-соединение!");
            }
        }

        private void listBoxMessage_SelectedIndexChanged(object sender, EventArgs e)//загрузка в текстовое поле тело выбранного письма
        {
            var client = new ImapClient(ImapServerData.Server, ImapServerData.Port, ImapServerData.SSL);
            int selIndex = listBoxMessage.SelectedIndex;


            if (client.Connect())
            {
                if (client.Login(userLogin, userPassword))
                {
                    ImapX.Message mess;
                    var msg = client.Folders.Inbox.Search("ALL", MessageFetchMode.Full);
                    mess = msg[selIndex];
                    SaveManager.Saves.Messages.Add(new MailSave(mess.From.Address, mess.Subject, mess.Body.Text));
                    SaveManager.Save();
                    textBoxSeeBoby.Text = Encoding.Default.GetString(Encoding.Convert(Encoding.Default, Encoding.Default, Encoding.Default.GetBytes(mess.Body.Text)));

                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных");
                }
            }
            else
            {
                MessageBox.Show("Подключение не удалось, проверьте ваше интернет-соединение!");
            }
        }

        private void listBoxFolders_SelectedIndexChanged(object sender, EventArgs e)/////////////////////0000
        {
            var client = new ImapClient(ImapServerData.Server, ImapServerData.Port, ImapServerData.SSL);
            if (client.Connect())
            {
                if (client.Login(userLogin, userPassword))
                {
                    listBoxMessage.Items.Clear();

                    foreach (ImapX.Message m in client.Folders[listBoxFolders.SelectedIndex].Search("All", MessageFetchMode.Full))
                    {
                        listBoxMessage.Items.Add(string.Format("<- {0}  |||  {1}", m.From.DisplayName, m.Subject));
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных");
                }
            }
            else
            {
                MessageBox.Show("Подключение не удалось, проверьте ваше интернет-соединение!");
            }        
        }

        private void buttonSaveMessage_Click(object sender, EventArgs e)//сохранение почты на локальный диск
        {
            var client = new ImapClient(ImapServerData.Server, ImapServerData.Port, ImapServerData.SSL);

            if (client.Connect())
            {
                if (client.Login(userLogin, userPassword))
                {
                    client.Behavior.MessageFetchMode = MessageFetchMode.Full;

                    foreach (ImapX.Message m in client.Folders.Inbox.Search("ALL", MessageFetchMode.Full))
                    {
                        SaveManager.Saves.Messages.Add(new MailSave(m.From.DisplayName, m.Subject, m.Body.Text));                        
                        SaveManager.Save();
                    }
                }
                
            }
        }
        
        private void buttonEnter_Click(object sender, EventArgs e)//логинимся
        {
            autorization(comboBoxAccounts.Text, maskedTextBoxPass.Text.ToString());
            //autorization(textBoxLogin.Text.ToString(),maskedTextBoxPass.Text.ToString());
            if(checkBoxSaveUserData.Checked == true)
            {
                SaveManager.CreateNew(comboBoxAccounts.Text, maskedTextBoxPass.Text);
                if (succesAutorization == true)
                {
                    comboBoxAccounts.Items.Add(comboBoxAccounts.Text);
                }
            }
           
        }        
        
        private void comboBoxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxServer.SelectedIndex)
            {
                case 0://google
                    clientDataServer("imap.gmail.com", 993, true);
                    smtpClientDataServer("smtp.gmail.com", 587, true);
                    break;
                    
                case 1://yandex
                    clientDataServer("imap.yandex.ru", 993, true);
                    smtpClientDataServer("smtp.yandex.com", 587, true);
                    break;
                case 2://mail
                    clientDataServer("imap.mail.ru", 993, true);
                    smtpClientDataServer("smtp.mail.com", 587, true);
                    break;
                default:
                    MessageBox.Show("Выберите сервер");
                    break;

            }
        }

        private void buttonLoadMessages_Click(object sender, EventArgs e)//загрузка сообщений с локального диска
        {
            listBoxMessage.Items.Clear();
            textBoxSeeBoby.Clear();

            for (int j = 0; j < SaveManager.Saves.Messages.Count; j++)
            {
                SaveManager.Saves.Login = userLogin;
                SaveManager.Load();
                listBoxMessage.Items.Add(string.Format("<- {0}  |||  {1}", SaveManager.Saves.Messages[j].From, SaveManager.Saves.Messages[j].Subject));
                textBoxSeeBoby.Text = SaveManager.Saves.Messages[j].Body;
            }          
        }
              
        private void buttonSendMessage_Click(object sender, EventArgs e) //событие отправки сообщения
        {
            var imapClient = new ImapClient(ImapServerData.Server, true);

            if (imapClient.Connect())
            {

                if (imapClient.Login(userLogin, userPassword))
                {

                    // Sending a message
                    var newMsg = SendMail(
                         SmtpServerData.Server,
                         userLogin,
                         userPassword,
                         userLogin,
                         textBoxToFriend.Text.ToString(),
                         textBoxSubject.Text.ToString(),
                         textBoxBody.Text.ToString()
                     );

                    // Uploading the sent message to the Sent folder
                    imapClient.Folders.Sent.AppendMessage(newMsg);
                    labelSendMessage.Text = "Сообщение успешно отправлено!";

                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных");
                }
            }
            else
            {
                MessageBox.Show("Подключение не удалось, проверьте ваше интернет-соединение!");
            }
        }

        public MailMessage SendMail(string server, string login, string password, string from, string to, string subject, string text) //отправка сообщения
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress(from);
                mail.To.Add(new System.Net.Mail.MailAddress(to));
                mail.Subject = subject;
                mail.Body = text;

                SmtpClient client = new SmtpClient();
                client.Host = SmtpServerData.Server;
                client.Port = SmtpServerData.Port;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(login, password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);

                return mail;
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)//выбор сохраненого пользователя и вставка в текстовое поле пароль пользователя
        {
            SaveManager.Saves.Login = comboBoxAccounts.SelectedItem.ToString();
            SaveManager.Load();
            maskedTextBoxPass.Text = SaveManager.Saves.Password;
        }

        
    }
}
