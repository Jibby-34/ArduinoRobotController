using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    internal class DifferentialDriveSection
    {
        double speed;
        double speedPWM;
        double encoderCount;
        DrivetrainSections side;

        public DifferentialDriveSection(DrivetrainSections side)
        {
            this.side = side;
        }

        public void SetSpeed(double speed)
        {
            this.speed = speed;
            speedPWM = speed * 255;
            SendSpeedCommand(speedPWM);
        }

        public void SetSpeedPWM(double speedPWM) 
        {
            this.speedPWM = speedPWM;
            speed = speedPWM / 255;
            SendSpeedCommand(speedPWM);
        }

        private void SendSpeedCommand(double speedPWM)
        {
            if (side == DrivetrainSections.LeftSide)
            {
                SocketService.SendCommand("LD" + speedPWM);
            } else {
                SocketService.SendCommand("RD" + speedPWM);
            }
        }

        public double GetSpeed()
        {
            return speed;
        }

        public double GetSpeedPWM()
        {
            return speedPWM;
        }

        public double GetEncoderValue()
        {
            return encoderCount;
        }

        public static int ConvertStickScaleToStandard(int stickValue)
        {
            // Ensure the value is within the expected range
            if (stickValue < -100)
            {
                stickValue = -100;
            }
            else if (stickValue > 100)
            {
                stickValue = 100;
            }

            // Normalize the value to a range of 0 to 1
            double normalizedValue = (stickValue + 100) / 200.0;

            // Scale the normalized value to the range of -255 to 255
            int scaledValue = (int)((normalizedValue * 510) - 255);

            return scaledValue;
        }


        // This function is called in SocketService when the program recives a 
        // string containing encoder values
        public void SetEncoderCount(double encoderCount)
        {
            this.encoderCount = encoderCount;
        }
    }
}
