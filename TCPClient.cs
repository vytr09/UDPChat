using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_TCP_Chat
{
    public partial class TCPClient : Form
    {
        private TcpClient client;

        public TCPClient()
        {
            InitializeComponent();
            historyBox.ReadOnly = true;
            msgBox.KeyPress += msgBox_KeyPress;
        }

        

        private void TCPClient_Load(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipadd = IPAddress.Parse(IPBox.Text);
                int port = Convert.ToInt32(portBox.Text);

                IPEndPoint endPoint = new IPEndPoint(ipadd, port);
                client = new TcpClient();
                client.Connect(endPoint);

                string msg = msgBox.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(msg);

                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);

                msgBox.Text = "";

                // Call WriteLog function to log the message
                WriteLog(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                client?.Close();
            }
        }

        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                historyBox.AppendText("Server 22521709 sent: " + msg + Environment.NewLine);
            });
            this.BeginInvoke(invoker);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while closing the TCP client: " + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UDPServer udpServer = new UDPServer();
            udpServer.Show();
        }

        private void msgBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Suppress the Enter key from being processed by the textbox
                e.Handled = true;

                // Perform the send action
                sendBtn.PerformClick();
            }
        }
    }
}
