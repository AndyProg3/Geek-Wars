﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    // State object for reading client data asynchronously  
    public class StateObject
    {
        // Client  socket.  
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 1024;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
        // Received data string.  
        public StringBuilder sb = new StringBuilder();
    }

    class ServerHandler
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public static List<Socket> clients = new List<Socket>();
        public static List<String> msgs = new List<String>();

        public ServerHandler() { }

        public static void StartListening()
        {
            IPAddress ipAddress = IPAddress.Parse("10.50.74.107");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 3333);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            Console.WriteLine("Server started...");
            // Bind the socket to the local endpoint and listen for incoming connections.  
            try { 

                Console.WriteLine("Server listening...");
                listener.Bind(localEndPoint);
                listener.Listen(105);

                while (true)
                {
                    // Unlocks main threads
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.  
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Locks threads
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Server stoped.");

        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Unlock main thread 
            allDone.Set();

            // get server socket  
            Socket listener = (Socket)ar.AsyncState;

            //get client socket
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            StateObject state = new StateObject();
            state.workSocket = handler;

            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            //Add client to list for later use
            clients.Add(handler);

            // Read data from the client socket.   
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.  
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read   
                // more data.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the   
                    // client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);

                    msgs.Add(content);

                    // Echo the data back to the client.
                    Send(handler, content);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private static void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void RefreshClients()
        {
            for(int c = 0; c < clients.Count; c++)
            {
                if(clients[c].Poll(1000, SelectMode.SelectRead)
                     && clients[c].Available == 0)
                {
                    clients.RemoveAt(c);
                    c--;
                }
            }
        }

        public static void randomKillClient()
        {
            RefreshClients();

            Random rand = new Random();
            int indx = rand.Next(0, clients.Count);

            Send(clients[indx], "KILL<EOF>");
        }
    }
}
