using ExamSimProject.Properties;

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
            loginPanel = new loginPanel();
            registerPanel = new registerPanel();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.FromArgb(190, 86, 202, 238);
            loginPanel.Location = new Point(12, 12);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(312, 426);
            loginPanel.TabIndex = 0;
            // 
            // registerPanel
            // 
            registerPanel.BackColor = Color.FromArgb(128, 3, 26, 38);
            registerPanel.Location = new Point(18, 37);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(360, 550);
            registerPanel.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.loginBgImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(registerPanel);
            Controls.Add(loginPanel);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Properties.loginPanel loginPanel;
        private registerPanel registerPanel;

        public loginPanel LoginPanel { get => loginPanel; set => loginPanel = value; }
        public registerPanel RegisterPanel { get => registerPanel; set => registerPanel = value; }
    }
}