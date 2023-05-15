using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExamSimProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool UserSuccessfullyAuthenticated;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            registerPanel.Hide();
            loginPanel.BringToFront();
        }
    }
}