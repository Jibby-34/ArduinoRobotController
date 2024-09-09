namespace FTC2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ControllerSectionLabel = new Label();
            LeftJoystickXLabel = new Label();
            LeftJoystickXValue = new Label();
            LeftJoystickYLabel = new Label();
            LeftJoystickYValue = new Label();
            RightJoystickXLabel = new Label();
            RightJoystickYLabel = new Label();
            RightJoystickXValue = new Label();
            RightJoystickYValue = new Label();
            ButtonOneLabel = new Label();
            ButtonThreeLabel = new Label();
            ButtonTwoLabel = new Label();
            ButtonFourLabel = new Label();
            ButtonOneValue = new Label();
            ButtonTwoValue = new Label();
            ButtonThreeValue = new Label();
            ButtonFourValue = new Label();
            SuspendLayout();
            // 
            // statusBox
            // 
            statusBox.Location = new Point(17, 20);
            statusBox.Margin = new Padding(4, 5, 4, 5);
            statusBox.Multiline = true;
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(713, 239);
            statusBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(800, 20);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(139, 38);
            button1.TabIndex = 1;
            button1.Text = "Enable";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enable_Click;
            // 
            // button2
            // 
            button2.Location = new Point(800, 83);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 2;
            button2.Text = "Disable";
            button2.UseVisualStyleBackColor = true;
            button2.Click += disable_Click;
            // 
            // ControllerSectionLabel
            // 
            ControllerSectionLabel.AutoSize = true;
            ControllerSectionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ControllerSectionLabel.ForeColor = SystemColors.Control;
            ControllerSectionLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            ControllerSectionLabel.Location = new Point(13, 339);
            ControllerSectionLabel.Margin = new Padding(4, 0, 4, 0);
            ControllerSectionLabel.Name = "ControllerSectionLabel";
            ControllerSectionLabel.Size = new Size(165, 40);
            ControllerSectionLabel.TabIndex = 3;
            ControllerSectionLabel.Text = "Controller:";
            // 
            // LeftJoystickXLabel
            // 
            LeftJoystickXLabel.AutoSize = true;
            LeftJoystickXLabel.BackColor = SystemColors.ActiveCaptionText;
            LeftJoystickXLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickXLabel.ForeColor = SystemColors.Control;
            LeftJoystickXLabel.Location = new Point(17, 395);
            LeftJoystickXLabel.Margin = new Padding(4, 0, 4, 0);
            LeftJoystickXLabel.Name = "LeftJoystickXLabel";
            LeftJoystickXLabel.Size = new Size(138, 28);
            LeftJoystickXLabel.TabIndex = 4;
            LeftJoystickXLabel.Text = "Left Joystick X:";
            // 
            // LeftJoystickXValue
            // 
            LeftJoystickXValue.AutoSize = true;
            LeftJoystickXValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickXValue.ForeColor = SystemColors.Control;
            LeftJoystickXValue.Location = new Point(163, 395);
            LeftJoystickXValue.Margin = new Padding(4, 0, 4, 0);
            LeftJoystickXValue.Name = "LeftJoystickXValue";
            LeftJoystickXValue.Size = new Size(23, 28);
            LeftJoystickXValue.TabIndex = 5;
            LeftJoystickXValue.Text = "0";
            // 
            // LeftJoystickYLabel
            // 
            LeftJoystickYLabel.AutoSize = true;
            LeftJoystickYLabel.BackColor = SystemColors.ActiveCaptionText;
            LeftJoystickYLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickYLabel.ForeColor = SystemColors.Control;
            LeftJoystickYLabel.Location = new Point(17, 440);
            LeftJoystickYLabel.Margin = new Padding(4, 0, 4, 0);
            LeftJoystickYLabel.Name = "LeftJoystickYLabel";
            LeftJoystickYLabel.Size = new Size(137, 28);
            LeftJoystickYLabel.TabIndex = 6;
            LeftJoystickYLabel.Text = "Left Joystick Y:";
            // 
            // LeftJoystickYValue
            // 
            LeftJoystickYValue.AutoSize = true;
            LeftJoystickYValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickYValue.ForeColor = SystemColors.Control;
            LeftJoystickYValue.Location = new Point(163, 440);
            LeftJoystickYValue.Margin = new Padding(4, 0, 4, 0);
            LeftJoystickYValue.Name = "LeftJoystickYValue";
            LeftJoystickYValue.Size = new Size(23, 28);
            LeftJoystickYValue.TabIndex = 7;
            LeftJoystickYValue.Text = "0";
            // 
            // RightJoystickXLabel
            // 
            RightJoystickXLabel.AutoSize = true;
            RightJoystickXLabel.BackColor = SystemColors.ActiveCaptionText;
            RightJoystickXLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickXLabel.ForeColor = SystemColors.Control;
            RightJoystickXLabel.Location = new Point(17, 483);
            RightJoystickXLabel.Margin = new Padding(4, 0, 4, 0);
            RightJoystickXLabel.Name = "RightJoystickXLabel";
            RightJoystickXLabel.Size = new Size(153, 28);
            RightJoystickXLabel.TabIndex = 8;
            RightJoystickXLabel.Text = "Right Joystick X:";
            // 
            // RightJoystickYLabel
            // 
            RightJoystickYLabel.AutoSize = true;
            RightJoystickYLabel.BackColor = SystemColors.ActiveCaptionText;
            RightJoystickYLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickYLabel.ForeColor = SystemColors.Control;
            RightJoystickYLabel.Location = new Point(17, 530);
            RightJoystickYLabel.Margin = new Padding(4, 0, 4, 0);
            RightJoystickYLabel.Name = "RightJoystickYLabel";
            RightJoystickYLabel.Size = new Size(152, 28);
            RightJoystickYLabel.TabIndex = 9;
            RightJoystickYLabel.Text = "Right Joystick Y:";
            // 
            // RightJoystickXValue
            // 
            RightJoystickXValue.AutoSize = true;
            RightJoystickXValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickXValue.ForeColor = SystemColors.Control;
            RightJoystickXValue.Location = new Point(178, 483);
            RightJoystickXValue.Margin = new Padding(4, 0, 4, 0);
            RightJoystickXValue.Name = "RightJoystickXValue";
            RightJoystickXValue.Size = new Size(23, 28);
            RightJoystickXValue.TabIndex = 10;
            RightJoystickXValue.Text = "0";
            // 
            // RightJoystickYValue
            // 
            RightJoystickYValue.AutoSize = true;
            RightJoystickYValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickYValue.ForeColor = SystemColors.Control;
            RightJoystickYValue.Location = new Point(178, 530);
            RightJoystickYValue.Margin = new Padding(4, 0, 4, 0);
            RightJoystickYValue.Name = "RightJoystickYValue";
            RightJoystickYValue.Size = new Size(23, 28);
            RightJoystickYValue.TabIndex = 11;
            RightJoystickYValue.Text = "0";
            // 
            // ButtonOneLabel
            // 
            ButtonOneLabel.AutoSize = true;
            ButtonOneLabel.BackColor = SystemColors.ActiveCaptionText;
            ButtonOneLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonOneLabel.ForeColor = SystemColors.Control;
            ButtonOneLabel.Location = new Point(17, 574);
            ButtonOneLabel.Margin = new Padding(4, 0, 4, 0);
            ButtonOneLabel.Name = "ButtonOneLabel";
            ButtonOneLabel.Size = new Size(91, 28);
            ButtonOneLabel.TabIndex = 12;
            ButtonOneLabel.Text = "Button 1:";
            // 
            // ButtonThreeLabel
            // 
            ButtonThreeLabel.AutoSize = true;
            ButtonThreeLabel.BackColor = SystemColors.ActiveCaptionText;
            ButtonThreeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonThreeLabel.ForeColor = SystemColors.Control;
            ButtonThreeLabel.Location = new Point(17, 661);
            ButtonThreeLabel.Margin = new Padding(4, 0, 4, 0);
            ButtonThreeLabel.Name = "ButtonThreeLabel";
            ButtonThreeLabel.Size = new Size(91, 28);
            ButtonThreeLabel.TabIndex = 13;
            ButtonThreeLabel.Text = "Button 3:";
            // 
            // ButtonTwoLabel
            // 
            ButtonTwoLabel.AutoSize = true;
            ButtonTwoLabel.BackColor = SystemColors.ActiveCaptionText;
            ButtonTwoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonTwoLabel.ForeColor = SystemColors.Control;
            ButtonTwoLabel.Location = new Point(17, 618);
            ButtonTwoLabel.Margin = new Padding(4, 0, 4, 0);
            ButtonTwoLabel.Name = "ButtonTwoLabel";
            ButtonTwoLabel.Size = new Size(91, 28);
            ButtonTwoLabel.TabIndex = 14;
            ButtonTwoLabel.Text = "Button 2:";
            // 
            // ButtonFourLabel
            // 
            ButtonFourLabel.AutoSize = true;
            ButtonFourLabel.BackColor = SystemColors.ActiveCaptionText;
            ButtonFourLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonFourLabel.ForeColor = SystemColors.Control;
            ButtonFourLabel.Location = new Point(17, 702);
            ButtonFourLabel.Margin = new Padding(4, 0, 4, 0);
            ButtonFourLabel.Name = "ButtonFourLabel";
            ButtonFourLabel.Size = new Size(91, 28);
            ButtonFourLabel.TabIndex = 15;
            ButtonFourLabel.Text = "Button 4:";
            // 
            // ButtonOneValue
            // 
            ButtonOneValue.AutoSize = true;
            ButtonOneValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonOneValue.ForeColor = SystemColors.Control;
            ButtonOneValue.Location = new Point(116, 574);
            ButtonOneValue.Margin = new Padding(4, 0, 4, 0);
            ButtonOneValue.Name = "ButtonOneValue";
            ButtonOneValue.Size = new Size(51, 28);
            ButtonOneValue.TabIndex = 16;
            ButtonOneValue.Text = "false";
            // 
            // ButtonTwoValue
            // 
            ButtonTwoValue.AutoSize = true;
            ButtonTwoValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonTwoValue.ForeColor = SystemColors.Control;
            ButtonTwoValue.Location = new Point(116, 618);
            ButtonTwoValue.Margin = new Padding(4, 0, 4, 0);
            ButtonTwoValue.Name = "ButtonTwoValue";
            ButtonTwoValue.Size = new Size(51, 28);
            ButtonTwoValue.TabIndex = 17;
            ButtonTwoValue.Text = "false";
            // 
            // ButtonThreeValue
            // 
            ButtonThreeValue.AutoSize = true;
            ButtonThreeValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonThreeValue.ForeColor = SystemColors.Control;
            ButtonThreeValue.Location = new Point(116, 661);
            ButtonThreeValue.Margin = new Padding(4, 0, 4, 0);
            ButtonThreeValue.Name = "ButtonThreeValue";
            ButtonThreeValue.Size = new Size(51, 28);
            ButtonThreeValue.TabIndex = 18;
            ButtonThreeValue.Text = "false";
            // 
            // ButtonFourValue
            // 
            ButtonFourValue.AutoSize = true;
            ButtonFourValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonFourValue.ForeColor = SystemColors.Control;
            ButtonFourValue.Location = new Point(116, 702);
            ButtonFourValue.Margin = new Padding(4, 0, 4, 0);
            ButtonFourValue.Name = "ButtonFourValue";
            ButtonFourValue.Size = new Size(51, 28);
            ButtonFourValue.TabIndex = 19;
            ButtonFourValue.Text = "false";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1143, 750);
            Controls.Add(ButtonFourValue);
            Controls.Add(ButtonThreeValue);
            Controls.Add(ButtonTwoValue);
            Controls.Add(ButtonOneValue);
            Controls.Add(ButtonFourLabel);
            Controls.Add(ButtonTwoLabel);
            Controls.Add(ButtonThreeLabel);
            Controls.Add(ButtonOneLabel);
            Controls.Add(RightJoystickYValue);
            Controls.Add(RightJoystickXValue);
            Controls.Add(RightJoystickYLabel);
            Controls.Add(RightJoystickXLabel);
            Controls.Add(LeftJoystickYValue);
            Controls.Add(LeftJoystickYLabel);
            Controls.Add(LeftJoystickXValue);
            Controls.Add(LeftJoystickXLabel);
            Controls.Add(ControllerSectionLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(statusBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox statusBox;
        private Button button1;
        private Button button2;
        private Label ControllerSectionLabel;
        private Label LeftJoystickXLabel;
        private Label LeftJoystickXValue;
        private Label LeftJoystickYLabel;
        private Label LeftJoystickYValue;
        private Label RightJoystickXLabel;
        private Label RightJoystickYLabel;
        private Label RightJoystickXValue;
        private Label RightJoystickYValue;
        private Label ButtonOneLabel;
        private Label ButtonThreeLabel;
        private Label ButtonTwoLabel;
        private Label ButtonFourLabel;
        private Label ButtonOneValue;
        private Label ButtonTwoValue;
        private Label ButtonThreeValue;
        private Label ButtonFourValue;
    }
}
