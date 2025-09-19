using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTC2025;

namespace CustomDriverStation
{
    internal class Robot
    {
        // Blank robot file: Create each subsystem in this file and use it as a utility 
        private static Robot instance;
        private Drivetrain drivetrain = new Drivetrain();

        public Robot()
        {

        }

        // BUTTON BINDINGS ARE DONE HERE
        public void ForwardJoystick(JoystickProperties joystick, int value)
        {
            // LEFT JOYSTICK Y -> LEFT DRIVE
            if (joystick == JoystickProperties.LeftJoystickY)
            {
                drivetrain.DriveLeft(value);
            }
            // RIGHT JOYSTICK Y -> RIGHT DRIVE
            else if (joystick == JoystickProperties.RightJoystickY)
            {
                drivetrain.DriveRight(value);
            }
        }

        public static Robot GetRobot()
        {
            if (instance == null)
            {
                instance = new Robot();
            }
            return instance;
        }
    }
}
