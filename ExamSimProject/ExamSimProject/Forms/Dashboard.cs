using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSimProject.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            sideMenu.Hide();
            hoverPanel.Show();
        }

        private void hoverPanel_MouseHover(object sender, EventArgs e)
        {
            sideMenu.Show();
            sideMenu.BringToFront();
        }

        private void sideMenu_MouseLeave(object sender, EventArgs e)
        {
            sideMenu.Hide();
            sideMenu.SendToBack();
        }

    }
}
