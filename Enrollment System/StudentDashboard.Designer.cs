
namespace Enrollment_System
{
    partial class StudentDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studentHomePage2 = new Enrollment_System.StudentHomePage();
            this.studentEnrollmentPage2 = new Enrollment_System.StudentEnrollmentPage();
            this.studentCORPage1 = new Enrollment_System.StudentCORPage();
            this.studentPIPage1 = new Enrollment_System.StudentPIPage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 761);
            this.panel1.TabIndex = 2;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.AliceBlue;
            this.user.Location = new System.Drawing.Point(12, 30);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 20);
            this.user.TabIndex = 10;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(34, 30);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(0, 13);
            this.admin.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.SteelBlue;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 231);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(273, 41);
            this.button9.TabIndex = 8;
            this.button9.Text = "         Logout";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SteelBlue;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "         Personal Information";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SteelBlue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "         View COR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SteelBlue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "         Enrollment";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "         Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentHomePage2
            // 
            this.studentHomePage2.Location = new System.Drawing.Point(279, 0);
            this.studentHomePage2.Name = "studentHomePage2";
            this.studentHomePage2.Size = new System.Drawing.Size(971, 761);
            this.studentHomePage2.TabIndex = 5;
            // 
            // studentEnrollmentPage2
            // 
            this.studentEnrollmentPage2.Location = new System.Drawing.Point(280, 0);
            this.studentEnrollmentPage2.Name = "studentEnrollmentPage2";
            this.studentEnrollmentPage2.Size = new System.Drawing.Size(978, 761);
            this.studentEnrollmentPage2.TabIndex = 4;
            this.studentEnrollmentPage2.username = null;
            // 
            // studentCORPage1
            // 
            this.studentCORPage1.Location = new System.Drawing.Point(280, 0);
            this.studentCORPage1.Name = "studentCORPage1";
            this.studentCORPage1.Size = new System.Drawing.Size(978, 735);
            this.studentCORPage1.TabIndex = 3;
            this.studentCORPage1.username = null;
            // 
            // studentPIPage1
            // 
            this.studentPIPage1.Location = new System.Drawing.Point(279, 0);
            this.studentPIPage1.Name = "studentPIPage1";
            this.studentPIPage1.Size = new System.Drawing.Size(979, 761);
            this.studentPIPage1.TabIndex = 6;
            this.studentPIPage1.username = null;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 761);
            this.Controls.Add(this.studentPIPage1);
            this.Controls.Add(this.studentHomePage2);
            this.Controls.Add(this.studentEnrollmentPage2);
            this.Controls.Add(this.studentCORPage1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private StudentCORPage studentCORPage1;
        private StudentEnrollmentPage studentEnrollmentPage2;
        private StudentHomePage studentHomePage2;
        private StudentPIPage studentPIPage1;
    }
}