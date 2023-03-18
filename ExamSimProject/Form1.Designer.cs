namespace ExamSimProject
{
    partial class LoginForm
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
            panel1 = new Panel();
            loginButton = new Button();
            passwordField = new TextBox();
            passwordLabel = new Label();
            userIdTextField = new TextBox();
            userIdLabel = new Label();
            pictureBox1 = new PictureBox();
            registerLink = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(registerLink);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(userIdTextField);
            panel1.Controls.Add(userIdLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 426);
            panel1.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SkyBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(96, 275);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 65);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordField
            // 
            passwordField.Cursor = Cursors.IBeam;
            passwordField.Location = new Point(28, 226);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(250, 23);
            passwordField.TabIndex = 4;
            passwordField.Text = "Password";
            passwordField.GotFocus += RemovePasswordPlaceHolder;
            passwordField.LostFocus += AddPasswordPlaceHolder;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(28, 208);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // userIdTextField
            // 
            userIdTextField.Cursor = Cursors.IBeam;
            userIdTextField.Location = new Point(28, 172);
            userIdTextField.Name = "userIdTextField";
            userIdTextField.Size = new Size(250, 23);
            userIdTextField.TabIndex = 2;
            userIdTextField.Text = "Email or Username";
            userIdTextField.GotFocus += RemoveUserIdPlaceHolder;
            userIdTextField.LostFocus += AddUserIdPlaceHolder;
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userIdLabel.Location = new Point(28, 154);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(101, 15);
            userIdLabel.TabIndex = 1;
            userIdLabel.Text = "Email/Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.userIcon;
            pictureBox1.Location = new Point(96, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // registerLink
            // 
            registerLink.AutoSize = true;
            registerLink.LinkBehavior = LinkBehavior.HoverUnderline;
            registerLink.Location = new Point(120, 383);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(47, 15);
            registerLink.TabIndex = 6;
            registerLink.TabStop = true;
            registerLink.Text = "Sign up";
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginBgImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox userIdTextField;
        private Label userIdLabel;
        private PictureBox pictureBox1;
        private TextBox passwordField;
        private Label passwordLabel;
        private Button loginButton;
        private LinkLabel registerLink;
    }
}