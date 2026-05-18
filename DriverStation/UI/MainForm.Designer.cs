namespace CustomDriverStation.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.controlTab = new System.Windows.Forms.TabPage();
            this.disableButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.joystickStatusLabel = new System.Windows.Forms.Label();
            this.joystickStatusIndicator = new System.Windows.Forms.Panel();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.connectionStatusIndicator = new System.Windows.Forms.Panel();
            this.controllerTab = new System.Windows.Forms.TabPage();
            this.controllerPanel = new System.Windows.Forms.Panel();
            this.reloadControllerButton = new System.Windows.Forms.Button();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.button4Value = new System.Windows.Forms.Label();
            this.button3Value = new System.Windows.Forms.Label();
            this.button2Value = new System.Windows.Forms.Label();
            this.button1Value = new System.Windows.Forms.Label();
            this.button4Label = new System.Windows.Forms.Label();
            this.button3Label = new System.Windows.Forms.Label();
            this.button2Label = new System.Windows.Forms.Label();
            this.button1Label = new System.Windows.Forms.Label();
            this.joystickGroupBox = new System.Windows.Forms.GroupBox();
            this.rightJoystickYValue = new System.Windows.Forms.Label();
            this.rightJoystickXValue = new System.Windows.Forms.Label();
            this.leftJoystickYValue = new System.Windows.Forms.Label();
            this.leftJoystickXValue = new System.Windows.Forms.Label();
            this.rightJoystickYLabel = new System.Windows.Forms.Label();
            this.rightJoystickXLabel = new System.Windows.Forms.Label();
            this.leftJoystickYLabel = new System.Windows.Forms.Label();
            this.leftJoystickXLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.incomingSignalsLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.controlTab.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.controllerTab.SuspendLayout();
            this.controllerPanel.SuspendLayout();
            this.buttonGroupBox.SuspendLayout();
            this.joystickGroupBox.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.leftPanel.Controls.Add(this.mainTabControl);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.Size = new System.Drawing.Size(350, 750);
            this.leftPanel.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.controlTab);
            this.mainTabControl.Controls.Add(this.controllerTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainTabControl.Location = new System.Drawing.Point(10, 10);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(330, 730);
            this.mainTabControl.TabIndex = 0;
            // 
            // controlTab
            // 
            this.controlTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.controlTab.Controls.Add(this.disableButton);
            this.controlTab.Controls.Add(this.enableButton);
            this.controlTab.Controls.Add(this.statusPanel);
            this.controlTab.Location = new System.Drawing.Point(4, 32);
            this.controlTab.Name = "controlTab";
            this.controlTab.Padding = new System.Windows.Forms.Padding(10);
            this.controlTab.Size = new System.Drawing.Size(322, 694);
            this.controlTab.TabIndex = 0;
            this.controlTab.Text = "Control";
            // 
            // disableButton
            // 
            this.disableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.disableButton.FlatAppearance.BorderSize = 0;
            this.disableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.disableButton.ForeColor = System.Drawing.Color.White;
            this.disableButton.Location = new System.Drawing.Point(10, 100);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(300, 60);
            this.disableButton.TabIndex = 2;
            this.disableButton.Text = "DISABLE";
            this.disableButton.UseVisualStyleBackColor = false;
            this.disableButton.Click += new System.EventHandler(this.disable_Click);
            // 
            // enableButton
            // 
            this.enableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.enableButton.FlatAppearance.BorderSize = 0;
            this.enableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.enableButton.ForeColor = System.Drawing.Color.White;
            this.enableButton.Location = new System.Drawing.Point(10, 20);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(300, 60);
            this.enableButton.TabIndex = 1;
            this.enableButton.Text = "ENABLE";
            this.enableButton.UseVisualStyleBackColor = false;
            this.enableButton.Click += new System.EventHandler(this.enable_Click);
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.joystickStatusLabel);
            this.statusPanel.Controls.Add(this.joystickStatusIndicator);
            this.statusPanel.Controls.Add(this.connectionStatusLabel);
            this.statusPanel.Controls.Add(this.connectionStatusIndicator);
            this.statusPanel.Location = new System.Drawing.Point(10, 200);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(300, 150);
            this.statusPanel.TabIndex = 0;
            // 
            // joystickStatusLabel
            // 
            this.joystickStatusLabel.AutoSize = true;
            this.joystickStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.joystickStatusLabel.ForeColor = System.Drawing.Color.White;
            this.joystickStatusLabel.Location = new System.Drawing.Point(50, 80);
            this.joystickStatusLabel.Name = "joystickStatusLabel";
            this.joystickStatusLabel.Size = new System.Drawing.Size(78, 25);
            this.joystickStatusLabel.TabIndex = 3;
            this.joystickStatusLabel.Text = "Joystick";
            // 
            // joystickStatusIndicator
            // 
            this.joystickStatusIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.joystickStatusIndicator.Location = new System.Drawing.Point(10, 75);
            this.joystickStatusIndicator.Name = "joystickStatusIndicator";
            this.joystickStatusIndicator.Size = new System.Drawing.Size(30, 30);
            this.joystickStatusIndicator.TabIndex = 2;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.connectionStatusLabel.ForeColor = System.Drawing.Color.White;
            this.connectionStatusLabel.Location = new System.Drawing.Point(50, 20);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(108, 25);
            this.connectionStatusLabel.TabIndex = 1;
            this.connectionStatusLabel.Text = "Connection";
            // 
            // connectionStatusIndicator
            // 
            this.connectionStatusIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.connectionStatusIndicator.Location = new System.Drawing.Point(10, 15);
            this.connectionStatusIndicator.Name = "connectionStatusIndicator";
            this.connectionStatusIndicator.Size = new System.Drawing.Size(30, 30);
            this.connectionStatusIndicator.TabIndex = 0;
            // 
            // controllerTab
            // 
            this.controllerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.controllerTab.Controls.Add(this.controllerPanel);
            this.controllerTab.Location = new System.Drawing.Point(4, 32);
            this.controllerTab.Name = "controllerTab";
            this.controllerTab.Padding = new System.Windows.Forms.Padding(10);
            this.controllerTab.Size = new System.Drawing.Size(322, 694);
            this.controllerTab.TabIndex = 1;
            this.controllerTab.Text = "Controller";
            // 
            // controllerPanel
            // 
            this.controllerPanel.AutoScroll = true;
            this.controllerPanel.Controls.Add(this.reloadControllerButton);
            this.controllerPanel.Controls.Add(this.buttonGroupBox);
            this.controllerPanel.Controls.Add(this.joystickGroupBox);
            this.controllerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerPanel.Location = new System.Drawing.Point(10, 10);
            this.controllerPanel.Name = "controllerPanel";
            this.controllerPanel.Size = new System.Drawing.Size(302, 674);
            this.controllerPanel.TabIndex = 0;
            // 
            // reloadControllerButton
            // 
            this.reloadControllerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.reloadControllerButton.FlatAppearance.BorderSize = 0;
            this.reloadControllerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadControllerButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reloadControllerButton.ForeColor = System.Drawing.Color.White;
            this.reloadControllerButton.Location = new System.Drawing.Point(10, 420);
            this.reloadControllerButton.Name = "reloadControllerButton";
            this.reloadControllerButton.Size = new System.Drawing.Size(280, 45);
            this.reloadControllerButton.TabIndex = 2;
            this.reloadControllerButton.Text = "Reload Controller";
            this.reloadControllerButton.UseVisualStyleBackColor = false;
            this.reloadControllerButton.Click += new System.EventHandler(this.reloadController_Click);
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.button4Value);
            this.buttonGroupBox.Controls.Add(this.button3Value);
            this.buttonGroupBox.Controls.Add(this.button2Value);
            this.buttonGroupBox.Controls.Add(this.button1Value);
            this.buttonGroupBox.Controls.Add(this.button4Label);
            this.buttonGroupBox.Controls.Add(this.button3Label);
            this.buttonGroupBox.Controls.Add(this.button2Label);
            this.buttonGroupBox.Controls.Add(this.button1Label);
            this.buttonGroupBox.ForeColor = System.Drawing.Color.White;
            this.buttonGroupBox.Location = new System.Drawing.Point(10, 220);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(280, 180);
            this.buttonGroupBox.TabIndex = 1;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "Buttons";
            // 
            // button4Value
            // 
            this.button4Value.AutoSize = true;
            this.button4Value.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button4Value.Location = new System.Drawing.Point(150, 130);
            this.button4Value.Name = "button4Value";
            this.button4Value.Size = new System.Drawing.Size(49, 23);
            this.button4Value.TabIndex = 7;
            this.button4Value.Text = "False";
            // 
            // button3Value
            // 
            this.button3Value.AutoSize = true;
            this.button3Value.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button3Value.Location = new System.Drawing.Point(150, 95);
            this.button3Value.Name = "button3Value";
            this.button3Value.Size = new System.Drawing.Size(49, 23);
            this.button3Value.TabIndex = 6;
            this.button3Value.Text = "False";
            // 
            // button2Value
            // 
            this.button2Value.AutoSize = true;
            this.button2Value.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2Value.Location = new System.Drawing.Point(150, 60);
            this.button2Value.Name = "button2Value";
            this.button2Value.Size = new System.Drawing.Size(49, 23);
            this.button2Value.TabIndex = 5;
            this.button2Value.Text = "False";
            // 
            // button1Value
            // 
            this.button1Value.AutoSize = true;
            this.button1Value.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1Value.Location = new System.Drawing.Point(150, 25);
            this.button1Value.Name = "button1Value";
            this.button1Value.Size = new System.Drawing.Size(49, 23);
            this.button1Value.TabIndex = 4;
            this.button1Value.Text = "False";
            // 
            // button4Label
            // 
            this.button4Label.AutoSize = true;
            this.button4Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button4Label.Location = new System.Drawing.Point(20, 130);
            this.button4Label.Name = "button4Label";
            this.button4Label.Size = new System.Drawing.Size(79, 23);
            this.button4Label.TabIndex = 3;
            this.button4Label.Text = "Button 4:";
            // 
            // button3Label
            // 
            this.button3Label.AutoSize = true;
            this.button3Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button3Label.Location = new System.Drawing.Point(20, 95);
            this.button3Label.Name = "button3Label";
            this.button3Label.Size = new System.Drawing.Size(79, 23);
            this.button3Label.TabIndex = 2;
            this.button3Label.Text = "Button 3:";
            // 
            // button2Label
            // 
            this.button2Label.AutoSize = true;
            this.button2Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2Label.Location = new System.Drawing.Point(20, 60);
            this.button2Label.Name = "button2Label";
            this.button2Label.Size = new System.Drawing.Size(79, 23);
            this.button2Label.TabIndex = 1;
            this.button2Label.Text = "Button 2:";
            // 
            // button1Label
            // 
            this.button1Label.AutoSize = true;
            this.button1Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1Label.Location = new System.Drawing.Point(20, 25);
            this.button1Label.Name = "button1Label";
            this.button1Label.Size = new System.Drawing.Size(79, 23);
            this.button1Label.TabIndex = 0;
            this.button1Label.Text = "Button 1:";
            // 
            // joystickGroupBox
            // 
            this.joystickGroupBox.Controls.Add(this.rightJoystickYValue);
            this.joystickGroupBox.Controls.Add(this.rightJoystickXValue);
            this.joystickGroupBox.Controls.Add(this.leftJoystickYValue);
            this.joystickGroupBox.Controls.Add(this.leftJoystickXValue);
            this.joystickGroupBox.Controls.Add(this.rightJoystickYLabel);
            this.joystickGroupBox.Controls.Add(this.rightJoystickXLabel);
            this.joystickGroupBox.Controls.Add(this.leftJoystickYLabel);
            this.joystickGroupBox.Controls.Add(this.leftJoystickXLabel);
            this.joystickGroupBox.ForeColor = System.Drawing.Color.White;
            this.joystickGroupBox.Location = new System.Drawing.Point(10, 10);
            this.joystickGroupBox.Name = "joystickGroupBox";
            this.joystickGroupBox.Size = new System.Drawing.Size(280, 200);
            this.joystickGroupBox.TabIndex = 0;
            this.joystickGroupBox.TabStop = false;
            this.joystickGroupBox.Text = "Joystick Axes";
            // 
            // rightJoystickYValue
            // 
            this.rightJoystickYValue.AutoSize = true;
            this.rightJoystickYValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rightJoystickYValue.Location = new System.Drawing.Point(200, 150);
            this.rightJoystickYValue.Name = "rightJoystickYValue";
            this.rightJoystickYValue.Size = new System.Drawing.Size(19, 23);
            this.rightJoystickYValue.TabIndex = 7;
            this.rightJoystickYValue.Text = "0";
            // 
            // rightJoystickXValue
            // 
            this.rightJoystickXValue.AutoSize = true;
            this.rightJoystickXValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rightJoystickXValue.Location = new System.Drawing.Point(200, 110);
            this.rightJoystickXValue.Name = "rightJoystickXValue";
            this.rightJoystickXValue.Size = new System.Drawing.Size(19, 23);
            this.rightJoystickXValue.TabIndex = 6;
            this.rightJoystickXValue.Text = "0";
            // 
            // leftJoystickYValue
            // 
            this.leftJoystickYValue.AutoSize = true;
            this.leftJoystickYValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leftJoystickYValue.Location = new System.Drawing.Point(200, 70);
            this.leftJoystickYValue.Name = "leftJoystickYValue";
            this.leftJoystickYValue.Size = new System.Drawing.Size(19, 23);
            this.leftJoystickYValue.TabIndex = 5;
            this.leftJoystickYValue.Text = "0";
            // 
            // leftJoystickXValue
            // 
            this.leftJoystickXValue.AutoSize = true;
            this.leftJoystickXValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leftJoystickXValue.Location = new System.Drawing.Point(200, 30);
            this.leftJoystickXValue.Name = "leftJoystickXValue";
            this.leftJoystickXValue.Size = new System.Drawing.Size(19, 23);
            this.leftJoystickXValue.TabIndex = 4;
            this.leftJoystickXValue.Text = "0";
            // 
            // rightJoystickYLabel
            // 
            this.rightJoystickYLabel.AutoSize = true;
            this.rightJoystickYLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rightJoystickYLabel.Location = new System.Drawing.Point(20, 150);
            this.rightJoystickYLabel.Name = "rightJoystickYLabel";
            this.rightJoystickYLabel.Size = new System.Drawing.Size(131, 23);
            this.rightJoystickYLabel.TabIndex = 3;
            this.rightJoystickYLabel.Text = "Right Joystick Y:";
            // 
            // rightJoystickXLabel
            // 
            this.rightJoystickXLabel.AutoSize = true;
            this.rightJoystickXLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rightJoystickXLabel.Location = new System.Drawing.Point(20, 110);
            this.rightJoystickXLabel.Name = "rightJoystickXLabel";
            this.rightJoystickXLabel.Size = new System.Drawing.Size(132, 23);
            this.rightJoystickXLabel.TabIndex = 2;
            this.rightJoystickXLabel.Text = "Right Joystick X:";
            // 
            // leftJoystickYLabel
            // 
            this.leftJoystickYLabel.AutoSize = true;
            this.leftJoystickYLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leftJoystickYLabel.Location = new System.Drawing.Point(20, 70);
            this.leftJoystickYLabel.Name = "leftJoystickYLabel";
            this.leftJoystickYLabel.Size = new System.Drawing.Size(119, 23);
            this.leftJoystickYLabel.TabIndex = 1;
            this.leftJoystickYLabel.Text = "Left Joystick Y:";
            // 
            // leftJoystickXLabel
            // 
            this.leftJoystickXLabel.AutoSize = true;
            this.leftJoystickXLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leftJoystickXLabel.Location = new System.Drawing.Point(20, 30);
            this.leftJoystickXLabel.Name = "leftJoystickXLabel";
            this.leftJoystickXLabel.Size = new System.Drawing.Size(120, 23);
            this.leftJoystickXLabel.TabIndex = 0;
            this.leftJoystickXLabel.Text = "Left Joystick X:";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rightPanel.Controls.Add(this.incomingSignalsLabel);
            this.rightPanel.Controls.Add(this.statusBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(350, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(15);
            this.rightPanel.Size = new System.Drawing.Size(793, 750);
            this.rightPanel.TabIndex = 1;
            // 
            // incomingSignalsLabel
            // 
            this.incomingSignalsLabel.AutoSize = true;
            this.incomingSignalsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.incomingSignalsLabel.ForeColor = System.Drawing.Color.White;
            this.incomingSignalsLabel.Location = new System.Drawing.Point(15, 15);
            this.incomingSignalsLabel.Name = "incomingSignalsLabel";
            this.incomingSignalsLabel.Size = new System.Drawing.Size(169, 28);
            this.incomingSignalsLabel.TabIndex = 1;
            this.incomingSignalsLabel.Text = "Incoming Signals";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.statusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.statusBox.Location = new System.Drawing.Point(15, 55);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusBox.Size = new System.Drawing.Size(763, 680);
            this.statusBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MainForm";
            this.Text = "Driver Station";
            this.leftPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.controlTab.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.controllerTab.ResumeLayout(false);
            this.controllerPanel.ResumeLayout(false);
            this.buttonGroupBox.ResumeLayout(false);
            this.buttonGroupBox.PerformLayout();
            this.joystickGroupBox.ResumeLayout(false);
            this.joystickGroupBox.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage controlTab;
        private System.Windows.Forms.TabPage controllerTab;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Panel connectionStatusIndicator;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Panel joystickStatusIndicator;
        private System.Windows.Forms.Label joystickStatusLabel;
        private System.Windows.Forms.Panel controllerPanel;
        private System.Windows.Forms.Button reloadControllerButton;
        private System.Windows.Forms.GroupBox joystickGroupBox;
        private System.Windows.Forms.Label leftJoystickXLabel;
        private System.Windows.Forms.Label leftJoystickXValue;
        private System.Windows.Forms.Label leftJoystickYLabel;
        private System.Windows.Forms.Label leftJoystickYValue;
        private System.Windows.Forms.Label rightJoystickXLabel;
        private System.Windows.Forms.Label rightJoystickXValue;
        private System.Windows.Forms.Label rightJoystickYLabel;
        private System.Windows.Forms.Label rightJoystickYValue;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Label button1Label;
        private System.Windows.Forms.Label button2Label;
        private System.Windows.Forms.Label button3Label;
        private System.Windows.Forms.Label button4Label;
        private System.Windows.Forms.Label button1Value;
        private System.Windows.Forms.Label button2Value;
        private System.Windows.Forms.Label button3Value;
        private System.Windows.Forms.Label button4Value;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label incomingSignalsLabel;
    }
}
