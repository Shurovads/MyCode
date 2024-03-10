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
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Laba6
{
    public partial class Form1 : Form
    {
        public delegate void ShowMessage(string message);
        public ShowMessage myDelegate;
        UdpClient udpClient;
        Thread thread;
        bool isClientOpen = false;

        public Form1()
        {
            //CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            txtStartIP.Text = "127.0.0.1";
            //myPort.Text = "12346";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDelegate = new ShowMessage(ShowMessageMethod);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                thread.Abort();
                udpClient.Close();
                Close();
            }
        }
        private void ReceiveMessage()
        {
            if (isClientOpen)
            {
                while (true)
                {
                    IPEndPoint remoteIPEndpoint = new IPEndPoint(IPAddress.Any, Int32.Parse(myPort.Text));
                    byte[] content = udpClient.Receive(ref remoteIPEndpoint);
                    if (content.Length > 0)
                    {
                        string message = Encoding.ASCII.GetString(content);
                        this.Invoke(myDelegate, new object[] { message });
                    }
                }
            }
        }
        private void ShowMessageMethod(string message)
        {
            richText.Items.Add(message);
        }
        

        private void BtnSend_Click(object sender, EventArgs e)
        {
            //richText.Items.Add("Me: " + MyMessage.Text);
            int recipientPort;
            if (int.TryParse(portClient.Text, out recipientPort))
            {
                recipientPort = int.Parse(portClient.Text);
                //richText.Items.Add("Me: " + MyMessage.Text);
                IPAddress ip = IPAddress.Parse(txtStartIP.Text.Trim());
                IPEndPoint ipEndPoint = new IPEndPoint(ip, recipientPort);
                byte[] content = Encoding.ASCII.GetBytes(MyMessage.Text);
                try
                {
                    int count = udpClient.Send(content, content.Length, ipEndPoint);
                    if (count > 0)
                    {
                        richText.Items.Add("Me: " + MyMessage.Text);
                        MessageBox.Show("Mess has been send", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Error occurs.", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //int count = udpClient.Send(content, content.Length, ipEndPoint);

            }
            else
            {
                MessageBox.Show("Error Port.", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                int MyPort;
                if (int.TryParse(myPort.Text, out MyPort))
                {
                    udpClient = new UdpClient(int.Parse(myPort.Text));
                    BtnSend.Visible = true;
                    isClientOpen = true;
                    thread = new Thread(new ThreadStart(ReceiveMessage));
                    thread.IsBackground = true;
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Error MyPort");
                }
            }
            catch
            {
                MessageBox.Show("Connect error");
            }
        }
    }
}
