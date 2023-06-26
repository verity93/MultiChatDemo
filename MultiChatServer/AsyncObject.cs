using System;
using System.Net.Sockets;

namespace MultiChatServer
{
    public class AsyncObject
    {
        public Byte[] Buffer;
        public Socket WorkingSocket;
        public readonly int BufferSize;
        public AsyncObject(Int32 bufferSize)
        {
            BufferSize = bufferSize;
            this.Buffer = new byte[BufferSize];
        }
        public void ClearBuffer()
        {
            Array.Clear(Buffer, 0, BufferSize);
        }
    }
}
