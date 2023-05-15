using ExamSimProject.Forms;
using ExamSimProject.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSimProject.Properties
{
    public partial class loginPanel : UserControl
    {

        public loginPanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\ExamSimProject;Initial Catalog=ExamSimProject;Integrated Security=True");

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!(string.Equals(string.Empty, userIdTextField.Text) || string.Equals(string.Empty, passwordField.Text)))
            {
                

                conn.Open();
                String query = "SELECT * FROM USER_ACCOUNT WHERE username=@username AND password=@password";

                SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@username", userIdTextField.Text);
                cmd.Parameters.AddWithValue("@password", passwordField.Text);

                SqlDataAdapter da = new(cmd);
                DataTable dt = new();
                
                da.Fill(dt);

                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You have successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataRow userRow = dt.Rows[0];

                    User.IdPk = long.Parse(userRow["id_pk"].ToString());
                    User.Username = userRow["username"].ToString();
                    User.FirstName = userRow["first_name"].ToString();
                    User.LastName = userRow["last_name"].ToString();
                    User.Email = userRow["email"].ToString();

                    if (Parent is LoginForm parent)
                    {
                        parent.UserSuccessfullyAuthenticated = true;

                        parent.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your credentials.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Parent is LoginForm parent)
            {
                parent.LoginPanel.Hide();

                parent.Height = 665;
                parent.Width = 415;
                parent.BackgroundImage = Resources.registerBgImage;

                parent.RegisterPanel.Show();
                parent.RegisterPanel.BringToFront();
            }
        }
    }
}
