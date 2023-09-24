using System;
using System.Net;
using System.Net.Sockets;

namespace ClientApp
{
    public class Program // Developed by Aslan Ibadulla.
    {
        public static int Main(String[] args)
        {
            RunClient();
            return 0;
        }

        public static void RunClient()
        {
            try
            {
                // Configuration of host, ip address of the client starts here.
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, 11000); // server's end point.

                // Creation of client's socket and binding it with remote end point
                // TO DO
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
