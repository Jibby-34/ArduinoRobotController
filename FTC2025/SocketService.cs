using FTC2025;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static FTC2025.JoystickService;

internal class SocketService
{
    private static IPEndPoint ipEndPoint;
    private static Socket handler;
    private static Socket listener;

    public delegate void MessageReceivedHandler(string message);

    public static event MessageReceivedHandler? MessageReceived;


    public SocketService()
    {
        ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.5.122"), 3000);
    }

    public static async Task<Socket> CreateAsync()
    {
        listener = new Socket(
            ipEndPoint.AddressFamily,
            SocketType.Stream,
            ProtocolType.Tcp);

        listener.Bind(ipEndPoint);
        listener.Listen(100);


        handler = await listener.AcceptAsync();

        Listen();

        return listener;
    }

    public static async void SendCommand(string command)
    {
        if (handler == null || !handler.Connected)
        {
            return;
        }

        var messageBytes = Encoding.UTF8.GetBytes(command + "\n");
        await handler.SendAsync(messageBytes, SocketFlags.None);
    }


    public static async void Listen()
    {
        await Task.Run(async () =>
        {
            while (true)
            {
                if (listener != null)
                {
                    var buffer = new byte[1_024];
                    var received = await handler.ReceiveAsync(buffer, SocketFlags.None);
                    var response = Encoding.UTF8.GetString(buffer, 0, received);
                    if (response != null)
                    {
                        SendCommand("Message Received");
                        MessageReceived?.Invoke(response);
                    }
                }
            }
        });
    }
}
