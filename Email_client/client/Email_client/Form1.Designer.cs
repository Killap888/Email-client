namespace Email_client
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadMessage = new System.Windows.Forms.Button();
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.textBoxSeeBoby = new System.Windows.Forms.TextBox();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.buttonNewMessage = new System.Windows.Forms.Button();
            this.buttonSaveMessage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagelogin = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxServerSave = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxSaveUserData = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAutorization = new System.Windows.Forms.Label();
            this.comboBoxAccounts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxPass = new System.Windows.Forms.MaskedTextBox();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.buttonLoadMessages = new System.Windows.Forms.Button();
            this.tabPageNewMessages = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSendMessage = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxToFriend = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPagelogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.tabPageNewMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadMessage
            // 
            this.buttonLoadMessage.Location = new System.Drawing.Point(6, 15);
            this.buttonLoadMessage.Name = "buttonLoadMessage";
            this.buttonLoadMessage.Size = new System.Drawing.Size(199, 23);
            this.buttonLoadMessage.TabIndex = 1;
            this.buttonLoadMessage.Text = "Загрузка сообщений с сервера";
            this.buttonLoadMessage.UseVisualStyleBackColor = true;
            this.buttonLoadMessage.Click += new System.EventHandler(this.buttonLoadMessage_Click);
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.HorizontalScrollbar = true;
            this.listBoxMessage.ItemHeight = 19;
            this.listBoxMessage.Location = new System.Drawing.Point(6, 44);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.Size = new System.Drawing.Size(335, 327);
            this.listBoxMessage.TabIndex = 4;
            this.listBoxMessage.SelectedIndexChanged += new System.EventHandler(this.listBoxMessage_SelectedIndexChanged);
            // 
            // textBoxSeeBoby
            // 
            this.textBoxSeeBoby.Location = new System.Drawing.Point(347, 44);
            this.textBoxSeeBoby.Multiline = true;
            this.textBoxSeeBoby.Name = "textBoxSeeBoby";
            this.textBoxSeeBoby.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSeeBoby.Size = new System.Drawing.Size(480, 327);
            this.textBoxSeeBoby.TabIndex = 6;
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.HorizontalScrollbar = true;
            this.listBoxFolders.ItemHeight = 19;
            this.listBoxFolders.Location = new System.Drawing.Point(909, 51);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(36, 346);
            this.listBoxFolders.TabIndex = 7;
            this.listBoxFolders.SelectedIndexChanged += new System.EventHandler(this.listBoxFolders_SelectedIndexChanged);
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.Location = new System.Drawing.Point(887, 22);
            this.buttonNewMessage.Name = "buttonNewMessage";
            this.buttonNewMessage.Size = new System.Drawing.Size(64, 23);
            this.buttonNewMessage.TabIndex = 8;
            this.buttonNewMessage.Text = "Новое сообщение";
            this.buttonNewMessage.UseVisualStyleBackColor = true;
            // 
            // buttonSaveMessage
            // 
            this.buttonSaveMessage.Location = new System.Drawing.Point(347, 15);
            this.buttonSaveMessage.Name = "buttonSaveMessage";
            this.buttonSaveMessage.Size = new System.Drawing.Size(222, 23);
            this.buttonSaveMessage.TabIndex = 9;
            this.buttonSaveMessage.Text = "Сохранить письма на локальный диск";
            this.buttonSaveMessage.UseVisualStyleBackColor = true;
            this.buttonSaveMessage.Click += new System.EventHandler(this.buttonSaveMessage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagelogin);
            this.tabControl1.Controls.Add(this.tabPageMessages);
            this.tabControl1.Controls.Add(this.tabPageNewMessages);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 426);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPagelogin
            // 
            this.tabPagelogin.Controls.Add(this.groupBox2);
            this.tabPagelogin.Controls.Add(this.groupBox1);
            this.tabPagelogin.Location = new System.Drawing.Point(4, 22);
            this.tabPagelogin.Name = "tabPagelogin";
            this.tabPagelogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagelogin.Size = new System.Drawing.Size(839, 400);
            this.tabPagelogin.TabIndex = 1;
            this.tabPagelogin.Text = "Авторизация";
            this.tabPagelogin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxServerSave);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxLogin);
            this.groupBox2.Location = new System.Drawing.Point(228, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 385);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сменить аккаунт";
            this.groupBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сменить аккаунт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "Выберите \r\nпочтовый сервер";
            // 
            // comboBoxServerSave
            // 
            this.comboBoxServerSave.FormattingEnabled = true;
            this.comboBoxServerSave.Items.AddRange(new object[] {
            "Google",
            "Yandex",
            "Mail"});
            this.comboBoxServerSave.Location = new System.Drawing.Point(27, 69);
            this.comboBoxServerSave.Name = "comboBoxServerSave";
            this.comboBoxServerSave.Size = new System.Drawing.Size(250, 21);
            this.comboBoxServerSave.TabIndex = 8;
            this.comboBoxServerSave.Text = "Google";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Выберите сохраненный аккаунт";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(39, 127);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "killap888@gmail.com";
            this.textBoxLogin.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBoxSaveUserData);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelAutorization);
            this.groupBox1.Controls.Add(this.comboBoxAccounts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonEnter);
            this.groupBox1.Controls.Add(this.comboBoxServer);
            this.groupBox1.Controls.Add(this.maskedTextBoxPass);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 386);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Войти в аккаунт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Выберите \r\nпочтовый сервер";
            // 
            // checkBoxSaveUserData
            // 
            this.checkBoxSaveUserData.AutoSize = true;
            this.checkBoxSaveUserData.Location = new System.Drawing.Point(25, 202);
            this.checkBoxSaveUserData.Name = "checkBoxSaveUserData";
            this.checkBoxSaveUserData.Size = new System.Drawing.Size(162, 17);
            this.checkBoxSaveUserData.TabIndex = 7;
            this.checkBoxSaveUserData.Text = "Запомнить пользователя?";
            this.checkBoxSaveUserData.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Пароль";
            // 
            // labelAutorization
            // 
            this.labelAutorization.AutoSize = true;
            this.labelAutorization.Location = new System.Drawing.Point(25, 326);
            this.labelAutorization.Name = "labelAutorization";
            this.labelAutorization.Size = new System.Drawing.Size(13, 13);
            this.labelAutorization.TabIndex = 4;
            this.labelAutorization.Text = "_";
            // 
            // comboBoxAccounts
            // 
            this.comboBoxAccounts.FormattingEnabled = true;
            this.comboBoxAccounts.Location = new System.Drawing.Point(25, 136);
            this.comboBoxAccounts.Name = "comboBoxAccounts";
            this.comboBoxAccounts.Size = new System.Drawing.Size(154, 21);
            this.comboBoxAccounts.TabIndex = 4;
            this.comboBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccounts_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Логин";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(25, 235);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(154, 55);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Items.AddRange(new object[] {
            "Google",
            "Yandex",
            "Mail"});
            this.comboBoxServer.Location = new System.Drawing.Point(25, 70);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(154, 21);
            this.comboBoxServer.TabIndex = 3;
            this.comboBoxServer.SelectedIndexChanged += new System.EventHandler(this.comboBoxServer_SelectedIndexChanged);
            // 
            // maskedTextBoxPass
            // 
            this.maskedTextBoxPass.Location = new System.Drawing.Point(25, 176);
            this.maskedTextBoxPass.Name = "maskedTextBoxPass";
            this.maskedTextBoxPass.PasswordChar = '*';
            this.maskedTextBoxPass.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBoxPass.TabIndex = 1;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.buttonLoadMessages);
            this.tabPageMessages.Controls.Add(this.listBoxFolders);
            this.tabPageMessages.Controls.Add(this.buttonSaveMessage);
            this.tabPageMessages.Controls.Add(this.buttonNewMessage);
            this.tabPageMessages.Controls.Add(this.listBoxMessage);
            this.tabPageMessages.Controls.Add(this.textBoxSeeBoby);
            this.tabPageMessages.Controls.Add(this.buttonLoadMessage);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(839, 400);
            this.tabPageMessages.TabIndex = 0;
            this.tabPageMessages.Text = "Сообщения";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // buttonLoadMessages
            // 
            this.buttonLoadMessages.Location = new System.Drawing.Point(575, 15);
            this.buttonLoadMessages.Name = "buttonLoadMessages";
            this.buttonLoadMessages.Size = new System.Drawing.Size(216, 23);
            this.buttonLoadMessages.TabIndex = 10;
            this.buttonLoadMessages.Text = "Загрузить сохраненные письма";
            this.buttonLoadMessages.UseVisualStyleBackColor = true;
            this.buttonLoadMessages.Click += new System.EventHandler(this.buttonLoadMessages_Click);
            // 
            // tabPageNewMessages
            // 
            this.tabPageNewMessages.Controls.Add(this.comboBox1);
            this.tabPageNewMessages.Controls.Add(this.labelSendMessage);
            this.tabPageNewMessages.Controls.Add(this.buttonSendMessage);
            this.tabPageNewMessages.Controls.Add(this.label4);
            this.tabPageNewMessages.Controls.Add(this.label3);
            this.tabPageNewMessages.Controls.Add(this.label2);
            this.tabPageNewMessages.Controls.Add(this.label1);
            this.tabPageNewMessages.Controls.Add(this.textBoxBody);
            this.tabPageNewMessages.Controls.Add(this.textBoxSubject);
            this.tabPageNewMessages.Controls.Add(this.textBoxToFriend);
            this.tabPageNewMessages.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewMessages.Name = "tabPageNewMessages";
            this.tabPageNewMessages.Size = new System.Drawing.Size(839, 400);
            this.tabPageNewMessages.TabIndex = 2;
            this.tabPageNewMessages.Text = "Отправка сообщения";
            this.tabPageNewMessages.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // labelSendMessage
            // 
            this.labelSendMessage.AutoSize = true;
            this.labelSendMessage.Location = new System.Drawing.Point(628, 345);
            this.labelSendMessage.Name = "labelSendMessage";
            this.labelSendMessage.Size = new System.Drawing.Size(13, 13);
            this.labelSendMessage.TabIndex = 9;
            this.labelSendMessage.Text = "_";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(457, 314);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(164, 74);
            this.buttonSendMessage.TabIndex = 8;
            this.buttonSendMessage.Text = "Отправить письмо";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Текст письма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тема письма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Получатель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отправитель";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(43, 151);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(408, 246);
            this.textBoxBody.TabIndex = 3;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(191, 88);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(260, 20);
            this.textBoxSubject.TabIndex = 2;
            // 
            // textBoxToFriend
            // 
            this.textBoxToFriend.Location = new System.Drawing.Point(191, 52);
            this.textBoxToFriend.Name = "textBoxToFriend";
            this.textBoxToFriend.Size = new System.Drawing.Size(260, 20);
            this.textBoxToFriend.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Почтовый клиент";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagelogin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageMessages.ResumeLayout(false);
            this.tabPageMessages.PerformLayout();
            this.tabPageNewMessages.ResumeLayout(false);
            this.tabPageNewMessages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLoadMessage;
        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.TextBox textBoxSeeBoby;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.Button buttonSaveMessage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.TabPage tabPagelogin;
        private System.Windows.Forms.TabPage tabPageNewMessages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPass;
        private System.Windows.Forms.Button buttonLoadMessages;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxToFriend;
        private System.Windows.Forms.Label labelAutorization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSendMessage;
        private System.Windows.Forms.CheckBox checkBoxSaveUserData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxServerSave;
        private System.Windows.Forms.Label label8;
    }
}

