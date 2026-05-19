using CustomDriverStation.Input;
using DriverStation.Core.FTC2025;
using FTC2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDriverStation
{
    /// <summary>
    /// Static class representing the robot. 
    /// This serves as a base structure for season-specific robot implementations.
    /// Users can extend this class or add motors/components as needed for their robot.
    /// </summary>
    public static class Robot
    {
        // All present motors (must be initialized before subsystems that use it)
        private static Dictionary<string, Motor> motors = new Dictionary<string, Motor>();

        // Subsystems
        private static DrivetrainSubsystem drivetrain = new DrivetrainSubsystem();

        // Controller
        private static ControllerBindings controller = new ControllerBindings();

        // BUTTON BINDINGS EXAMPLE
        // var controller = new ControllerBindings();

        // Motor intakeMotor = Robot.AddMotor("IM");

        // // Run intake when button 1 is pressed
        // controller.BindButtonPress(JoystickProperties.Button1, () =>
        // {
        //     intakeMotor.SetSpeed(1.0);
        // });

        // // Stop intake when button 1 is released
        // controller.BindButtonRelease(JoystickProperties.Button1, () =>
        // {
        //     intakeMotor.SetSpeed(0.0);
        // });

        // // Toggle something on button 2 press
        // bool isReversed = false;
        // controller.BindButtonPress(JoystickProperties.Button2, () =>
        // {
        //     isReversed = !isReversed;
        //     intakeMotor.SetSpeed(isReversed ? -0.5 : 0.5);
        // });

        public static void SetupController()
        {
            controller.BindContinuousUpdate(() =>
            {
                double left = controller.GetAxisNormalized(JoystickProperties.LeftJoystickY);
                double right = controller.GetAxisNormalized(JoystickProperties.RightJoystickY);

                drivetrain.Drive(left, right);
            });
        }

        /// <summary>
        /// Adds a motor to the robot with the specified motor ID.
        /// </summary>
        /// <param name="motorId">The motor identifier</param>
        /// <returns>The created Motor instance</returns>
        public static Motor AddMotor(string motorId)
        {
            if (string.IsNullOrEmpty(motorId))
            {
                throw new ArgumentException("Motor ID cannot be null or empty.", nameof(motorId));
            }

            if (!motors.ContainsKey(motorId))
            {
                motors[motorId] = new Motor(motorId);
            }
            return motors[motorId];
        }

        /// <summary>
        /// Gets a motor by its ID.
        /// </summary>
        /// <param name="motorId">The motor identifier</param>
        /// <returns>The Motor instance, or null if not found</returns>
        public static Motor GetMotor(string motorId)
        {
            return motors.ContainsKey(motorId) ? motors[motorId] : null;
        }

        /// <summary>
        /// Gets all registered motors.
        /// </summary>
        public static IReadOnlyDictionary<string, Motor> GetAllMotors()
        {
            return motors;
        }
    }
}
