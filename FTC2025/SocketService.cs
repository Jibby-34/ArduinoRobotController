using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

internal class SocketService
{
    private static IPEndPoint ipEndPoint;
    private static Socket client;

    private SocketService()
    {
        ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.5.144"), 3000);
    }

    public static async Task<SocketService> CreateAsync()
    {
        var service = new SocketService();
        await service.init();
        return service;
    }

    public static async void SendCommand(string command)
    {
        if (client == null || !client.Connected)
        {
            return;
        }

        var messageBytes = Encoding.UTF8.GetBytes(command);

        try
        {
            await client.SendAsync(messageBytes, SocketFlags.None);
        }
        catch (Exception)
        {
            // Handle exceptions if needed
        }
    }

    private async Task init()
    {
        try
        {
            client = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            await client.ConnectAsync(ipEndPoint);

            var message = "INIT";
            var messageBytes = Encoding.UTF8.GetBytes(message);

            await client.SendAsync(messageBytes, SocketFlags.None);
        }
        catch (Exception)
        {
            // Handle exceptions if needed
        }
    }

    public void Close()
    {
        if (client != null && client.Connected)
        {
            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }
    }
}
