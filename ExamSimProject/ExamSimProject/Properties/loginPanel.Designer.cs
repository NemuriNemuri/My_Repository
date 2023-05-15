namespace ExamSimProject.Properties
{
    partial class loginPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registerLink = new LinkLabel();
            loginButton = new Button();
            passwordField = new TextBox();
            passwordLabel = new Label();
            userIdTextField = new TextBox();
            userIdLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registerLink
            // 
            registerLink.AutoSize = true;
            registerLink.BackColor = Color.Transparent;
            registerLink.LinkBehavior = LinkBehavior.HoverUnderline;
            registerLink.Location = new Point(123, 378);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(47, 15);
            registerLink.TabIndex = 13;
            registerLink.TabStop = true;
            registerLink.Text = "Sign up";
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SkyBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(99, 288);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 50);
            loginButton.TabIndex = 12;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordField
            // 
            passwordField.Cursor = Cursors.IBeam;
            passwordField.Location = new Point(31, 221);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '●';
            passwordField.PlaceholderText = "Password";
            passwordField.Size = new Size(250, 23);
            passwordField.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(31, 203);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 15);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // userIdTextField
            // 
            userIdTextField.Cursor = Cursors.IBeam;
            userIdTextField.Location = new Point(31, 167);
            userIdTextField.Name = "userIdTextField";
            userIdTextField.PlaceholderText = "Email or Username";
            userIdTextField.Size = new Size(250, 23);
            userIdTextField.TabIndex = 9;
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.BackColor = Color.Transparent;
            userIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userIdLabel.Location = new Point(31, 149);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(101, 15);
            userIdLabel.TabIndex = 8;
            userIdLabel.Text = "Email/Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Resources.userIcon;
            pictureBox1.Location = new Point(99, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 86, 202, 238);
            Controls.Add(registerLink);
            Controls.Add(loginButton);
            Controls.Add(passwordField);
            Controls.Add(passwordLabel);
            Controls.Add(userIdTextField);
            Controls.Add(userIdLabel);
            Controls.Add(pictureBox1);
            Name = "loginPanel";
            Size = new Size(312, 426);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel registerLink;
        private Button loginButton;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox userIdTextField;
        private Label userIdLabel;
        private PictureBox pictureBox1;
    }
}
