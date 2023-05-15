namespace ExamSimProject.Properties
{
    partial class registerPanel
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
            pictureBox1 = new PictureBox();
            passwordField = new TextBox();
            passwordLabel = new Label();
            emailTextField = new TextBox();
            emailLabel = new Label();
            usernameLabel = new Label();
            usernameField = new TextBox();
            passConLabel = new Label();
            passConTextField = new TextBox();
            registButton = new Button();
            LastNameField = new TextBox();
            lastNameLabel = new Label();
            firstNameField = new TextBox();
            firstNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Resources.userIcon;
            pictureBox1.Location = new Point(129, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // passwordField
            // 
            passwordField.Cursor = Cursors.IBeam;
            passwordField.Location = new Point(52, 293);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '●';
            passwordField.PlaceholderText = "Password";
            passwordField.Size = new Size(257, 23);
            passwordField.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(52, 275);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 15);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "* Password:";
            // 
            // emailTextField
            // 
            emailTextField.Cursor = Cursors.IBeam;
            emailTextField.Location = new Point(52, 117);
            emailTextField.Name = "emailTextField";
            emailTextField.PlaceholderText = "Email (ex: example@gmail.com)";
            emailTextField.Size = new Size(257, 23);
            emailTextField.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(52, 99);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(47, 15);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "* Email:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(52, 143);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 15);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "* Username:";
            // 
            // usernameField
            // 
            usernameField.Cursor = Cursors.IBeam;
            usernameField.Location = new Point(52, 161);
            usernameField.Name = "usernameField";
            usernameField.PlaceholderText = "Username";
            usernameField.Size = new Size(257, 23);
            usernameField.TabIndex = 8;
            // 
            // passConLabel
            // 
            passConLabel.AutoSize = true;
            passConLabel.BackColor = Color.Transparent;
            passConLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passConLabel.Location = new Point(52, 319);
            passConLabel.Name = "passConLabel";
            passConLabel.Size = new Size(118, 15);
            passConLabel.TabIndex = 7;
            passConLabel.Text = "* Confirm Password:";
            // 
            // passConTextField
            // 
            passConTextField.Cursor = Cursors.IBeam;
            passConTextField.Location = new Point(52, 337);
            passConTextField.Name = "passConTextField";
            passConTextField.PasswordChar = '●';
            passConTextField.PlaceholderText = "Confirm Password";
            passConTextField.ShortcutsEnabled = false;
            passConTextField.Size = new Size(257, 23);
            passConTextField.TabIndex = 8;
            // 
            // registButton
            // 
            registButton.BackgroundImage = Resources.registButtonBg;
            registButton.BackgroundImageLayout = ImageLayout.Stretch;
            registButton.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            registButton.ForeColor = Color.Teal;
            registButton.Location = new Point(52, 450);
            registButton.Name = "registButton";
            registButton.Size = new Size(257, 70);
            registButton.TabIndex = 9;
            registButton.TabStop = false;
            registButton.Text = "Register wahahaha";
            registButton.UseVisualStyleBackColor = true;
            registButton.Click += registButton_Click;
            // 
            // LastNameField
            // 
            LastNameField.Cursor = Cursors.IBeam;
            LastNameField.Location = new Point(52, 249);
            LastNameField.Name = "LastNameField";
            LastNameField.PlaceholderText = "Last Name";
            LastNameField.Size = new Size(257, 23);
            LastNameField.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(52, 231);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(76, 15);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "* Last Name:";
            // 
            // firstNameField
            // 
            firstNameField.Cursor = Cursors.IBeam;
            firstNameField.Location = new Point(52, 205);
            firstNameField.Name = "firstNameField";
            firstNameField.PlaceholderText = "First Name:";
            firstNameField.Size = new Size(257, 23);
            firstNameField.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(52, 187);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(78, 15);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "* First Name:";
            // 
            // registerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 3, 26, 38);
            Controls.Add(LastNameField);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameField);
            Controls.Add(firstNameLabel);
            Controls.Add(registButton);
            Controls.Add(usernameField);
            Controls.Add(passConTextField);
            Controls.Add(passwordField);
            Controls.Add(usernameLabel);
            Controls.Add(passConLabel);
            Controls.Add(passwordLabel);
            Controls.Add(emailTextField);
            Controls.Add(emailLabel);
            Controls.Add(pictureBox1);
            Name = "registerPanel";
            Size = new Size(360, 550);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox emailTextField;
        private Label emailLabel;
        private Label usernameLabel;
        private TextBox usernameField;
        private Label passConLabel;
        private TextBox passConTextField;
        private Button registButton;
        private TextBox LastNameField;
        private Label lastNameLabel;
        private TextBox firstNameField;
        private Label firstNameLabel;
    }
}
