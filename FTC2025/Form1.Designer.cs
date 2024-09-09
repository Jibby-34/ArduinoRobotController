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
            SuspendLayout();
            // 
            // statusBox
            // 
            statusBox.Location = new Point(12, 12);
            statusBox.Multiline = true;
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(500, 145);
            statusBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(560, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 1;
            button1.Text = "Enable";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enable_Click;
            // 
            // button2
            // 
            button2.Location = new Point(560, 50);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
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
            ControllerSectionLabel.Location = new Point(12, 213);
            ControllerSectionLabel.Name = "ControllerSectionLabel";
            ControllerSectionLabel.Size = new Size(109, 25);
            ControllerSectionLabel.TabIndex = 3;
            ControllerSectionLabel.Text = "Controller:";
            // 
            // LeftJoystickXLabel
            // 
            LeftJoystickXLabel.AutoSize = true;
            LeftJoystickXLabel.BackColor = SystemColors.ActiveCaptionText;
            LeftJoystickXLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickXLabel.ForeColor = SystemColors.Control;
            LeftJoystickXLabel.Location = new Point(15, 252);
            LeftJoystickXLabel.Name = "LeftJoystickXLabel";
            LeftJoystickXLabel.Size = new Size(92, 17);
            LeftJoystickXLabel.TabIndex = 4;
            LeftJoystickXLabel.Text = "Left Joystick X:";
            // 
            // LeftJoystickXValue
            // 
            LeftJoystickXValue.AutoSize = true;
            LeftJoystickXValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickXValue.ForeColor = SystemColors.Control;
            LeftJoystickXValue.Location = new Point(113, 252);
            LeftJoystickXValue.Name = "LeftJoystickXValue";
            LeftJoystickXValue.Size = new Size(15, 17);
            LeftJoystickXValue.TabIndex = 5;
            LeftJoystickXValue.Text = "0";
            // 
            // LeftJoystickYLabel
            // 
            LeftJoystickYLabel.AutoSize = true;
            LeftJoystickYLabel.BackColor = SystemColors.ActiveCaptionText;
            LeftJoystickYLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickYLabel.ForeColor = SystemColors.Control;
            LeftJoystickYLabel.Location = new Point(15, 279);
            LeftJoystickYLabel.Name = "LeftJoystickYLabel";
            LeftJoystickYLabel.Size = new Size(91, 17);
            LeftJoystickYLabel.TabIndex = 6;
            LeftJoystickYLabel.Text = "Left Joystick Y:";
            // 
            // LeftJoystickYValue
            // 
            LeftJoystickYValue.AutoSize = true;
            LeftJoystickYValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftJoystickYValue.ForeColor = SystemColors.Control;
            LeftJoystickYValue.Location = new Point(113, 279);
            LeftJoystickYValue.Name = "LeftJoystickYValue";
            LeftJoystickYValue.Size = new Size(15, 17);
            LeftJoystickYValue.TabIndex = 7;
            LeftJoystickYValue.Text = "0";
            // 
            // RightJoystickXLabel
            // 
            RightJoystickXLabel.AutoSize = true;
            RightJoystickXLabel.BackColor = SystemColors.ActiveCaptionText;
            RightJoystickXLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickXLabel.ForeColor = SystemColors.Control;
            RightJoystickXLabel.Location = new Point(15, 305);
            RightJoystickXLabel.Name = "RightJoystickXLabel";
            RightJoystickXLabel.Size = new Size(101, 17);
            RightJoystickXLabel.TabIndex = 8;
            RightJoystickXLabel.Text = "Right Joystick X:";
            // 
            // RightJoystickYLabel
            // 
            RightJoystickYLabel.AutoSize = true;
            RightJoystickYLabel.BackColor = SystemColors.ActiveCaptionText;
            RightJoystickYLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickYLabel.ForeColor = SystemColors.Control;
            RightJoystickYLabel.Location = new Point(15, 333);
            RightJoystickYLabel.Name = "RightJoystickYLabel";
            RightJoystickYLabel.Size = new Size(100, 17);
            RightJoystickYLabel.TabIndex = 9;
            RightJoystickYLabel.Text = "Right Joystick Y:";
            // 
            // RightJoystickXValue
            // 
            RightJoystickXValue.AutoSize = true;
            RightJoystickXValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickXValue.ForeColor = SystemColors.Control;
            RightJoystickXValue.Location = new Point(122, 305);
            RightJoystickXValue.Name = "RightJoystickXValue";
            RightJoystickXValue.Size = new Size(15, 17);
            RightJoystickXValue.TabIndex = 10;
            RightJoystickXValue.Text = "0";
            // 
            // RightJoystickYValue
            // 
            RightJoystickYValue.AutoSize = true;
            RightJoystickYValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightJoystickYValue.ForeColor = SystemColors.Control;
            RightJoystickYValue.Location = new Point(122, 333);
            RightJoystickYValue.Name = "RightJoystickYValue";
            RightJoystickYValue.Size = new Size(15, 17);
            RightJoystickYValue.TabIndex = 11;
            RightJoystickYValue.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
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
    }
}
