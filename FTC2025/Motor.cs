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
        double speed;
        double speedPWM;
        double encoderCount;
        DrivetrainMotors motor;

        public Motor(DrivetrainMotors motor)
        {
            this.motor = motor;
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
            if (motor == DrivetrainMotors.FrontLeftDrive)
            {
                SocketService.SendCommand("FLD" + speedPWM);
            } else if (motor == DrivetrainMotors.FrontRightDrive) 
            {
                SocketService.SendCommand("FRD" + speedPWM);
            } else if (motor == DrivetrainMotors.BackLeftDrive)
            {
                SocketService.SendCommand("BLD" + speedPWM);
            } else if (motor == DrivetrainMotors.BackRightDrive)
            {
                SocketService.SendCommand("BRD" + speedPWM);
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
            return ((stickValue + 100) * 1000) / 200;
        }

        // This function is called in SocketService when the program recives a 
        // string containing encoder values
        public void SetEncoderCount(double encoderCount)
        {
            this.encoderCount = encoderCount;
        }
    }
}
