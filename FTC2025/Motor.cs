using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    internal class Motor
    {
        // Speed is a -1 -> 1 scale
        double speed;
        string arduinoTag;

        public Motor(string arduinoTag)
        {
            this.arduinoTag = arduinoTag;
        }

        public void SetSpeed(double speed)
        {
            this.speed = speed;
            SocketService.SendCommand(arduinoTag + speed);
        }

        public double GetSpeed()
        {
            return speed;
        }
    }
}
