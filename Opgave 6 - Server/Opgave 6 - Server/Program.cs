using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6___Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // IP Address
            IPAddress serverAddress = IPAddress.Parse("127.0.0.1");

            // Port
            int port = 27015;

            // Creating a listener
            TcpListener listener = new TcpListener(serverAddress, port);
            Console.WriteLine($"Listener created.");

            // Listener started
            listener.Start();
            Console.WriteLine($"Listening..");

            // Allowing client connections
            TcpClient client = listener.AcceptTcpClient();
            Console.WriteLine($"User connected.");

            // Receiving data
            NetworkStream receive = client.GetStream();

            do
            {
                // Storing data
                byte[] dataReceived = new byte[client.ReceiveBufferSize];
                int dataRead = receive.Read(dataReceived, 0, Convert.ToInt32(client.ReceiveBufferSize));

                // Display what the client wrote
                string dataString = Encoding.ASCII.GetString(dataReceived, 0, dataRead);
                Console.WriteLine($"User: {dataString}");
            } while (true);
        }
    }
}
