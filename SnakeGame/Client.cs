using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Linq;

namespace SnakeGame
{
    public class Client
    {
        private static Socket _clientSocket;
        private static bool _clientConnected;
        private const int PORT = 3131;
        private const int BUFFER_SIZE = 2048;
        private static byte[] buffer = new byte[BUFFER_SIZE];
        private static string _username;

        private static Form _gui;

        public static void Connect(Form gui, string userName, string ipAddress)
        {
            Client._gui = gui;
            Client._username = userName;

            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            while (!_clientSocket.Connected)
            {
                try
                {
                    if (ipAddress.ToLower().Trim() == "loopback" || ipAddress.ToLower().Trim() == "lb")
                    {
                        _clientSocket.Connect(IPAddress.Loopback, PORT);
                    }
                    else
                    {
                        _clientSocket.Connect(IPAddress.Parse(ipAddress.Trim()), PORT);
                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }

            _clientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveMessage, _clientSocket);
            while (!_clientConnected)
            {
                SendUsername();
                Console.WriteLine(_clientConnected);
                Thread.Sleep(500);
            }

            Console.WriteLine(_clientConnected);
        }

        public static void Disconnect()
        {
            if (_clientConnected)
            {
                SendCommand("!exit");
                _clientSocket.Close();
                _clientSocket.Close();
                _clientConnected = false;
            }
        }

        public static void ReceiveMessage(IAsyncResult AR)
        {
            Console.WriteLine("Received Sth");
            Socket serverSocket = (Socket)AR.AsyncState;
            int received = 0;

            try
            {
                received = serverSocket.EndReceive(AR);
            }
            catch (SocketException)
            {
                serverSocket.Close();
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);

            if (text.Trim() != "")
            {
                ValidateCommand(text);

                _clientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveMessage, _clientSocket);
            }
        }

        public static void SendMessage()
        {
            string data = _gui.Controls.OfType<Label>().Where(x => x.Name == "lblInput").First().Text;

            byte[] buffer = Encoding.ASCII.GetBytes(data + "");
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public static void SendCommand(string command)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(command);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public static void SendUsername()
        {
            byte[] buffer = Encoding.ASCII.GetBytes("Username:" + Client._username);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public static void ValidateCommand(string command)
        {
            if (command.Trim().Length > 9)
            {
                if (command.Trim().Substring(0, 9) == "!accepted")
                {
                    Console.WriteLine("command validation reached");
                    _clientConnected = true;
                }
            }
            
            _gui.Controls.OfType<Label>().Where(x => x.Name == "lblOutput").First().Invoke((MethodInvoker)delegate ()
            {
                _gui.Controls.OfType<Label>().Where(x => x.Name == "lblOutput").First().Text = command;
            });
        }
    }
}
