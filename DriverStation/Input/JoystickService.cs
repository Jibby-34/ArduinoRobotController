using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC2025
{
    /// <summary>
    /// Manages joystick/gamepad input using DirectInput.
    /// </summary>
    public class JoystickService
    {
        public delegate void ButtonChangedHandler(JoystickProperties button, bool state);
        public delegate void JoystickChangedHandler(JoystickProperties joystick, int value);
        public delegate void ConnectionStatusChangedHandler(bool connected);

        private Joystick joystick;
        private bool isConnected = false;

        public event ButtonChangedHandler ButtonChanged;
        public event JoystickChangedHandler JoystickChanged;
        public event ConnectionStatusChangedHandler ConnectionStatusChanged;

        /// <summary>
        /// Gets whether a joystick is currently connected.
        /// </summary>
        public bool IsConnected => isConnected;

        public JoystickService() 
        {
            init();
        }

        /// <summary>
        /// Attempts to reconnect to the joystick/controller.
        /// Useful when a controller is plugged in after the application has started.
        /// </summary>
        public void Reconnect()
        {
            isConnected = false;
            if (joystick != null)
            {
                try
                {
                    joystick.Unacquire();
                    joystick.Dispose();
                }
                catch { }
                joystick = null;
            }
            init();
        }

        private void init()
        {
            try
            {
                var directInput = new DirectInput();
                var joystickGuid = Guid.Empty;

                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad,
                            DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

                if (joystickGuid == Guid.Empty)
                    foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick,
                            DeviceEnumerationFlags.AllDevices))
                        joystickGuid = deviceInstance.InstanceGuid;

                if (joystickGuid == Guid.Empty)
                {
                    isConnected = false;
                    ConnectionStatusChanged?.Invoke(false);
                    return;
                }

                joystick = new Joystick(directInput, joystickGuid);
                var allEffects = joystick.GetEffects();
                joystick.Properties.BufferSize = 128;
                joystick.Acquire();

                isConnected = true;
                ConnectionStatusChanged?.Invoke(true);

                StartPolling();
            }
            catch (Exception)
            {
                isConnected = false;
                ConnectionStatusChanged?.Invoke(false);
            }
        }

        private void StartPolling()
        {
            Task.Run(() =>
            {
                int[] previousJoystickStates = new int[4] { int.MinValue, int.MinValue, int.MinValue, int.MinValue };

                while (isConnected)
                {
                    try
                    {
                        joystick.Poll();
                        var datas = joystick.GetBufferedData();
                        var joystickState = joystick.GetCurrentState();

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
                            JoystickChanged?.Invoke(JoystickProperties.RightJoystickX, -Convert16BitToStandard(joystickState.Z));
                            previousJoystickStates[2] = joystickState.Z;
                        }
                        if (joystickState.RotationZ > -1 && joystickState.RotationZ != previousJoystickStates[3])
                        {
                            JoystickChanged?.Invoke(JoystickProperties.RightJoystickY, Convert16BitToStandard(joystickState.RotationZ));
                            previousJoystickStates[3] = joystickState.RotationZ;
                        }

                        ButtonChanged?.Invoke(JoystickProperties.Button1, joystickState.Buttons[0]);
                        ButtonChanged?.Invoke(JoystickProperties.Button2, joystickState.Buttons[1]);
                        ButtonChanged?.Invoke(JoystickProperties.Button3, joystickState.Buttons[2]);
                        ButtonChanged?.Invoke(JoystickProperties.Button4, joystickState.Buttons[3]);
                    }
                    catch (Exception)
                    {
                        isConnected = false;
                        ConnectionStatusChanged?.Invoke(false);
                        break;
                    }
                }
            });
        }

        private int Convert16BitToStandard(int value)
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
