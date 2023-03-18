using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExamSimProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void RemoveUserIdPlaceHolder(object sender, EventArgs e)
        {
            if (userIdTextField.Text == "Email or Username")
            {
                userIdTextField.Text = "";
            }
        }

        public void AddUserIdPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userIdTextField.Text))
            {
                userIdTextField.Text = "Email or Username";
            }
        }

        public void RemovePasswordPlaceHolder(object sender, EventArgs e)
        {
            if (passwordField.Text == "Password")
            {
                passwordField.Text = "";
            }
        }

        public void AddPasswordPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordField.Text))
            {
                passwordField.Text = "Password";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!(string.Equals("Email or Username", userIdTextField.Text) || string.Equals("Password", passwordField.Text)))
            {
                MessageBox.Show("You have successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter your credentials.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("I don't know.", "Register?");
        }
    }
}