using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MultiChatServer
{
    public class ChatServer
    {
        #region Private Fields
        private Socket mainSocket = null;
        private List<Socket> connectedClients = new List<Socket>();
        #endregion Private Fields

        public ChatServer() 
        {
            
        }

        public void CreateSocket()
        {
            int port = 1234;
            try
            {
                mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
            catch (Exception e)
            {

            }
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, port);
            mainSocket.Bind(serverEP);
            mainSocket.Listen(10);
            mainSocket.BeginAccept(AcceptCallback, null);
        }

        void AcceptCallback(IAsyncResult ar)
        {
            Socket client = mainSocket.EndAccept(ar);
            mainSocket.BeginAccept(AcceptCallback, null);

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = client;
            connectedClients.Add(client);
            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            string text = System.Text.Encoding.UTF8.GetString(obj.Buffer);

            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                if(socket.Handle!=obj.WorkingSocket.Handle)
                {
                    socket.Send(obj.Buffer);
                }
            }

            obj.ClearBuffer();
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }
    }
}
