using CustomDriverStation;
using SharpDX.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DriverStation.Core.FTC2025
{
    internal class DrivetrainSubsystem
    {
        private Motor frontLeftDrive = Robot.AddMotor("FLD");
        private Motor frontRightDrive = Robot.AddMotor("FRD");
        private Motor backLeftDrive = Robot.AddMotor("BLD");
        private Motor backRightDrive = Robot.AddMotor("BRD");

        private DifferentialDrive drivetrain;

        public DrivetrainSubsystem()
        {
            drivetrain = new DifferentialDrive(frontLeftDrive, frontRightDrive, backLeftDrive, backRightDrive, 1.0, 12.0);
        }

        public void Drive(double left, double right)
        {
            drivetrain.Drive(left, right);
        }
    }
}
