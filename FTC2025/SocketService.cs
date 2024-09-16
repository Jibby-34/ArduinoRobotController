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

    public delegate void MessageReceivedHandler(string message);

    public event MessageReceivedHandler MessageReceived;


    public SocketService()
    {
        ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.5.122"), 3000);
    }

    public static async Task<Socket> CreateAsync()
    {
        using Socket listener = new(
            ipEndPoint.AddressFamily,
            SocketType.Stream,
            ProtocolType.Tcp);

        listener.Bind(ipEndPoint);
        listener.Listen(100);


        handler = await listener.AcceptAsync();

        return listener;
    }

    public static async void SendCommand(string command)
    {
        
    }

    public async void Listen()
    {
        await Task.Run(async () =>
        {
            var buffer = new byte[1_024];
            var received = await handler.ReceiveAsync(buffer, SocketFlags.None);
            var response = Encoding.UTF8.GetString(buffer, 0, received);
            if (response != null)
            {
                MessageReceived?.Invoke(response);
            }
        });
    }
}
