using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Collections.Generic;

namespace GeekWars
{
    // State object for receiving data from remote device.  
    public class StateObject
    {
        // Client socket.  
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 256;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
        // Received data string.  
        public StringBuilder sb = new StringBuilder();
    }

    public class ClientHandler
    {
        public static Socket client;
        private static readonly object clientLock = new object();

        public static void StartClient()
        {
            // Connect to a remote device.  
            try
            {
                IPAddress ipAddress = IPAddress.Parse("10.50.74.107");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 3333);

                // Create a TCP/IP socket.  
                client = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    client.Connect(remoteEP);
                }
                catch (ArgumentNullException ae)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ae.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

                // Send test data to the remote device.  
                Send("1+", true);

                Thread th = new Thread(new ThreadStart(KeepAlive));
                th.IsBackground = true;
                th.Start();

                // Release the socket.  
                /*client.Shutdown(SocketShutdown.Both);
                client.Close();*/

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(string str, bool firstResponse = false)
        {
            lock (clientLock)
            {
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(str);
                int bytesSent = client.Send(msg);
            }

            Recieve(firstResponse);
        }

        private static void Recieve(bool firstResponse = false)
        {
            byte[] bytes = new byte[1024];
            int bytesRec;

            lock (clientLock)
            {
                 bytesRec = client.Receive(bytes);
            }

            String str = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRec);

            if(firstResponse)
            {
                str = str.Replace("+", "");

                string[] x = str.Split(';');

                for(int c = 0; c < x.Length; c++)
                {
                    double res = 0;
                    if(double.TryParse(x[c], out res))
                    {
                        Form1.values.Add(res);
                    }
                }

                Form1.ValuesSent = true;
            }

            if(str == "5+")
            {
                Console.WriteLine("Trigger Kill");
                Form1.killed = true; ;
            }
        }

        public static void SendAttack(double amount)
        {
            Send(amount + "+");
        }

        public static void KeepAlive()
        {
            try
            {
                while (true)
                {
                    Send("2+");

                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
