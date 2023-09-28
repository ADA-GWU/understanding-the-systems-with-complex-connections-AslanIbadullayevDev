using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientApp
{
    public class Program // *** Developed by Aslan Ibadullayev ***
    {
        public static int num;
        public static int Main(String[] args)
        {
            RunClient();
            return 0;
        }

        public static void RunClient()
        {
            byte[]? bytes = new byte[1024];
            try
            {
                // Configuration of host, ip address of the client starts here.
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, 9001); // server's end point.

                // Creation of client's socket and binding it with remote end point

                Socket client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(remoteEndPoint);
                while (true)
                {
                    
                    bool parseOk = int.TryParse(Console.ReadLine(), out num);

                    if (parseOk) {
                        bytes = Encoding.ASCII.GetBytes(num.ToString());
                        client.Send(bytes);
                    }
                    else
                    {
                        Console.WriteLine("Enter a number");
                    }
                }
                
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
