using CustomDriverStation;
using SharpDX.DirectInput;
namespace FTC2025
{
    public partial class Form1 : Form
    {
        private JoystickService joystickService = new JoystickService();
        private SocketService socketService = new SocketService();
        Joystick joystick;
        bool enabled = false;

        public Form1()
        {
            InitializeComponent();
            joystickService.ButtonChanged += JoystickButtonChanged;
            joystickService.JoystickChanged += HandleJoystickFunction;
            SocketService.MessageReceived += HandleMessage;
            this.Load += async (sender, e) => await InitializeSocketServiceAsync();
        }

        private async Task InitializeSocketServiceAsync()
        {
            var socketService = await SocketService.CreateAsync();
        }


        private void HandleJoystickFunction(JoystickProperties joystick, int value)
        {
            UpdateJoystickDisplay(joystick, value);
            if (joystick == JoystickProperties.LeftJoystickY)
            {
                Robot.GetRobot().DriveLeftSide(value);
            }
            if (joystick == JoystickProperties.RightJoystickY)  
            {
                Robot.GetRobot().DriveRightSide(value);
            }
        }

        private void HandleMessage(string response)
        {
            UpdateTextBox(statusBox, "Message received: " + response);
        }

        private void UpdateJoystickDisplay(JoystickProperties joystick, int value)
        {
            if (joystick == JoystickProperties.LeftJoystickX)
            {
                UpdateLabel(LeftJoystickXValue, value.ToString());
            }
            else if (joystick == JoystickProperties.LeftJoystickY)
            {
                UpdateLabel(LeftJoystickYValue, value.ToString());
            }
            else if (joystick == JoystickProperties.RightJoystickX)
            {
                UpdateLabel(RightJoystickXValue, value.ToString());
            }
            else if (joystick == JoystickProperties.RightJoystickY)
            {
                UpdateLabel(RightJoystickYValue, value.ToString());
            }
        }

        private void UpdateButtonDisplay(JoystickProperties button, bool value)
        {
            if (button == JoystickProperties.Button1)
            {
                UpdateLabel(ButtonOneValue, value.ToString());
            }
            if (button == JoystickProperties.Button2)
            {
                UpdateLabel(ButtonTwoValue, value.ToString());
            }
            if (button == JoystickProperties.Button3)
            {
                UpdateLabel(ButtonThreeValue, value.ToString());
            }
            if (button == JoystickProperties.Button4)
            {
                UpdateLabel(ButtonFourValue, value.ToString());
            }
        }

        private void UpdateTextBox(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() => { textBox.Text = text; }));
            }
            else
            {
                textBox.Text = text;
            }
        }

        public void UpdateLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => { label.Text = text; }));
            }
        }

        private void JoystickButtonChanged(JoystickProperties button, bool state)
        {
            UpdateButtonDisplay(button, state);
        }

        private void enable_Click(object sender, EventArgs e)
        {
            enabled = true;
        }

        private void disable_Click(object sender, EventArgs e)
        {
            enabled = false;
        }
    }
}
