using System;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SnakeGame_Server
{
    public class Server
    {
        private static Socket _serverSocket;
        public static bool _serverOnline;
        private const int PORT = 3131;
        private const int BUFFER_SIZE = 2048;
        private static byte[] buffer = new byte[BUFFER_SIZE];

        private static List<User> _users = new List<User>();
        private static FrmServer _gui;

        public static void SetupServer(FrmServer gui)
        {
            Server._gui = gui;
            if (!_serverOnline)
            {
                _gui.tbServerOutput.Text += "Cargando Servidor...\r\n";

                _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
                _serverSocket.Listen(10);
                _serverSocket.BeginAccept(AcceptUser, null);

                _serverOnline = true;

                _gui.tbServerOutput.Text += "Servidor en linea\r\n";
            }
            else
            {
                _gui.tbServerOutput.Text += "Servidor listo\r\n";
            }
        }

        public static void ShutdownServer()
        {
            foreach (User user in _users)
            {
                user.getSocket().Shutdown(SocketShutdown.Both);
                user.getSocket().Close();
            }

            _serverSocket.Close();
            _serverOnline = false;
            _gui.tbServerOutput.Text += "Servidor apagado\r\n";
        }

        private static void AcceptUser(IAsyncResult AR)
        {
            Socket clientSocket;
            try
            {
                clientSocket = _serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            _serverSocket.BeginAccept(AcceptUser, null);
            clientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveUsername, clientSocket);
        }

        private static void ReceiveUsername(IAsyncResult AR)
        {
            Socket clientSocket = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = clientSocket.EndReceive(AR);
            }
            catch (SocketException)
            {
                clientSocket.Close();
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);

            if (text.Substring(0, 9) == "Username:")
            {
                _users.Add(new User(clientSocket, text.Substring(9)));

                _gui.lvServer.Invoke((MethodInvoker)delegate () {
                    _gui.lvServer.Items.Add(text.Substring(9));
                });

                AddText("Usuario " + text.Substring(9) + " conectado"); 

                SendMessageToOthers("otherUser " + text.Substring(9) + " conectado", new User(clientSocket, text.Substring(9)));
                SendCommand("!accepted" + _users.Count, clientSocket);

                clientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveMessage, clientSocket);
            }
            else
            {
                clientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveUsername, clientSocket);
            }
        }

        private static void ReceiveMessage(IAsyncResult AR)
        {
            Socket clientSocket = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = clientSocket.EndReceive(AR);
            }
            catch (SocketException)
            {
                int item = 0;


                foreach (User user in _users)
                {
                    if (user.getSocket() == clientSocket)
                    {
                        _users.Remove(new User(clientSocket, user.getUsername()));

                        _gui.lvServer.Invoke((MethodInvoker)delegate ()
                        {
                            _gui.lvServer.Items[item].Remove();
                        });
                    }

                    item++;
                }

                clientSocket.Close();

                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);

            if (text.Trim() == "!exit")
            {
                ExitUser(clientSocket);
            }
            else
            {
                AddText(FormatMessage(text));

                User sourceUser = null;

                foreach (User user in _users)
                {
                    if (user.getSocket() == clientSocket)
                    {
                        sourceUser = user;
                    }
                }

                if (sourceUser == null)
                {
                    throw new UserNotFoundException("User not found");
                }

                SendMessageToOthers(text, sourceUser);

                clientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveMessage, clientSocket);
            }
        }

        public static string FormatMessage(string message)
        {

            if (message.Trim() != "")
            {
                string[] datos = message.Trim().Split('|');
                string data = datos[0];

                switch (data.Substring(0, 5))
                {
                    case "point":
                        if (int.Parse(datos[4]) != 0)
                        {
                            message = "Player " + datos[1] + " earned " + datos[4] + " points" + "\r\n";
                            message += "Posicion X = " + datos[2] + " | Posicion Y = " + datos[3];
                        }
                        else
                        {
                            message = "Posicion X = " + datos[2] + " | Posicion Y = " + datos[3];
                        }
                        break;
                    case "moved":
                        int mov = int.Parse(datos[2]);
                        message = "Jugador " + datos[1] + " movimiento " + (mov == 1 ? "abajo" : (mov == 2 ? "arriba" : (mov == 3 ? "izquierda" : "derecha")));
                        break;
                    case "pause":
                        message = "Jugador " + datos[1] + " pauso el juego";
                        break;
                    case "plays":
                        message = "Jugador " + datos[1] + " inicio el juego";
                        break;
                    case "gameo":
                        message = "Juego Terminado!!!";
                        break;
                }
            }

            return message;
        }

        public static void SendMessage()
        {
            byte[] buffer = Encoding.ASCII.GetBytes("[Server] " + _gui.tbServerInput.Text + "\r\n");
            foreach (User user in _users)
            {
                user.getSocket().Send(buffer, 0, buffer.Length, SocketFlags.None);
            }
        }

        public static void SendMessageToOthers(string message, User sourceUser)
        {
            byte[] buffer = Encoding.ASCII.GetBytes("!" + message);
            foreach (User user in _users)
            {
                if (user != sourceUser)
                {
                    user.getSocket().Send(buffer, 0, buffer.Length, SocketFlags.None);
                }
            }
        }

        public static void SendCommand(string command, Socket clientSocket)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(command);
            clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public static void ExitUser(Socket userSocket)
        {
            int item = 0;

            foreach (User user in _users)
            {
                if (user.getSocket() == userSocket)
                {
                    string userName = user.getUsername();

                    AddText("Usuario " + userName + " desconectado");
                    SendMessageToOthers("Usuario " + userName + " desconectado\r\n", new User(userSocket, userName));

                    _users.Remove(new User(userSocket, userName));

                    _gui.lvServer.Invoke((MethodInvoker)delegate ()
                    {
                        _gui.lvServer.Items[item].Remove();
                    });
                }

                item++;
            }

            userSocket.Close();
        }

        public static void AddText(string text)
        {
            _gui.tbServerOutput.Invoke((MethodInvoker)delegate ()
            {
                _gui.tbServerOutput.Text += text + "\r\n";
                _gui.tbServerOutput.SelectionStart = _gui.tbServerOutput.Text.Length;
                _gui.tbServerOutput.ScrollToCaret();
            });
        }
    }

    public class User
    {
        private Socket socket;
        private string username;

        public User(Socket socket, String username)
        {
            this.socket = socket;
            this.username = username;
        }

        public Socket getSocket()
        {
            return socket;
        }

        public string getUsername()
        {
            return username;
        }

        public static bool operator ==(User user1, User user2)
        {
            if (object.ReferenceEquals(user1, null) && object.ReferenceEquals(user2, null))
                return true;

            if ((object.ReferenceEquals(user1, null) && !object.ReferenceEquals(user2, null))
                || (!object.ReferenceEquals(user1, null) && object.ReferenceEquals(user2, null)))
                return false;

            if (user1.socket == user2.socket && user1.username == user2.username)
                return true;
            else
                return false;
        }

        public static bool operator !=(User user1, User user2)
        {
            if (object.ReferenceEquals(user1, null) && object.ReferenceEquals(user2, null))
                return false;

            if ((object.ReferenceEquals(user1, null) && !object.ReferenceEquals(user2, null))
                || (!object.ReferenceEquals(user1, null) && object.ReferenceEquals(user2, null)))
                return true;

            if (user1 == null && user2 == null)
                return false;

            if (user1.socket == user2.socket && user1.username == user2.username)
                return false;
            else
                return true;
        }
    }
}