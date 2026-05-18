using CustomDriverStation;
using CustomDriverStation.Core;
using SharpDX.DirectInput;
using FTC2025;

namespace CustomDriverStation.UI
{
    public partial class MainForm : Form
    {
        private JoystickService joystickService = new JoystickService();
        private SocketService socketService = new SocketService();
        private bool enabled = false;

        public MainForm()
        {
            InitializeComponent();
            joystickService.ButtonChanged += HandleButtonFunction;
            joystickService.JoystickChanged += HandleJoystickFunction;
            joystickService.ConnectionStatusChanged += HandleJoystickConnectionChanged;
            SocketService.MessageReceived += HandleMessage;
            ConnectionManager.ConnectionStatusChanged += HandleConnectionStatusChanged;
            this.Load += async (sender, e) => await InitializeSocketServiceAsync();
            
            UpdateConnectionStatus(false);
            UpdateJoystickStatus(joystickService.IsConnected);
            UpdateEnableDisableButtons();
            
            AppendStatusMessage("Driver Station initialized");
            AppendStatusMessage("Robot is DISABLED by default");
        }

        private async Task InitializeSocketServiceAsync()
        {
            try
            {
                var socketService = await SocketService.CreateAsync();
            }
            catch (Exception ex)
            {
                AppendStatusMessage($"Connection failed: {ex.Message}");
            }
        }

        private void HandleJoystickFunction(JoystickProperties joystick, int value)
        {
            UpdateJoystickDisplay(joystick, value);
        }

        private void HandleMessage(string response)
        {
            AppendStatusMessage($"Received: {response}");
        }

        private void HandleConnectionStatusChanged(bool connected)
        {
            UpdateConnectionStatus(connected);
        }

        private void HandleJoystickConnectionChanged(bool connected)
        {
            UpdateJoystickStatus(connected);
        }

        private void UpdateConnectionStatus(bool connected)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateConnectionStatus(connected)));
                return;
            }

            connectionStatusIndicator.BackColor = connected 
                ? System.Drawing.Color.FromArgb(40, 167, 69) 
                : System.Drawing.Color.FromArgb(220, 53, 69);
        }

        private void UpdateJoystickStatus(bool connected)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateJoystickStatus(connected)));
                return;
            }

            joystickStatusIndicator.BackColor = connected 
                ? System.Drawing.Color.FromArgb(40, 167, 69) 
                : System.Drawing.Color.FromArgb(220, 53, 69);
        }

        private void UpdateJoystickDisplay(JoystickProperties joystick, int value)
        {
            if (joystick == JoystickProperties.LeftJoystickX)
            {
                UpdateLabel(leftJoystickXValue, value.ToString());
            }
            else if (joystick == JoystickProperties.LeftJoystickY)
            {
                UpdateLabel(leftJoystickYValue, value.ToString());
            }
            else if (joystick == JoystickProperties.RightJoystickX)
            {
                UpdateLabel(rightJoystickXValue, value.ToString());
            }
            else if (joystick == JoystickProperties.RightJoystickY)
            {
                UpdateLabel(rightJoystickYValue, value.ToString());
            }
        }

        private void UpdateButtonDisplay(JoystickProperties button, bool value)
        {
            string displayValue = value ? "Pressed" : "Released";
            System.Drawing.Color displayColor = value 
                ? System.Drawing.Color.FromArgb(40, 167, 69) 
                : System.Drawing.Color.White;

            if (button == JoystickProperties.Button1)
            {
                UpdateLabelWithColor(button1Value, displayValue, displayColor);
            }
            else if (button == JoystickProperties.Button2)
            {
                UpdateLabelWithColor(button2Value, displayValue, displayColor);
            }
            else if (button == JoystickProperties.Button3)
            {
                UpdateLabelWithColor(button3Value, displayValue, displayColor);
            }
            else if (button == JoystickProperties.Button4)
            {
                UpdateLabelWithColor(button4Value, displayValue, displayColor);
            }
        }

        private void AppendStatusMessage(string message)
        {
            if (statusBox.InvokeRequired)
            {
                statusBox.Invoke(new Action(() => AppendStatusMessage(message)));
                return;
            }

            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            statusBox.AppendText($"[{timestamp}] {message}{Environment.NewLine}");
            
            statusBox.SelectionStart = statusBox.Text.Length;
            statusBox.ScrollToCaret();
        }

        private void UpdateLabel(System.Windows.Forms.Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => UpdateLabel(label, text)));
                return;
            }
            label.Text = text;
        }

        private void UpdateLabelWithColor(System.Windows.Forms.Label label, string text, System.Drawing.Color color)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => UpdateLabelWithColor(label, text, color)));
                return;
            }
            label.Text = text;
            label.ForeColor = color;
        }

        private void HandleButtonFunction(JoystickProperties button, bool state)
        {
            UpdateButtonDisplay(button, state);
        }

        private void enable_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConnectionManager.IsConnected)
                {
                    AppendStatusMessage("Cannot enable: Not connected to robot");
                    return;
                }

                ConnectionManager.Enable();
                enabled = true;
                UpdateEnableDisableButtons();
                AppendStatusMessage("Robot ENABLED");
            }
            catch (Exception ex)
            {
                AppendStatusMessage($"Failed to enable: {ex.Message}");
            }
        }

        private void disable_Click(object sender, EventArgs e)
        {
            ConnectionManager.Disable();
            enabled = false;
            UpdateEnableDisableButtons();
            AppendStatusMessage("Robot DISABLED - Stop commands sent");
        }

        private void UpdateEnableDisableButtons()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateEnableDisableButtons));
                return;
            }

            if (enabled)
            {
                enableButton.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
                disableButton.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            }
            else
            {
                enableButton.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
                disableButton.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            }
        }

        private void reloadController_Click(object sender, EventArgs e)
        {
            AppendStatusMessage("Attempting to reconnect controller...");
            joystickService.Reconnect();
            if (joystickService.IsConnected)
            {
                AppendStatusMessage("Controller reconnected successfully");
            }
            else
            {
                AppendStatusMessage("Controller not found. Please check connection.");
            }
        }
    }
}
