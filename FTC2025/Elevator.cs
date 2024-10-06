using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    internal class Elevator
    {
        LiftDirections direction;
        double encoderCount;

        // Convert direction into int and send the command
        public void SetDirection(LiftDirections direction)
        {
            this.direction = direction;
            if (direction == LiftDirections.Up)
            {
                SendSpeedCommand(1);
            } else if (direction == LiftDirections.Down)
            {
                SendSpeedCommand(0);
            } else if (direction == LiftDirections.Stop)
            {
                SendSpeedCommand(9);
            }
        }

        /** Direction of up = 1, down = 0, and stop = 9**/
        private void SendSpeedCommand(int direction)
        {
           SocketService.SendCommand("LM" + direction);
        }

        public LiftDirections GetDirection()
        {
            return direction;
        }

        public double GetEncoderValue()
        {
            return encoderCount;
        }

        // This function is called in SocketService when the program recives a 
        // string containing encoder values
        public void SetEncoderCount(double encoderCount)
        {
            this.encoderCount = encoderCount;
        }
    }

    public enum LiftDirections
    {
        Up,
        Down,
        Stop
    }
}
