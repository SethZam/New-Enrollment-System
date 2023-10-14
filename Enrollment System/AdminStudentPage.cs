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
    public partial class AdminStudentPage : UserControl
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminStudentPage()
        {
            InitializeComponent();
        }

        private void AdminStudentPage_Load(object sender, EventArgs e)
        {
            dgvEnrolled.DataSource = db.enrolled_view();

            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.HeaderText = "Delete";
            action.Name = "deletetbtn";
            action.Text = "Remove";
            action.UseColumnTextForButtonValue = true;
            dgvEnrolled.Columns.Add(action);
        }
    }
}
