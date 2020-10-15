using System;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class ClientProgram
    {
        static void Main(string[] args)
        {
            using var client = new TcpClient();
            client.Connect(IPAddress.Loopback, 5000);

        }
    }
}
