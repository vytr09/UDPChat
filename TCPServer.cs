using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_TCP_Chat
{
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
            historyBox.ReadOnly = true;
        }

        IPEndPoint ep;
        TcpListener listener;
        Thread th;

        private void TCPServer_Load(object sender, EventArgs e)
        {
   
        }

        private void start_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(portBox.Text);
            ep = new IPEndPoint(IPAddress.Loopback, port);
            listener = new TcpListener(ep);
            listener.Start();

            WriteLog("22521709");
            WriteLog("Server started...");

            th = new Thread(new ThreadStart(ServerStart));
            th.Start();

            start.Enabled = false;
        }

        private void ServerStart()
        {
            try
            {
                while (true)
                {
                    TcpClient sender = listener.AcceptTcpClient();
                    NetworkStream stream = sender.GetStream();

                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    StringBuilder msgBuilder = new StringBuilder();

                    // Keep reading data until the client closes the connection
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        msgBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    }

                    string msg = msgBuilder.ToString();

                    // Echoing back the received message
                    byte[] responseBuffer = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
                    stream.Write(responseBuffer, 0, responseBuffer.Length);

                    sender.Close();

                    WriteLog(msg);
                }
            }
            catch (SocketException ex)
            {
                // Check if the error code is due to blocking call cancellation
                if (ex.SocketErrorCode != SocketError.Interrupted)
                {
                    // Handle other socket errors
                    WriteLog("SocketException: " + ex.Message);
                }
                else
                {
                    // Handle cancellation gracefully (e.g., log it and exit the loop)
                    WriteLog("Listener stopped.");
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                WriteLog("Error: " + ex.Message);
            }
        }

        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                historyBox.AppendText("Client 22521709: " + msg + Environment.NewLine);
            });
            this.BeginInvoke(invoker);
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listener?.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while stopping the TCP server: " + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            TCPClient client = new TCPClient();
            client.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UDPServer udpServer = new UDPServer();
            udpServer.Show();
        }
    }
}
