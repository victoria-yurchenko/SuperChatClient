namespace SuperChatClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lbUsers);
            this.groupBox1.Controls.Add(this.btConnect);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 344);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(173, 45);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(104, 23);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(10, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(157, 23);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 15;
            this.lbUsers.Location = new System.Drawing.Point(10, 76);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.ScrollAlwaysVisible = true;
            this.lbUsers.Size = new System.Drawing.Size(267, 259);
            this.lbUsers.TabIndex = 11;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(173, 16);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(104, 23);
            this.btConnect.TabIndex = 10;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(102, 17);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(65, 23);
            this.tbPort.TabIndex = 9;
            this.tbPort.Text = "8888";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(10, 17);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(86, 23);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbChat);
            this.groupBox2.Controls.Add(this.tbSend);
            this.groupBox2.Controls.Add(this.tbFile);
            this.groupBox2.Controls.Add(this.btSelect);
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Location = new System.Drawing.Point(293, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 336);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(17, 135);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(356, 201);
            this.tbChat.TabIndex = 4;
            // 
            // tbSend
            // 
            this.tbSend.BackColor = System.Drawing.Color.Lime;
            this.tbSend.Location = new System.Drawing.Point(16, 107);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(75, 23);
            this.tbSend.TabIndex = 3;
            this.tbSend.Text = "Send";
            this.tbSend.UseVisualStyleBackColor = false;
            this.tbSend.Click += new System.EventHandler(this.tbSend_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(95, 76);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(278, 23);
            this.tbFile.TabIndex = 2;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(14, 77);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 1;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMessage.Location = new System.Drawing.Point(14, 21);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(359, 48);
            this.tbMessage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Button tbSend;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.TextBox tbMessage;
    }
}
