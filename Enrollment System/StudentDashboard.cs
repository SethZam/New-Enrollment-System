using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard(string username)
        {
            InitializeComponent();
            user.Text = username;
            studentHomePage1.Show();
            studentHomePage1.BringToFront();
            studentEnrollmentPage1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentHomePage1.Show();
            studentHomePage1.BringToFront();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentEnrollmentPage1.username = user.Text;
            studentEnrollmentPage1.Show();
            studentEnrollmentPage1.BringToFront();
            Visible = true;
        }

    }
}
