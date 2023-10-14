
namespace Enrollment_System
{
    partial class StudentEnrollmentPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submit = new System.Windows.Forms.Button();
            this.yearlevel = new System.Windows.Forms.ComboBox();
            this.acadyear = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.middlename = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sem = new System.Windows.Forms.ComboBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.SteelBlue;
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(33, 425);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(73, 37);
            this.submit.TabIndex = 48;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // yearlevel
            // 
            this.yearlevel.FormattingEnabled = true;
            this.yearlevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.yearlevel.Location = new System.Drawing.Point(33, 308);
            this.yearlevel.Name = "yearlevel";
            this.yearlevel.Size = new System.Drawing.Size(207, 21);
            this.yearlevel.TabIndex = 47;
            // 
            // acadyear
            // 
            this.acadyear.FormattingEnabled = true;
            this.acadyear.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.acadyear.Location = new System.Drawing.Point(33, 371);
            this.acadyear.Name = "acadyear";
            this.acadyear.Size = new System.Drawing.Size(207, 21);
            this.acadyear.TabIndex = 46;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Old",
            "New",
            "Transferee"});
            this.status.Location = new System.Drawing.Point(265, 244);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(207, 21);
            this.status.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(262, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(262, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(30, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Year Level";
            // 
            // middlename
            // 
            this.middlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlename.Location = new System.Drawing.Point(33, 242);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(207, 23);
            this.middlename.TabIndex = 41;
            // 
            // firstname
            // 
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(265, 173);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(207, 23);
            this.firstname.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(30, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(262, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "First Name:";
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(33, 173);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(207, 23);
            this.lastname.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(30, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enrollment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(262, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Semester";
            // 
            // sem
            // 
            this.sem.FormattingEnabled = true;
            this.sem.Items.AddRange(new object[] {
            "First",
            "Second"});
            this.sem.Location = new System.Drawing.Point(265, 371);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(207, 21);
            this.sem.TabIndex = 50;
            // 
            // course
            // 
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "BIT-CT"});
            this.course.Location = new System.Drawing.Point(265, 308);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(207, 21);
            this.course.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(30, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Academic Year";
            // 
            // StudentEnrollmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.course);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.yearlevel);
            this.Controls.Add(this.acadyear);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentEnrollmentPage";
            this.Size = new System.Drawing.Size(772, 800);
            this.Load += new System.EventHandler(this.StudentEnrollmentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox yearlevel;
        private System.Windows.Forms.ComboBox acadyear;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sem;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.Label label9;
    }
}
