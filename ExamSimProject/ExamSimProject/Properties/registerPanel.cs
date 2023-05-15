using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Dynamic;

namespace ExamSimProject.Properties
{
    public partial class registerPanel : UserControl
    {
        public registerPanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\ExamSimProject;Initial Catalog=ExamSimProject;Integrated Security=True");

        private void registButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordField.Text))
            {
                MessageBox.Show("Password should not be blank!", "Registration Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (passwordField.Text == passConTextField.Text)
            {
                String query = "INSERT INTO USER_ACCOUNT (username, password, email, first_name, last_name) VALUES (@username, @password, @email, @firstName, @lastName)";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@username", usernameField.Text);
                cmd.Parameters.AddWithValue("@password", passwordField.Text);
                cmd.Parameters.AddWithValue("@email", emailTextField.Text);
                cmd.Parameters.AddWithValue("@firstName", firstNameField.Text);
                cmd.Parameters.AddWithValue("@lastName", LastNameField.Text);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Successfully Registered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoginForm? parent = Parent as LoginForm;

            if (parent != null)
            {
                parent.RegisterPanel.Hide();

                parent.Height = 489;
                parent.Width = 816;
                parent.BackgroundImage = Resources.loginBgImage;

                parent.LoginPanel.Show();
                parent.LoginPanel.BringToFront();
            }
        }
    }
}
