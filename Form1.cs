using ChatDataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperChatClient
{
    public partial class Form1 : Form
    {
        TcpClient client = null;
        string userName = string.Empty;
        BinaryFormatter formatter = null;
        NetworkStream ns = null;
        ChatData emptyRequest = null;

        public Form1()
        {
            InitializeComponent();

            client = new TcpClient();
            formatter = new BinaryFormatter();
            btLogin.Enabled = false;
            emptyRequest = new ChatData()
            {
                FileName = string.Empty,
                FromName = string.Empty,
                Text = string.Empty,
                Data = null,
                Password = string.Empty,
                ToName = string.Empty,
                Command = "Sync"
            };
            timer.Start();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(tbAddress.Text.Trim()),
                Convert.ToInt32(tbPort.Text.Trim()));
            client.Connect(ep);
            ns = client.GetStream();
            btConnect.BackColor = Color.GreenYellow;
            btConnect.Enabled = false;
        }

        private void GetServerAnswer()
        {
            int size = client.ReceiveBufferSize;
            byte[] buffer = new byte[size];
            ns.Read(buffer, 0, size);

            string chatHistory = Encoding.UTF8.GetString(buffer).Trim();
            Invoke((MethodInvoker)delegate ()
            {
                tbChat.Text = chatHistory;
            });
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            userName = tbName.Text.Trim();
            ChatData chatData = new ChatData()
            {
                FromName = userName,
                ToName = string.Empty,
                Text = string.Empty,
                FileName = string.Empty,
                Password = string.Empty,
                Data = null,
                Command = "Login"
            };
            SendMessage(chatData);           
        }

        private void SendMessage(ChatData chatData)
        {
            if(ns != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        formatter.Serialize(ms, chatData);
                        ns.Write(ms.ToArray(), 0, (int)ms.Length);
                        ns.Flush();

                        if (chatData != emptyRequest)
                        {
                            tbMessage.Text = string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void btSelect_Click(object sender, EventArgs e)
        {

        }

        private void tbSend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbMessage.Text) &&
                string.IsNullOrEmpty(tbFile.Text))
            {
                return;
            }
            ChatData chatData = new ChatData()
            {
                FromName = userName,
                ToName = string.Empty,
                Text = tbMessage.Text,
                FileName = string.Empty,
                Password = string.Empty,
                Data = null,
                Command = "Text"
            };
            SendMessage(chatData);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty( tbName.Text))
            {
                btLogin.Enabled = false;
            }
            else
            {
                btLogin.Enabled = true;
            }
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            if (emptyRequest != null)
            {
                SendMessage(emptyRequest);
            }
            
            if(ns != null)
            {
                await Task.Run(GetServerAnswer);
            }
        }
    }
}
