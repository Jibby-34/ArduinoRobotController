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
        var controller = new ControllerBindings();

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
        private static Dictionary<string, Motor> motors = new Dictionary<string, Motor>();


        controller.BindContinuousUpdate(() =>
            {
                double leftSpeed = controller.GetAxisNormalized(JoystickProperties.LeftJoystickY);
                double rightSpeed = controller.GetAxisNormalized(JoystickProperties.RightJoystickY);
                
                leftFront.SetSpeed(leftSpeed);
                leftBack.SetSpeed(leftSpeed);
                rightFront.SetSpeed(rightSpeed);
                rightBack.SetSpeed(rightSpeed);
            });
                    /// <summary>
        /// Adds a motor to the robot with the specified motor ID.
        /// </summary>
        /// <param name="motorId">The motor identifier</param>
        /// <returns>The created Motor instance</returns>
        public static Motor AddMotor(string motorId)
        {
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
