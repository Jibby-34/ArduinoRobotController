using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

internal class SocketService
{
    private static IPEndPoint ipEndPoint;
    private static Socket client;

    public delegate void MessageReceivedHandler(string message);
    public static event MessageReceivedHandler? MessageReceived;

    public SocketService()
    {
        // ESP8266 SoftAP default IP is 192.168.4.1, port 3333 from Arduino sketch
        ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.4.1"), 3333);
    }

    public static async Task<Socket> ConnectAsync()
    {
        client = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        await client.ConnectAsync(ipEndPoint);
        return client;
    }

    public static async void SendCommand(string command)
    {
        if (client == null || !client.Connected)
            return;

        var messageBytes = Encoding.UTF8.GetBytes(command + "\n");
        await client.SendAsync(messageBytes, SocketFlags.None);
    }

    public static async void Listen()
    {
        await Task.Run(async () =>
        {
            var buffer = new byte[1024];
            while (true)
            {
                if (client != null && client.Connected)
                {
                    var received = await client.ReceiveAsync(buffer, SocketFlags.None);
                    if (received > 0)
                    {
                        var response = Encoding.UTF8.GetString(buffer, 0, received);
                        MessageReceived?.Invoke(response);
                    }
                }
            }
        });
    }
}
