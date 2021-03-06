﻿namespace LMS
{
    partial class administrator
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
            this.enrolledstudentsgroupbox = new System.Windows.Forms.GroupBox();
            this.enrolledstudentsgridview = new System.Windows.Forms.DataGridView();
            this.studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolledcoursesgroupbox = new System.Windows.Forms.GroupBox();
            this.enrolledcoursesgridview = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.errormessagelabel = new System.Windows.Forms.Label();
            this.enrolledstudentsgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledstudentsgridview)).BeginInit();
            this.enrolledcoursesgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledcoursesgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolledstudentsgroupbox
            // 
            this.enrolledstudentsgroupbox.Controls.Add(this.enrolledstudentsgridview);
            this.enrolledstudentsgroupbox.Location = new System.Drawing.Point(17, 26);
            this.enrolledstudentsgroupbox.Name = "enrolledstudentsgroupbox";
            this.enrolledstudentsgroupbox.Size = new System.Drawing.Size(882, 225);
            this.enrolledstudentsgroupbox.TabIndex = 0;
            this.enrolledstudentsgroupbox.TabStop = false;
            this.enrolledstudentsgroupbox.Text = "Enrolled Students";
            // 
            // enrolledstudentsgridview
            // 
            this.enrolledstudentsgridview.AllowUserToAddRows = false;
            this.enrolledstudentsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledstudentsgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentid,
            this.username,
            this.firstname,
            this.lastname,
            this.gender,
            this.dob,
            this.phonenumber,
            this.email});
            this.enrolledstudentsgridview.Location = new System.Drawing.Point(6, 19);
            this.enrolledstudentsgridview.Name = "enrolledstudentsgridview";
            this.enrolledstudentsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enrolledstudentsgridview.Size = new System.Drawing.Size(869, 195);
            this.enrolledstudentsgridview.TabIndex = 8;
            this.enrolledstudentsgridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enrolledstudentsgridview_MouseClick);
            // 
            // studentid
            // 
            this.studentid.HeaderText = "Student ID";
            this.studentid.Name = "studentid";
            this.studentid.Width = 75;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.Width = 75;
            // 
            // dob
            // 
            this.dob.HeaderText = "Date of Birth";
            this.dob.Name = "dob";
            this.dob.Width = 75;
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "Phone Number";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.Width = 175;
            // 
            // enrolledcoursesgroupbox
            // 
            this.enrolledcoursesgroupbox.Controls.Add(this.enrolledcoursesgridview);
            this.enrolledcoursesgroupbox.Location = new System.Drawing.Point(17, 257);
            this.enrolledcoursesgroupbox.Name = "enrolledcoursesgroupbox";
            this.enrolledcoursesgroupbox.Size = new System.Drawing.Size(882, 191);
            this.enrolledcoursesgroupbox.TabIndex = 2;
            this.enrolledcoursesgroupbox.TabStop = false;
            this.enrolledcoursesgroupbox.Text = "Enrolled Courses";
            // 
            // enrolledcoursesgridview
            // 
            this.enrolledcoursesgridview.AllowUserToAddRows = false;
            this.enrolledcoursesgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledcoursesgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.department,
            this.section,
            this.name,
            this.professor,
            this.timestart,
            this.timeend,
            this.grade});
            this.enrolledcoursesgridview.Location = new System.Drawing.Point(6, 19);
            this.enrolledcoursesgridview.Name = "enrolledcoursesgridview";
            this.enrolledcoursesgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enrolledcoursesgridview.Size = new System.Drawing.Size(869, 186);
            this.enrolledcoursesgridview.TabIndex = 1;
            // 
            // cID
            // 
            this.cID.FillWeight = 125F;
            this.cID.HeaderText = "Course Number";
            this.cID.Name = "cID";
            this.cID.Width = 50;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.Width = 75;
            // 
            // section
            // 
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // professor
            // 
            this.professor.HeaderText = "Professor";
            this.professor.Name = "professor";
            this.professor.Width = 150;
            // 
            // timestart
            // 
            this.timestart.HeaderText = "Start Time:";
            this.timestart.Name = "timestart";
            // 
            // timeend
            // 
            this.timeend.HeaderText = "End Time";
            this.timeend.Name = "timeend";
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Width = 50;
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(829, 468);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 3;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // errormessagelabel
            // 
            this.errormessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessagelabel.ForeColor = System.Drawing.Color.Red;
            this.errormessagelabel.Location = new System.Drawing.Point(14, 9);
            this.errormessagelabel.Name = "errormessagelabel";
            this.errormessagelabel.Size = new System.Drawing.Size(878, 14);
            this.errormessagelabel.TabIndex = 14;
            this.errormessagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 497);
            this.Controls.Add(this.errormessagelabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.enrolledcoursesgroupbox);
            this.Controls.Add(this.enrolledstudentsgroupbox);
            this.Name = "administrator";
            this.Text = "Administrator Mainscreen";
            this.enrolledstudentsgroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enrolledstudentsgridview)).EndInit();
            this.enrolledcoursesgroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enrolledcoursesgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enrolledstudentsgroupbox;
        private System.Windows.Forms.GroupBox enrolledcoursesgroupbox;
        private System.Windows.Forms.DataGridView enrolledcoursesgridview;
        private System.Windows.Forms.DataGridView enrolledstudentsgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestart;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeend;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Label errormessagelabel;
    }
}