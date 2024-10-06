using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    internal class Robot
    {
        DifferentialDriveSection leftSide = new DifferentialDriveSection(DrivetrainSections.LeftSide);
        DifferentialDriveSection rightSide = new DifferentialDriveSection(DrivetrainSections.RightSide);



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

        public DifferentialDriveSection GetSide(DrivetrainSections side)
        {
            if (side == DrivetrainSections.LeftSide)
            {
                return leftSide;
            } else {
                return rightSide;
            } 
        }

        public void DriveLeftSide(int speed)
        {
            leftSide.SetSpeedPWM(DifferentialDriveSection.ConvertStickScaleToStandard(speed));
        }

        public void DriveRightSide(int speed)
        {
            rightSide.SetSpeedPWM(DifferentialDriveSection.ConvertStickScaleToStandard(-speed));
        }
    }

    public enum DrivetrainSections
    {
        LeftSide,
        RightSide
    }

    public enum Motors
    {
        FrontLeftDrive,
        FrontRightDrive,
        BackLeftDrive,
        BackRightDrive
    }
}
