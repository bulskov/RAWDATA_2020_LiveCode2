using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class ServerProgram
    {
        static void Main(string[] args)
        {
            var server = new TcpListener(IPAddress.Loopback, 5000);
            server.Start();

            while (true)
            {
                var client = server.AcceptTcpClient();
                Console.WriteLine("Accepted client!");
            }
        }
    }
}
