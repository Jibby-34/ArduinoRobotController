using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using CustomDriverStation.Core;

/// <summary>
/// Backwards compatibility wrapper for ConnectionManager.
/// Use ConnectionManager directly for new code.
/// </summary>
internal class SocketService
{
    public delegate void MessageReceivedHandler(string message);
    public static event MessageReceivedHandler? MessageReceived
    {
        add 
        { 
            if (value != null)
            {
                ConnectionManager.MessageReceived += new ConnectionManager.MessageReceivedHandler(value);
            }
        }
        remove 
        { 
            if (value != null)
            {
                ConnectionManager.MessageReceived -= new ConnectionManager.MessageReceivedHandler(value);
            }
        }
    }

    public SocketService()
    {
        new ConnectionManager();
    }

    public static async Task<Socket> CreateAsync()
    {
        return await ConnectionManager.CreateAsync();
    }

    public static void SendCommand(string command)
    {
        ConnectionManager.SendCommand(command);
    }
}
