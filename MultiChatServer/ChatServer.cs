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
        public class AsyncObject
        {
            public Byte[] Buffer;
            public Socket WorkingSocket;
            public AsyncObject(Int32 bufferSize)
            {
                this.Buffer = new byte[bufferSize];
            }
        }

        #region Private Fields
        private Socket mainSocket = null;
        private AsyncCallback m_fnReceiveHandler;
        private AsyncCallback m_fnSendHandler;
        private AsyncCallback m_fnAcceptHandler;
        #endregion Private Fields

        public ChatServer() 
        {
            
        }

        public void StartServer()
        {
            m_fnReceiveHandler = new AsyncCallback(handleDataReceive);
            m_fnSendHandler = new AsyncCallback(handleDataSend);
            m_fnAcceptHandler = new AsyncCallback(handleClientConnectionRequest);

            mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            mainSocket.Bind(new IPEndPoint(IPAddress.Any, 1234));
            mainSocket.Listen(100);
            mainSocket.BeginAccept(m_fnAcceptHandler, null);
        }

        public void StopServer()
        {
            mainSocket.Close();
        }

        public void SendMessage(string message)
        {
            AsyncObject ao = new AsyncObject(1);
            ao.Buffer = Encoding.Unicode.GetBytes(message);

            ao.WorkingSocket = mainSocket;
            mainSocket.BeginSend(ao.Buffer, 0, ao.Buffer.Length, SocketFlags.None, m_fnSendHandler, ao);
        }

        public void CreateSocket()
        {
            try
            {
                mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
            catch (Exception e)
            {

            }
            
        }

        #region Handling Methods
        private void handleClientConnectionRequest(IAsyncResult ar)
        {
            Socket sockClient = mainSocket.EndAccept(ar);
            AsyncObject ao = new AsyncObject(4096);
            ao.WorkingSocket = sockClient;
            sockClient.BeginReceive(ao.Buffer, 0, ao.Buffer.Length, SocketFlags.None, m_fnReceiveHandler, ao);
        }
        private void handleDataReceive(IAsyncResult ar)
        {
            AsyncObject ao = (AsyncObject)ar.AsyncState;
            Int32 recvBytes = ao.WorkingSocket.EndReceive(ar);
            if(recvBytes>0)
            {
                Console.WriteLine($"Message Received: {Encoding.Unicode.GetString(ao.Buffer)}");
            }
            ao.WorkingSocket.BeginReceive(ao.Buffer, 0, ao.Buffer.Length, SocketFlags.None, m_fnReceiveHandler, ao);
        }
        private void handleDataSend(IAsyncResult ar)
        {
            AsyncObject ao = (AsyncObject)ar.AsyncState;
            Int32 sentBytes = ao.WorkingSocket.EndSend(ar);
            if(sentBytes>0)
            {
                Console.WriteLine($"Message Sent: {Encoding.Unicode.GetString(ao.Buffer)}");
            }
        }
        #endregion Handling Methods
    }
}
