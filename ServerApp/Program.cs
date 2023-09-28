using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerApp
{
    public class Program // *** Developed by Aslan Ibadullayev ***
    {
        public static int Main(String[] args)
        {
            RunServer(args);
            return 0;
        }

        public static void RunServer(String[] args)
        {
            // necessary hoisted variables here.
            
            try
            {
                // Configuring host, ip address, localendpoint of server/listener starts from here.
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint serverEndPoint = new IPEndPoint(ipAddress, Convert.ToInt32(args[0]));


                // Creation of server/ listener socket 
                // TO DO
                Socket server = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(serverEndPoint);

                server.Listen(10); // server can accept up to 100 requests at a time.

                Console.WriteLine("ready to serve!");
                Console.WriteLine("listening on port {0}", serverEndPoint.Port);
                Console.WriteLine("Enter stop to quit");

                Socket handler = server.Accept();
                while (true)
                {
                    
                    byte[] bytes = new byte[1024];
                    string data = string.Empty;

                    int size = handler.Receive(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, size);
                    Console.WriteLine(int.Parse(data) * 2);

                }
            }
            catch(SocketException ex)
            {
                Console.WriteLine("Socket-related error!" + " " + ex.Message + ex.InnerException);
            }
            catch(FormatException)
            {
                Console.WriteLine("enter an integer for server port number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("some unknown error");
            }
        }
    }
}
