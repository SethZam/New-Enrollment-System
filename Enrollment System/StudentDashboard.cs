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
        string usern;
        EnrollmentDataContext db = new EnrollmentDataContext();
        public StudentDashboard(string username)
        {
            InitializeComponent();
            usern = username;
            var result = db.get_info(username).ToList() ;
            foreach(var item in result)
            {
                user.Text = item.stud_fname + " "+ item.stud_mname + " " + item.stud_lname;
            }
                
            studentHomePage2.Show();
            studentHomePage2.BringToFront();
            studentEnrollmentPage2.Hide();
            studentCORPage1.Hide();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentHomePage2.Show();
            studentHomePage2.BringToFront();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentEnrollmentPage2.username = user.Text;
            studentEnrollmentPage2.Show();
            studentEnrollmentPage2.BringToFront();
            Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentCORPage1.username = usern;
            studentCORPage1.Show();
            studentCORPage1.BringToFront();
            Visible = true;
        }
    }
}
