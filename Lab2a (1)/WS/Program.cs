using System;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;

namespace WS
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerLaunchAsync();
            Console.ReadKey();
        }

        private static async void ServerLaunchAsync()
        {
            var httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:4000/");
            httpListener.Start();
            HttpListenerContext listenerContext = await httpListener.GetContextAsync();


            if (listenerContext.Request.IsWebSocketRequest)
            {
                Console.WriteLine("ws");
                WebSocketContext webSocketContext = await listenerContext.AcceptWebSocketAsync(null);
                WebSocket webSocket = webSocketContext.WebSocket;
                while (webSocket.State == WebSocketState.Open)
                {
                    Console.WriteLine("wsend");
                    var buffer = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
                    var segment = new ArraySegment<byte>(buffer);

                    webSocket.SendAsync(segment, WebSocketMessageType.Text, true, CancellationToken.None);

                    Thread.Sleep(2000);
                }

            }
            else
            {
                listenerContext.Response.StatusCode = 426;
                listenerContext.Response.Close();
            }
        }
    }
}
