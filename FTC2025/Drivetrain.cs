using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    internal class Drivetrain
    {
        private Motor leftMotor = new Motor("LD");
        private Motor rightMotor = new Motor("RD");

        public Drivetrain()
        {

        }

        public void DriveLeft(double leftSpeed)
        {
            leftMotor.SetSpeed(leftSpeed);
        }

        public void DriveRight(double rightSpeed)
        {
            rightMotor.SetSpeed(rightSpeed);
        }
    }
}
