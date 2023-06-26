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

namespace MultiChatServer
{
    public partial class ChatWindow : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);

        #region private fields
        private AppendTextDelegate _textAppender;
        private Socket mainSocket = null;
        private List<Socket> connectedClients = new List<Socket>();
        private IPAddress thisAddress;
        #endregion private fields

        public ChatWindow()
        {
            InitializeComponent();
        }
        private void DigitFilter(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar));
        }

        void CreateSocket()
        {
            int port = 15000;
            try
            {
                mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
            catch(Exception e)
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
            int received = obj.WorkingSocket.EndReceive(ar);

            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            string text = Encoding.UTF8.GetString(obj.Buffer);

            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            string msg = tokens[1];

            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                if (socket.Handle != obj.WorkingSocket.Handle)
                {
                    socket.Send(obj.Buffer);
                }
            }

            obj.ClearBuffer();
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }



        #region UI methods
        void AppendText(Control ctrl, string s)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(_textAppender, ctrl, s);
            }
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }
        #endregion UI methods

    }
}
