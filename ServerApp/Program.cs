using System;
using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
    public class Program // Developed by Aslan Ibadulla
    {
        public static int Main(String[] args)
        {
            RunServer(args);
            return 0;
        }

        public static void RunServer(String[] args)
        {
            // necessary hoisted variables here.
            byte[] bytes = null; 
            string data = null; 

            // Configuring host, ip address, localendpoint of server/listener starts from here.
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(ipAddress, Convert.ToInt32(args[0]));

            // Creation of server/ listener socket 
            // TO DO
        }
    }
}
