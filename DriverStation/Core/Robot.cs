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
        private static Dictionary<string, Motor> motors = new Dictionary<string, Motor>();

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
