using SharpDX.DirectInput;
namespace FTC2025
{
    public partial class Form1 : Form
    {
        private JoystickService joystickService = new JoystickService();    
        Joystick joystick;
        bool enabled = false;

        public Form1()
        {
            InitializeComponent();
            joystickService.ButtonChanged += JoystickButtonChanged;
            joystickService.JoystickChanged += HandleJoystickFunction;
        }

        private void HandleJoystickFunction(JoystickProperties joystick, int value)
        {
            UpdateJoystickDisplay(joystick, value);
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

        private void JoystickButtonChanged(JoystickProperties button, bool newState)
        {
            throw new NotImplementedException();
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
