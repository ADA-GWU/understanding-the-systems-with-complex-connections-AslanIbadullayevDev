using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerApp
{
    public class Program // *** Developed by Aslan Ibadullayev ***
    {
        public static List<string> list = new List<string>();
        public static int Main(String[] args)
        {
            RunServer(args);
            return 0;
        }

        public static void RunServer(String[] args)
        {
     
            try
            {
                #pragma warning disable CS8600 // for suppressing some errors not affecting the program
                using (TextReader reader = new StreamReader(File.Open("../PortNumbers.txt", FileMode.OpenOrCreate)))
                {
                    string line;
                #pragma warning disable CS8604
                    while ((line = reader.ReadLine()) != null)
                        list.Add(line);
                #pragma warning disable CS8604
                    reader.Close();
                }
                #pragma warning disable CS8600
                #pragma warning disable CS8600
                using (StreamWriter writer = new StreamWriter("../PortNumbers.txt", true))
                {
                    if (!list.Contains(args[0]))
                        writer.WriteLine(args[0]);
                }

                #pragma warning disable CS8600
                // Configuring host, ip address, local endpoint of server/listener starts from here.
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint serverEndPoint = new IPEndPoint(ipAddress, Convert.ToInt32(args[0]));

                Socket server = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(serverEndPoint); // to specify the server's ip address and port

                server.Listen(10); // specifies how many request can be accepted at a time

                Console.WriteLine("ready to serve!");
                Console.WriteLine("listening on port {0}", serverEndPoint.Port);

                while (true)
                {

                    Socket handler = server.Accept(); // socket created to handle incoming requests
                    byte[] bytes = new byte[1024];
                    string data = string.Empty;

                    int size = handler.Receive(bytes); // receiving data from the client
                    data = Encoding.ASCII.GetString(bytes, 0, size);
                    Console.WriteLine(int.Parse(data) * 2); // doubled value gets displayed.
                    
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("socket-related error!" + " " + ex.Message + ex.InnerException);
            }
            catch (FormatException)
            {
                Console.WriteLine("enter an integer for server port number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("some unknown error " + ex.Message);
            }

        }
        }
    }

