using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC2025
{
    internal class JoystickService
    {
        public delegate void ButtonChangedHandler(JoystickProperties button, bool state);
        public delegate void JoystickChangedHandler(JoystickProperties joystick, int value);


        Joystick joystick;
        public event ButtonChangedHandler ButtonChanged;
        public event JoystickChangedHandler JoystickChanged;

        public JoystickService() 
        {
            init();
        }

        public void init()
        {
            // Initialize DirectInput
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad,
                        DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick,
                        DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                //Console.ReadKey();
                Environment.Exit(1);
            }

            // Instantiate the joystick
            joystick = new Joystick(directInput, joystickGuid);


            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

            StartPolling();
        }

        public void StartPolling()
        {
            Task.Run(() =>
            {
                //your polling loop
                int[] previousJoystickStates = new int[4] { int.MinValue, int.MinValue, int.MinValue, int.MinValue };

                while (true)
                {
                    joystick.Poll();
                    var datas = joystick.GetBufferedData();
                    var joystickState = joystick.GetCurrentState();

                    // Sticks
                    if (joystickState.X > -1 && joystickState.X != previousJoystickStates[0])
                    {
                        JoystickChanged?.Invoke(JoystickProperties.LeftJoystickX, Convert16BitToStandard(joystickState.X));
                        previousJoystickStates[0] = joystickState.X;
                    }
                    if (joystickState.Y > -1 && joystickState.Y != previousJoystickStates[1])
                    {
                        JoystickChanged?.Invoke(JoystickProperties.LeftJoystickY, -Convert16BitToStandard(joystickState.Y));
                        previousJoystickStates[1] = joystickState.Y;
                    }
                    if (joystickState.Z > -1 && joystickState.Z != previousJoystickStates[2])
                    {
                        JoystickChanged?.Invoke(JoystickProperties.RightJoystickX, Convert16BitToStandard(joystickState.Z));
                        previousJoystickStates[2] = joystickState.Z;
                    }
                    if (joystickState.RotationZ > -1 && joystickState.RotationZ != previousJoystickStates[3])
                    {
                        JoystickChanged?.Invoke(JoystickProperties.RightJoystickY, Convert16BitToStandard(joystickState.RotationZ));
                        previousJoystickStates[3] = joystickState.RotationZ;
                    }

                    // Buttons
                    ButtonChanged?.Invoke(JoystickProperties.Button1, joystickState.Buttons[0]);
                    
                    ButtonChanged?.Invoke(JoystickProperties.Button2, joystickState.Buttons[1]);
      
                    ButtonChanged?.Invoke(JoystickProperties.Button3, joystickState.Buttons[2]);
 
                    ButtonChanged?.Invoke(JoystickProperties.Button4, joystickState.Buttons[3]);
                    
                }
            });
        }

        public int Convert16BitToStandard(int value)
        {
            return (int)(((double)value / 65535) * 200 - 100);
        }
    }

    public enum JoystickProperties
    {
        Button1,
        Button2,
        Button3,
        Button4,
        Up,
        Down,
        Left,
        Right,
        LeftBumper,
        RightBumper,
        LeftTrigger,
        RightTrigger,
        LeftJoystickX,
        LeftJoystickY,
        RightJoystickX,
        RightJoystickY,
        Start,
        Select
    }
}
