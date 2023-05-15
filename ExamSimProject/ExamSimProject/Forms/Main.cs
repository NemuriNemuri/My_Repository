using ExamSimProject.General;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamSimProject.General;
using System.Data;
using System.Data.SqlClient;

namespace ExamSimProject.Forms
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\ExamSimProject;Initial Catalog=ExamSimProject;Integrated Security=True");

        private void Main_Load(object sender, EventArgs e)
        {
            greetingLabel.Text = "Welcome back, " + User.FirstName + " " + User.LastName;

            conn.Open();
            String query = "Select * FROM USER_PROGRESS WHERE user_id_pk=@idPk";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@idPk", User.IdPk);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            conn.Close();

            int iter = 1;

            foreach (DataRow item in dt.Rows)
            {
                DataRow dataRow = item;

                coursePanel course = new coursePanel();

                course.Location = new Point(25, 25);
                course.Name = "course" + iter;
                course.BackColor = Color.FromArgb(176, 255, 255, 255);
                course.Size = new Size(175, 175);

                course.TabIndex = 0;

                course.BestProgress.Text = "Best Progress: " +  dataRow["progress"].ToString() + "%";

                TimeSpan time = (TimeSpan)dataRow["time"];
                course.BestTime.Text = "Best Time: " + time.ToString(@"hh\:mm\:ss");

                coursesPanel.Controls.Add(course);
            }

            

        }

        private void coursesPanel_Paint(object sender, PaintEventArgs e)
        {
            if (coursesPanel.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using Pen p = new Pen(Color.Black, thickness);
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          coursesPanel.ClientSize.Width - thickness,
                                                          coursesPanel.ClientSize.Height - thickness));
            }

        }

    }
}
