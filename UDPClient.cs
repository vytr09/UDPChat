using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace UDP_TCP_Chat
{
    public partial class UDPClient : Form
    {
        private UdpClient client;

        public UDPClient()
        {
            InitializeComponent();
            historyBox.ReadOnly = true;
            msgBox.KeyPress += msgBox_KeyPress;
            client = new UdpClient();
        }

        private void UDPClient_Load(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipadd = IPAddress.Parse(IPBox.Text);
                int port = Convert.ToInt32(portBox.Text);

                IPEndPoint endPoint = new IPEndPoint(ipadd, port);

                string msg = msgBox.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(msg);

                // Send message
                client.Send(buffer, buffer.Length, endPoint);
                msgBox.Text = "";

                endPoint = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref endPoint);

                msg = Encoding.UTF8.GetString(buffer);

                WriteLog(msg);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("SocketException: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                historyBox.AppendText("Message sent: " + msg + Environment.NewLine);
            });
            this.BeginInvoke(invoker);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the UDP client
            client?.Close();

            this.Close();
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

        private void tcpBtn_Click(object sender, EventArgs e)
        {
            TCPServer tcp = new TCPServer();
            tcp.Show();
        }
    }
}
