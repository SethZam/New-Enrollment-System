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
    public partial class AdminHomePage : UserControl
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminHomePage( )
        {
            InitializeComponent();           
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            total_students.Text = db.enrollees_view().Count().ToString();
            total_instructor.Text = db.view_instructor().Count().ToString();
        }
    }
}
