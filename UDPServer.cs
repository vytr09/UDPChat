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
using System.Threading;

namespace UDP_TCP_Chat
{
    public partial class UDPServer : Form
    {
        UdpClient server;
        IPEndPoint endPoint;
        Thread th;

        public UDPServer()
        {
            InitializeComponent();
            historyBox.ReadOnly = true;
        }

        private void UDPServer_Load(object sender, EventArgs e)
        {

        }

        private void newClient_Click(object sender, EventArgs e)
        {
            UDPClient client = new UDPClient();
            client.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            server = new UdpClient(int.Parse(portBox.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);

            WriteLog("22521709");
            WriteLog("Server started...");

            th = new Thread(new ThreadStart(ServerStart));
            th.Start();

            start.Enabled = false;
        }

        private void ServerStart()
        {
            while (true)
            {
                byte[] buffer = server.Receive(ref endPoint);

                string msg = Encoding.UTF8.GetString(buffer);

                WriteLog("Client 22521709: " + msg);

                buffer = Encoding.UTF8.GetBytes(DateTime.Now.ToString());

                server.Send(buffer, buffer.Length, endPoint);
            }
        }

        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                historyBox.AppendText(msg + Environment.NewLine);
            });
            this.BeginInvoke(invoker);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the server thread
            if (th != null && th.IsAlive)
                th.Abort();

            // Close the UDP server
            server?.Close();

            this.Close();
        }

        private void historyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcpBtn_Click(object sender, EventArgs e)
        {
            TCPServer tcp = new TCPServer();
            tcp.Show();
        }
    }
}
