using System;
using System.Collections.Generic;
using FTC2025;

namespace CustomDriverStation.Input
{
    /// <summary>
    /// Manages controller bindings and provides easy access to controller state.
    /// Separates robot control logic from UI logic.
    /// </summary>
    public class ControllerBindings
    {
        private readonly JoystickService joystickService;
        private readonly Dictionary<JoystickProperties, int> axisValues;
        private readonly Dictionary<JoystickProperties, bool> buttonStates;
        private readonly Dictionary<JoystickProperties, Action<int>> axisBindings;
        private readonly Dictionary<JoystickProperties, Action> buttonPressBindings;
        private readonly Dictionary<JoystickProperties, Action> buttonReleaseBindings;
        private Action continuousUpdate;

        public event Action<JoystickProperties, int> AxisChanged;
        public event Action<JoystickProperties, bool> ButtonChanged;
        public event Action<bool> ConnectionStatusChanged;

        /// <summary>
        /// Gets whether a controller is currently connected.
        /// </summary>
        public bool IsConnected => joystickService.IsConnected;

        public ControllerBindings()
        {
            joystickService = new JoystickService();
            axisValues = new Dictionary<JoystickProperties, int>();
            buttonStates = new Dictionary<JoystickProperties, bool>();
            axisBindings = new Dictionary<JoystickProperties, Action<int>>();
            buttonPressBindings = new Dictionary<JoystickProperties, Action>();
            buttonReleaseBindings = new Dictionary<JoystickProperties, Action>();

            joystickService.JoystickChanged += OnAxisChanged;
            joystickService.ButtonChanged += OnButtonChanged;
            joystickService.ConnectionStatusChanged += OnConnectionStatusChanged;

            InitializeAxisValues();
        }

        private void InitializeAxisValues()
        {
            axisValues[JoystickProperties.LeftJoystickX] = 0;
            axisValues[JoystickProperties.LeftJoystickY] = 0;
            axisValues[JoystickProperties.RightJoystickX] = 0;
            axisValues[JoystickProperties.RightJoystickY] = 0;
        }

        /// <summary>
        /// Binds a function to be called whenever an axis value changes.
        /// </summary>
        /// <param name="axis">The joystick axis to bind to</param>
        /// <param name="action">Action to execute, receives the axis value (-100 to 100)</param>
        public void BindAxis(JoystickProperties axis, Action<int> action)
        {
            axisBindings[axis] = action;
        }

        /// <summary>
        /// Binds a function to be called when a button is pressed.
        /// </summary>
        /// <param name="button">The button to bind to</param>
        /// <param name="action">Action to execute when button is pressed</param>
        public void BindButtonPress(JoystickProperties button, Action action)
        {
            buttonPressBindings[button] = action;
        }

        /// <summary>
        /// Binds a function to be called when a button is released.
        /// </summary>
        /// <param name="button">The button to bind to</param>
        /// <param name="action">Action to execute when button is released</param>
        public void BindButtonRelease(JoystickProperties button, Action action)
        {
            buttonReleaseBindings[button] = action;
        }

        /// <summary>
        /// Binds a function to be called continuously on every controller update.
        /// Useful for tank drive or arcade drive implementations.
        /// </summary>
        /// <param name="action">Action to execute on every update</param>
        public void BindContinuousUpdate(Action action)
        {
            continuousUpdate = action;
        }

        /// <summary>
        /// Gets the current value of an axis (-100 to 100).
        /// </summary>
        public int GetAxis(JoystickProperties axis)
        {
            return axisValues.ContainsKey(axis) ? axisValues[axis] : 0;
        }

        /// <summary>
        /// Gets the current value of an axis as a normalized double (-1.0 to 1.0).
        /// </summary>
        public double GetAxisNormalized(JoystickProperties axis)
        {
            return GetAxis(axis) / 100.0;
        }

        /// <summary>
        /// Gets the current state of a button.
        /// </summary>
        public bool GetButton(JoystickProperties button)
        {
            return buttonStates.ContainsKey(button) && buttonStates[button];
        }

        /// <summary>
        /// Clears all bindings.
        /// </summary>
        public void ClearBindings()
        {
            axisBindings.Clear();
            buttonPressBindings.Clear();
            buttonReleaseBindings.Clear();
            continuousUpdate = null;
        }

        /// <summary>
        /// Attempts to reconnect to the controller.
        /// </summary>
        public void Reconnect()
        {
            joystickService.Reconnect();
        }

        private void OnAxisChanged(JoystickProperties axis, int value)
        {
            axisValues[axis] = value;

            if (axisBindings.ContainsKey(axis))
            {
                axisBindings[axis]?.Invoke(value);
            }

            continuousUpdate?.Invoke();

            AxisChanged?.Invoke(axis, value);
        }

        private void OnButtonChanged(JoystickProperties button, bool state)
        {
            bool previousState = buttonStates.ContainsKey(button) && buttonStates[button];
            buttonStates[button] = state;

            if (state && !previousState)
            {
                if (buttonPressBindings.ContainsKey(button))
                {
                    buttonPressBindings[button]?.Invoke();
                }
            }
            else if (!state && previousState)
            {
                if (buttonReleaseBindings.ContainsKey(button))
                {
                    buttonReleaseBindings[button]?.Invoke();
                }
            }

            ButtonChanged?.Invoke(button, state);
        }

        private void OnConnectionStatusChanged(bool connected)
        {
            ConnectionStatusChanged?.Invoke(connected);
        }
    }
}
