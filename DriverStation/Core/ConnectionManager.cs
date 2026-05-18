using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation.Core
{
    /// <summary>
    /// Manages network connections to the robot controller via TCP sockets.
    /// </summary>
    public class ConnectionManager
    {
        private static IPEndPoint ipEndPoint;
        private static Socket clientSocket;
        private static bool isConnected = false;
        private static bool isEnabled = false;

        public delegate void MessageReceivedHandler(string message);
        public delegate void ConnectionStatusChangedHandler(bool connected);
        public delegate void EnabledStatusChangedHandler(bool enabled);

        public static event MessageReceivedHandler? MessageReceived;
        public static event ConnectionStatusChangedHandler? ConnectionStatusChanged;
        public static event EnabledStatusChangedHandler? EnabledStatusChanged;

        public ConnectionManager()
        {
            ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.4.1"), 3000);
        }

        /// <summary>
        /// Gets whether the connection is currently active.
        /// </summary>
        public static bool IsConnected => isConnected;

        /// <summary>
        /// Gets whether the robot is currently enabled.
        /// </summary>
        public static bool IsEnabled => isEnabled;

        /// <summary>
        /// Enables the robot, allowing commands to be sent.
        /// </summary>
        public static void Enable()
        {
            if (!isConnected)
            {
                throw new InvalidOperationException("Cannot enable: Not connected to robot");
            }
            isEnabled = true;
            EnabledStatusChanged?.Invoke(true);
        }

        /// <summary>
        /// Disables the robot and sends stop commands to all motors.
        /// </summary>
        public static void Disable()
        {
            isEnabled = false;
            EnabledStatusChanged?.Invoke(false);
            SendStopCommands();
        }

        /// <summary>
        /// Sends stop commands to all registered motors.
        /// </summary>
        private static void SendStopCommands()
        {
            var robot = Robot.GetRobot();
            var allMotors = robot.GetAllMotors();
            foreach (var motor in allMotors.Values)
            {
                SendCommandInternal($"{motor.MotorId}0");
            }
        }

        /// <summary>
        /// Creates and initializes the socket connection asynchronously.
        /// Connects to the ESP8266 server in SoftAP mode.
        /// </summary>
        public static async Task<Socket> CreateAsync()
        {
            try
            {
                clientSocket = new Socket(
                    ipEndPoint.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp);

                await clientSocket.ConnectAsync(ipEndPoint);
                isConnected = true;
                ConnectionStatusChanged?.Invoke(true);

                Listen();

                return clientSocket;
            }
            catch (Exception)
            {
                isConnected = false;
                ConnectionStatusChanged?.Invoke(false);
                throw;
            }
        }

        /// <summary>
        /// Sends a command string to the connected robot.
        /// Commands are only sent if the robot is enabled.
        /// </summary>
        /// <param name="command">The command string to send</param>
        public static void SendCommand(string command)
        {
            if (!isEnabled)
            {
                return;
            }
            SendCommandInternal(command);
        }

        /// <summary>
        /// Sends a command string to the connected robot without checking enabled status.
        /// Used internally for critical commands like stop.
        /// </summary>
        /// <param name="command">The command string to send</param>
        private static async void SendCommandInternal(string command)
        {
            if (clientSocket == null || !clientSocket.Connected)
            {
                return;
            }

            try
            {
                var messageBytes = Encoding.UTF8.GetBytes(command + "\n");
                await clientSocket.SendAsync(messageBytes, SocketFlags.None);
            }
            catch (Exception)
            {
                isConnected = false;
                ConnectionStatusChanged?.Invoke(false);
            }
        }

        /// <summary>
        /// Starts listening for incoming messages from the robot.
        /// </summary>
        private static async void Listen()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        if (clientSocket != null && clientSocket.Connected)
                        {
                            var buffer = new byte[1_024];
                            var received = await clientSocket.ReceiveAsync(buffer, SocketFlags.None);
                            var response = Encoding.UTF8.GetString(buffer, 0, received);
                            if (!string.IsNullOrEmpty(response))
                            {
                                MessageReceived?.Invoke(response);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        isConnected = false;
                        ConnectionStatusChanged?.Invoke(false);
                        break;
                    }
                }
            });
        }
    }
}
