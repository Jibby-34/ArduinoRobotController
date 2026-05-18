using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    /// <summary>
    /// Represents a differential (tank) drive system with 4 motors (2 left, 2 right).
    /// This class provides a simple interface for controlling a robot drivetrain
    /// and stores parameters needed for future odometry and kinematics calculations.
    /// </summary>
    public class DifferentialDrive
    {
        private readonly Motor leftMotor1;
        private readonly Motor leftMotor2;
        private readonly Motor rightMotor1;
        private readonly Motor rightMotor2;
        private readonly double gearRatio;
        private readonly double trackWidth;

        /// <summary>
        /// Creates a new DifferentialDrive instance.
        /// </summary>
        /// <param name="leftMotor1">First left side motor (e.g., front left)</param>
        /// <param name="leftMotor2">Second left side motor (e.g., back left)</param>
        /// <param name="rightMotor1">First right side motor (e.g., front right)</param>
        /// <param name="rightMotor2">Second right side motor (e.g., back right)</param>
        /// <param name="gearRatio">Shaft-to-wheel gear ratio (for future odometry calculations)</param>
        /// <param name="trackWidth">Distance between left and right wheel centers (in inches or meters)</param>
        public DifferentialDrive(
            Motor leftMotor1, 
            Motor leftMotor2, 
            Motor rightMotor1, 
            Motor rightMotor2, 
            double gearRatio, 
            double trackWidth)
        {
            this.leftMotor1 = leftMotor1;
            this.leftMotor2 = leftMotor2;
            this.rightMotor1 = rightMotor1;
            this.rightMotor2 = rightMotor2;
            this.gearRatio = gearRatio;
            this.trackWidth = trackWidth;
        }

        /// <summary>
        /// Drives the robot using tank drive controls.
        /// </summary>
        /// <param name="leftSpeed">Speed for left side motors, range -1.0 (full reverse) to 1.0 (full forward)</param>
        /// <param name="rightSpeed">Speed for right side motors, range -1.0 (full reverse) to 1.0 (full forward)</param>
        public void Drive(double leftSpeed, double rightSpeed)
        {
            leftMotor1.SetSpeed(leftSpeed);
            leftMotor2.SetSpeed(leftSpeed);
            rightMotor1.SetSpeed(rightSpeed);
            rightMotor2.SetSpeed(rightSpeed);
        }

        /// <summary>
        /// Gets the gear ratio (shaft-to-wheel).
        /// </summary>
        public double GearRatio => gearRatio;

        /// <summary>
        /// Gets the track width (distance between left and right wheel centers).
        /// </summary>
        public double TrackWidth => trackWidth;
    }
}
