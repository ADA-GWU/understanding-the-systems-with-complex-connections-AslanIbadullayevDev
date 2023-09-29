using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientApp
{
    public class Program // *** Developed by Aslan Ibadullayev ***
    {
        public static int num;
        public static List<int> ports = new List<int>();
        public static int Main(String[] args)
        {
            RunClient();
            return 0;
        }

        public static void UpdatePortNumbers()
        {
            using (TextReader reader = new StreamReader("../PortNumbers.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    ports.Add(int.Parse(line));
                }

                reader.Close();
            }
        }

        public static void RunClient()
        {

            int serverTurn = 0;
            byte[]? bytes = new byte[1024];
            try
            {
                using (TextReader reader = new StreamReader("../PortNumbers.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        ports.Add(int.Parse(line));
                    }

                    reader.Close();
                }

                // Configuration of host, ip address of the client starts here.
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];

   
                while (true)
                {
                    
                    IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, ports[serverTurn % ports.Count]); // server's end point.
                    Socket client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    client.Connect(remoteEndPoint);

                    bool parseOk = int.TryParse(Console.ReadLine(), out num);

                    if (parseOk)
                    {
                        bytes = Encoding.ASCII.GetBytes(num.ToString());
                        client.Send(bytes);
                    }
                    else
                    {
                        Console.WriteLine("Enter a number!");
                    }

                    if (serverTurn % ports.Count == 0)
                        serverTurn = 0;

                    serverTurn++;
                    client.Close();
                    
                    
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        }
    }
