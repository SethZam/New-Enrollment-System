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
   
    public partial class AdminEnrolleesPage : UserControl
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminEnrolleesPage()
        {
            InitializeComponent();
        }

        private void AdminEnrolleesPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.enrollees_view();

            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.HeaderText = "Action";
            action.Name = "acceptbtn";
            action.Text = "Confirm";
            action.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(action);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "acceptbtn")
            {
                if(MessageBox.Show("Confirm?","Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    db.accept_enrollment(id);
                    dataGridView1.DataSource = db.enrollees_view();
                }
            }
        }
    }
}
