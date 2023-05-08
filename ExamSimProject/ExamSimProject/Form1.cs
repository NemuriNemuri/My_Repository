using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExamSimProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!(string.Equals(string.Empty, userIdTextField.Text) || string.Equals(string.Empty, passwordField.Text)))
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