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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(string user_name)
        {
            
            InitializeComponent();
            user.Text = user_name.ToString();
            adminHomePage1.Show();
            adminHomePage1.BringToFront();
            adminEnrolleesPage1.Hide();
            adminSubjectPage1.Hide();
            adminInstructorPage1.Hide();
            adminStudentPage1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminHomePage1.Show();
            adminHomePage1.BringToFront();
            adminEnrolleesPage1.Hide();
            adminSubjectPage1.Hide();
            adminInstructorPage1.Hide();
            adminStudentPage1.Hide();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminEnrolleesPage1.Show();
            adminEnrolleesPage1.BringToFront();
            adminHomePage1.Hide();
            adminSubjectPage1.Hide();
            adminInstructorPage1.Hide();
            adminStudentPage1.Hide();
            Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminSubjectPage1.Show();
            adminSubjectPage1.BringToFront();
            adminHomePage1.Hide();
            adminEnrolleesPage1.Hide();
            adminInstructorPage1.Hide();
            adminStudentPage1.Hide();
            Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminInstructorPage1.Show();
            adminInstructorPage1.BringToFront();
            adminHomePage1.Hide();
            adminEnrolleesPage1.Hide();
            adminSubjectPage1.Hide();
            adminStudentPage1.Hide();
            Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login i = new Login();
            i.Show();
            i.BringToFront();
            Visible = false;
            MessageBox.Show("Successfully Logged Out!", "Log Out", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adminStudentPage1.Show();
            adminStudentPage1.BringToFront();
            adminHomePage1.Hide();
            adminEnrolleesPage1.Hide();
            adminSubjectPage1.Hide();
            adminInstructorPage1.Hide();
            Visible = true;
        }
    }
}
