namespace LMS
{
    partial class courselist
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
            this.enrolledcoursesgridview = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolledcoursesgroupbox = new System.Windows.Forms.GroupBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.secretlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledcoursesgridview)).BeginInit();
            this.enrolledcoursesgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrolledcoursesgridview
            // 
            this.enrolledcoursesgridview.AllowUserToAddRows = false;
            this.enrolledcoursesgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledcoursesgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.id,
            this.name,
            this.professor,
            this.grade});
            this.enrolledcoursesgridview.Location = new System.Drawing.Point(13, 19);
            this.enrolledcoursesgridview.Name = "enrolledcoursesgridview";
            this.enrolledcoursesgridview.Size = new System.Drawing.Size(568, 139);
            this.enrolledcoursesgridview.TabIndex = 0;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.Width = 75;
            // 
            // id
            // 
            this.id.FillWeight = 125F;
            this.id.HeaderText = "Course Number";
            this.id.Name = "id";
            this.id.Width = 50;
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
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Width = 50;
            // 
            // enrolledcoursesgroupbox
            // 
            this.enrolledcoursesgroupbox.Controls.Add(this.enrolledcoursesgridview);
            this.enrolledcoursesgroupbox.Location = new System.Drawing.Point(12, 12);
            this.enrolledcoursesgroupbox.Name = "enrolledcoursesgroupbox";
            this.enrolledcoursesgroupbox.Size = new System.Drawing.Size(595, 170);
            this.enrolledcoursesgroupbox.TabIndex = 1;
            this.enrolledcoursesgroupbox.TabStop = false;
            this.enrolledcoursesgroupbox.Text = "Enrolled Courses";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(451, 188);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(532, 188);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 3;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(9, 201);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 13);
            this.secretlabel.TabIndex = 4;
            this.secretlabel.Visible = false;
            // 
            // courselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 223);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.enrolledcoursesgroupbox);
            this.Name = "courselist";
            this.Text = "Current Courses";
            ((System.ComponentModel.ISupportInitialize)(this.enrolledcoursesgridview)).EndInit();
            this.enrolledcoursesgroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView enrolledcoursesgridview;
        private System.Windows.Forms.GroupBox enrolledcoursesgroupbox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label secretlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
    }
}