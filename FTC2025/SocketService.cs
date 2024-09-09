using System;
using System.Collections.Generic;
using System.Linq;
using WebSocketSharp;
using System.Text;
using System.Threading.Tasks;
using FTC2025;

namespace CustomDriverStation
{
    internal class SocketService
    {
        private static WebSocket ws;
        private static SocketService instance;
        public SocketService() 
        {
            init();
        }

        public void init()
        {
            using (var ws = new WebSocket("ws://your_ESP32_IP:81"))
            {
                ws.OnMessage += (sender, e) =>
                {
                    ProcessMessage(e.Data);
                };

                ws.Connect();
                ws.Send("INIT");
                Console.ReadKey(true);
            }
        }

        public static void SendCommand(string command)
        {
            ws.Send(command);
        }

        public static SocketService GetSocketService()
        {
            if (instance == null)
            {
                instance = new SocketService();
            }
            return instance;
        }

        public void ProcessMessage(string command)
        {
            // Should be lift motor, fldrive used as placeholder
            if (command.StartsWith("LME")) 
            {
                Robot.GetRobot().GetMotor(DrivetrainMotors.FrontLeftDrive).SetEncoderCount(int.Parse(command.Substring(3)));
            }
        }

    }
}
