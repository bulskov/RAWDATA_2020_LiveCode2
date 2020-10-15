using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class ServerProgram
    {
        static void Main(string[] args)
        {
            var server = new TcpListener(IPAddress.Loopback, 5000);
            server.Start();
            Console.WriteLine("Serve started!");

            while (true)
            {
                var client = server.AcceptTcpClient();
                Console.WriteLine("Accepted client!");

                var stream = client.GetStream();

                byte[] data = new byte[client.ReceiveBufferSize];

                var cnt = stream.Read(data);

                var msg = Encoding.UTF8.GetString(data, 0, cnt);

                Console.WriteLine($"Message from client {msg}");


            }
        }
    }
}
