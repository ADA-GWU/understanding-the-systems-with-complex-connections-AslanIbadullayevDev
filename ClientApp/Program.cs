using System;
using System.ComponentModel.Design;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientApp
{
    public class Program // *** Developed by Aslan Ibadullayev ***
    {
        public static int num;
        public static List<int> ports = new List<int>(); // to store a list of ports
        public static int Main(String[] args)
        {
            RunClient(); // activating the client app.
            return 0;
        }

        public static void RunClient()
        {

            int serverTurn = 0; // used for detemining which server should respond when data entered.
            byte[]? bytes = new byte[1024];
            try
            {
#pragma warning disable CS8600
                using (TextReader reader = new StreamReader("../PortNumbers.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        ports.Add(int.Parse(line));
                    }

                    reader.Close();
                }
#pragma warning disable CS8600
                // Configuration of host, ip address of the client starts here.
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];

                Console.WriteLine("Enter number");
                while (true)
                {
                    // creating end point for server
                    IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, ports[serverTurn % ports.Count]); // server's end point.
                    Socket client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    client.Connect(remoteEndPoint); // connecting to the server with the specified ip address and port.
                    #pragma warning disable CS8602
                    string? whatToDo = Console.ReadLine();

                    bool parseOk = false;

                    if (whatToDo.Equals("stop"))
                        break;
                    else
                    parseOk = int.TryParse(whatToDo, out num);
                    #pragma warning disable CS8602
                    if (parseOk)
                    {
                        bytes = Encoding.ASCII.GetBytes(num.ToString());
                        client.Send(bytes); // sending data as bytes to the server
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
