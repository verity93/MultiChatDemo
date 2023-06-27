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

namespace MultiChatDemo
{
    public partial class ClientChatWindow : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);

        #region private fields
        private IPAddress thisAddress;
        private Socket mainSocket;
        private AppendTextDelegate _textAppender;
        #endregion private fields

        #region Constructor & Initial Methods
        public ClientChatWindow()
        {
            InitializeComponent();
            mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            _textAppender = new AppendTextDelegate(AppendText);
        }
        private void OnFormLoaded(object sender, EventArgs e)
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress addr in hostEntry.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }
            if (thisAddress == null)
            {
                thisAddress = IPAddress.Loopback;
            }
            textBox_ServerAddress.Text = thisAddress.ToString();
        }
        #endregion Constructor & Initial Methods

        #region UI Methods
        private void ConnectToServer(object sender, EventArgs e)
        {
            if (mainSocket.Connected)
            {
                // message - already connected to server
                return;
            }
            int port;
            if (!int.TryParse(textBox_PortNumber.Text, out port))
            {
                // message - incorrect or missing port number
                textBox_PortNumber.Focus();
                textBox_PortNumber.SelectAll();
                return;
            }

            try
            {
                mainSocket.Connect(textBox_ServerAddress.Text, port);
            }
            catch (Exception ex)
            {
                // message - failed to connect: errortext ex
                return;
            }

            AppendText(textBox_ChatHistory, $"Successfully Connected to Server at {textBox_ServerAddress.Text}.");

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = mainSocket;
            mainSocket.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
        }

        private void SendMessage(object sender, EventArgs e)
        {
            if (!mainSocket.IsBound)
            {
                // message - not connected to server
                return;
            }

            string textToSend = textBox_SendMessage.Text.Trim();
            if (string.IsNullOrEmpty(textToSend))
            {
                // message - no text to send
                textBox_SendMessage.Focus();
                return;
            }

            IPEndPoint ip = (IPEndPoint)mainSocket.LocalEndPoint;
            string addr = ip.ToString();

            byte[] byteDataToSend = Encoding.UTF8.GetBytes(addr+'\x01'+textToSend);

            mainSocket.Send(byteDataToSend);

            AppendText(textBox_ChatHistory, string.Format($"[Sent]{addr}: {textToSend}"));
            textBox_SendMessage.Clear();
        }

        private void AppendText(Control ctrl, string s)
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
        #endregion UI Methods

        #region Callback Methods
        private void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            int received = 0;

            try
            {
                received= obj.WorkingSocket.EndReceive(ar);
            }
            catch(Exception e)
            {
                // server has terminated connection
                obj.WorkingSocket.Close();
                return;
            }

            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            string text = Encoding.UTF8.GetString(obj.Buffer);

            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            string msg = tokens[1];

            AppendText(textBox_ChatHistory, string.Format($"[Received]{ip}: {msg}"));

            obj.ClearBuffer();
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }
        #endregion Callback Methods
    }
}
