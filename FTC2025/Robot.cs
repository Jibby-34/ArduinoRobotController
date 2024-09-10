using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    internal class Robot
    {
        Motor frontLeftDriveMotor = new Motor(DrivetrainMotors.FrontLeftDrive);
        Motor frontRightDriveMotor = new Motor(DrivetrainMotors.FrontRightDrive);
        Motor backLeftDriveMotor = new Motor(DrivetrainMotors.BackLeftDrive);
        Motor backRightDriveMotor = new Motor(DrivetrainMotors.BackRightDrive);


        private static Robot instance;

        public Robot() 
        {

        }

        public static Robot GetRobot()
        {
            if (instance == null)
            {
                instance = new Robot();
            }
            return instance;
        }

        public Motor GetMotor(DrivetrainMotors motor)
        {
            if (motor == DrivetrainMotors.FrontLeftDrive)
            {
                return frontLeftDriveMotor;
            } else if (motor == DrivetrainMotors.FrontRightDrive)
            {
                return frontRightDriveMotor;
            } else if (motor == DrivetrainMotors.BackLeftDrive)
            {
                return backLeftDriveMotor;
            } else
            {
                return backRightDriveMotor;
            }
        }

        public void DriveLeftSide(int speed)
        {
            frontLeftDriveMotor.SetSpeed(Motor.ConvertStickScaleToStandard(speed));
            backLeftDriveMotor.SetSpeed(Motor.ConvertStickScaleToStandard(speed));
        }

        public void DriveRightSide(int speed)
        {
            frontRightDriveMotor.SetSpeed(Motor.ConvertStickScaleToStandard(speed));
            backRightDriveMotor.SetSpeed(Motor.ConvertStickScaleToStandard(speed));
        }
    }

    public enum DrivetrainMotors
    {
        FrontLeftDrive,
        FrontRightDrive,
        BackLeftDrive,
        BackRightDrive
    }
}
