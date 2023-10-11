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
    public partial class StudentEnrollmentPage : UserControl
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public string username { get; set; }
        int id;
        int courseid;
        string cre;

        public StudentEnrollmentPage()
        {
            InitializeComponent();
            
        }

        private void StudentEnrollmentPage_Load(object sender, EventArgs e)
        {
            var info = db.get_info(username);
            foreach (var item in info)
            {
                lastname.Text = item.stud_lname;
                firstname.Text = item.stud_fname;
                middlename.Text = item.stud_mname;
            }
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(IsEmpty() is true)
            {
                MessageBox.Show("Fill all needed informations");
            }
            else
            {
                id = GetID(username.ToString());
                cre = course.Text;
                courseid = GetCourseID(cre);
                MessageBox.Show("Submitted Successfully");
                db.enroll_student(Convert.ToInt32(year.SelectedItem), Convert.ToInt32(id), Convert.ToInt32(courseid));
            }
                    
        }

        public static int GetID(string username)
        {
            EnrollmentDataContext db = new EnrollmentDataContext();
            int id = 0;
            var studid = db.get_id(username);
            foreach (var item in studid)
            {
              id = Convert.ToInt32(item.stud_id);
            }
            return id;           
        }

        public static int GetCourseID(string course)
        {
            EnrollmentDataContext db = new EnrollmentDataContext();
            int courseid = 0;
            var result = db.get_courseid(course);
            foreach(var item in result)
            {
                courseid = item.course_id;
            }
            return courseid;
        }
        bool IsEmpty()
        {
            if(lastname.Text == "" || firstname.Text == "" || middlename.Text == "" ||year.Text == "" || course.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
