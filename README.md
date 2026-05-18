# Driver Station

A general-purpose FRC/FTC-style driver station for controlling robots over WiFi.

## Features

- **Universal Motor Control**: Create motors with any ID string (e.g., "FLD", "M01", etc.)
- **Joystick Input**: Full DirectInput support for gamepads and joysticks
- **Enable/Disable Safety**: Proper enable/disable mode that actually stops signal transmission
- **Modern Dark UI**: Clean, tabbed interface inspired by the FRC Driver Station
- **Real-time Status**: Connection and joystick status indicators
- **Signal Monitoring**: View all incoming messages from the robot in real-time

## Architecture

```
DriverStation/
├── Core/
│   ├── Motor.cs              - Universal motor class with string-based IDs
│   ├── Robot.cs              - Singleton robot manager
│   └── ConnectionManager.cs  - Network communication handler
├── Input/
│   └── JoystickService.cs    - Joystick/gamepad input handling
├── UI/
│   ├── MainForm.cs           - Main application UI
│   └── MainForm.Designer.cs  - UI layout definition
└── Program.cs                - Application entry point
```

## Usage

### Creating Motors

```csharp
// Create motors with any ID
var motor = new Motor("FLD");  // Front Left Drive
motor.SetSpeedPWM(255);        // Set to full speed

// Or use the Robot singleton
Robot.GetRobot().AddMotor("M01");
Robot.GetRobot().GetMotor("M01").SetSpeed(0.5);
```

### Command Protocol

Commands are sent in the format: `{MOTOR_ID}{VALUE}`

Examples:
- `FLD255` - Set Front Left Drive to PWM 255 (full speed)
- `M01128` - Set Motor 01 to PWM 128 (half speed)
- `BS90` - Set Bucket Servo to 90 degrees

Motor IDs can be 2-4 characters long.

### Common Motor IDs

- `FLD` - Front Left Drive
- `FRD` - Front Right Drive
- `BLD` - Back Left Drive
- `BRD` - Back Right Drive
- `LM1` - Lift Motor One
- `IM1` - Intake Motor One
- `BS` - Bucket Servo (2-char servo ID)

You can define your own motor IDs as needed for your robot.

## UI Overview

### Control Tab
- **Enable Button**: Enables the robot and allows command transmission
- **Disable Button**: Disables the robot and sends stop commands to all motors
- **Connection Status**: Shows if connected to robot (Green = Connected, Red = Disconnected)
- **Joystick Status**: Shows if joystick is detected (Green = Connected, Red = Disconnected)

### Controller Tab
- **Joystick Axes**: Real-time display of all joystick axis values
- **Button States**: Shows which buttons are currently pressed

### Main Panel
- **Incoming Signals**: Large text box displaying all messages received from the robot with timestamps

## Safety Features

- **Enable/Disable Mode**: Commands are only sent when enabled
- **Connection Check**: Cannot enable without an active connection
- **Stop Commands**: Automatically sends stop commands (PWM 0) to all motors when disabled
- **Connection Monitoring**: Automatically detects connection loss and updates status

## Configuration

The default robot IP address is `192.168.5.122:3000`. To change this, modify the ConnectionManager constructor:

```csharp
public ConnectionManager()
{
    ipEndPoint = new IPEndPoint(IPAddress.Parse("YOUR.IP.HERE"), YOUR_PORT);
}
```

## Building

Requires:
- .NET 8.0 or higher
- Windows (for WinForms and DirectInput support)

Dependencies (automatically managed via NuGet):
- SharpDX.DirectInput - Joystick/gamepad input
- WebSocketSharp - Network communication
- LibUsbDotNet - USB device support

## Development

This codebase is designed to be season-agnostic and reusable year after year. To add season-specific robot code:

1. Create motors in your code using the Robot singleton
2. Map joystick inputs to motor commands in the event handlers
3. Keep robot-specific logic separate from the core driver station code

Example:
```csharp
private void HandleJoystickFunction(JoystickProperties joystick, int value)
{
    UpdateJoystickDisplay(joystick, value);
    
    // Season-specific code:
    if (joystick == JoystickProperties.LeftJoystickY)
    {
        var leftMotor = Robot.GetRobot().GetMotor("FLD");
        leftMotor?.SetSpeedPWM(Motor.ConvertStickScaleToStandard(value));
    }
}
```

## License

This project is open source. Modify and use as needed for your robotics projects.
