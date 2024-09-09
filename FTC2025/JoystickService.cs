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
        public delegate void ButtonChangedHandler(JoystickProperties button, bool newState);
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
                while(true)
                {
                    joystick.Poll();
                    var datas = joystick.GetBufferedData();
                    var joystickState = joystick.GetCurrentState();
                    

                    if (joystickState.X > -1)
                    {
                        JoystickChanged?.Invoke(JoystickProperties.LeftJoystickX, Convert16BitToStandard(joystickState.X));
                    }
                    if (joystickState.Y > -1)
                    {
                        JoystickChanged?.Invoke(JoystickProperties.LeftJoystickY, -Convert16BitToStandard(joystickState.Y));
                    }
                    if (joystickState.Z > -1) 
                    {
                        JoystickChanged?.Invoke(JoystickProperties.RightJoystickX, Convert16BitToStandard(joystickState.Z));
                    }
                    if (joystickState.RotationZ > -1)
                    {
                        JoystickChanged?.Invoke(JoystickProperties.RightJoystickY, Convert16BitToStandard(joystickState.RotationZ));

                    }
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
