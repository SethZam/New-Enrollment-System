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
    public partial class StudentPIPage : UserControl
    {
        int age;
        DateTime birth;
        EnrollmentDataContext db = new EnrollmentDataContext();

        public StudentPIPage()
        {
            InitializeComponent();
        }

        public string username { get; set; }

        private void StudentPIPage_Load(object sender, EventArgs e)
        {
            var result = db.get_stud_info(username);
            foreach (var item in result)
            {
                txtlname.Text = item.stud_lname;
                txtfname.Text = item.stud_fname;
                txtmname.Text = item.stud_mname;
                dtpbday.Text = item.stud_bd.ToString();
                txtphone.Text = item.stud_tel;
                txtgender.Text = item.stud_gender;
                txtemail.Text = item.stud_email;
                txtaddress.Text = item.stud_address;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            birth = DateTime.Parse(dtpbday.Text);
            age = GetAge(birth);
            db.update_stud_info(username ,txtfname.Text, txtmname.Text, txtlname.Text, txtphone.Text, txtgender.Text, DateTime.Parse(dtpbday.Text), Convert.ToInt32(age), txtaddress.Text, txtemail.Text);
            db.get_stud_info(username);
            MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK);
            this.Hide();
            foreach (Form form in Application.OpenForms)
            {
                if (form is StudentDashboard)
                {
                    form.BringToFront();
                    return;
                }
            }
            StudentDashboard sd = new StudentDashboard(username);
            sd.Show();
        }

        static int GetAge(DateTime birth)
        {

            int age;
            if (birth.Month <= DateTime.Now.Month && birth.Day <= DateTime.Now.Day)
            {
                age = DateTime.Now.Year - birth.Year;
                Convert.ToInt32(age);
            }
            else
            {
                age = DateTime.Now.Year - birth.Year;
                age--;
                Convert.ToInt32(age);
            }

            return age;
        }
    }
}
