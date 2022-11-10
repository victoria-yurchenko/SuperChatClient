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
        string UserName = string.Empty;
        BinaryFormatter formatter = null;
        NetworkStream ns = null;
        public Form1()
        {
            InitializeComponent();

            client = new TcpClient();
            formatter = new BinaryFormatter();
            btLogin.Enabled = false;
            

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

        private void btLogin_Click(object sender, EventArgs e)
        {
            UserName = tbName.Text.Trim();
            ChatData chatData = new ChatData()
            {
                FromName = UserName,
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
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    formatter.Serialize(ms, chatData);
                    ns.Write(ms.ToArray(), 0, (int)ms.Length);
                    ns.Flush();
                    tbMessage.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                FromName = UserName,
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
    }
}
