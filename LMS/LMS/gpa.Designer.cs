﻿namespace LMS
{
    partial class gpa
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
            this.secretlabel = new System.Windows.Forms.Label();
            this.currentgradesgroupbox = new System.Windows.Forms.GroupBox();
            this.viewgradegridview = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.gpalabel = new System.Windows.Forms.Label();
            this.calculategpagroupbox = new System.Windows.Forms.GroupBox();
            this.gpalabel2 = new System.Windows.Forms.Label();
            this.currentgradesgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewgradegridview)).BeginInit();
            this.calculategpagroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(12, 290);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 13);
            this.secretlabel.TabIndex = 1;
            this.secretlabel.Visible = false;
            // 
            // currentgradesgroupbox
            // 
            this.currentgradesgroupbox.Controls.Add(this.viewgradegridview);
            this.currentgradesgroupbox.Location = new System.Drawing.Point(12, 12);
            this.currentgradesgroupbox.Name = "currentgradesgroupbox";
            this.currentgradesgroupbox.Size = new System.Drawing.Size(446, 160);
            this.currentgradesgroupbox.TabIndex = 2;
            this.currentgradesgroupbox.TabStop = false;
            this.currentgradesgroupbox.Text = "Current Grades";
            // 
            // viewgradegridview
            // 
            this.viewgradegridview.AllowUserToAddRows = false;
            this.viewgradegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewgradegridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.id,
            this.name,
            this.grade});
            this.viewgradegridview.Location = new System.Drawing.Point(21, 19);
            this.viewgradegridview.Name = "viewgradegridview";
            this.viewgradegridview.Size = new System.Drawing.Size(419, 126);
            this.viewgradegridview.TabIndex = 0;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.Width = 75;
            // 
            // id
            // 
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
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Width = 50;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(383, 215);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Logout";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(383, 186);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(172, 37);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.calculatebutton.TabIndex = 4;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // gpalabel
            // 
            this.gpalabel.AutoSize = true;
            this.gpalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpalabel.Location = new System.Drawing.Point(45, 18);
            this.gpalabel.Name = "gpalabel";
            this.gpalabel.Size = new System.Drawing.Size(92, 13);
            this.gpalabel.TabIndex = 5;
            this.gpalabel.Text = "Semester GPA:";
            // 
            // calculategpagroupbox
            // 
            this.calculategpagroupbox.Controls.Add(this.gpalabel2);
            this.calculategpagroupbox.Controls.Add(this.calculatebutton);
            this.calculategpagroupbox.Controls.Add(this.gpalabel);
            this.calculategpagroupbox.Location = new System.Drawing.Point(87, 178);
            this.calculategpagroupbox.Name = "calculategpagroupbox";
            this.calculategpagroupbox.Size = new System.Drawing.Size(265, 70);
            this.calculategpagroupbox.TabIndex = 6;
            this.calculategpagroupbox.TabStop = false;
            this.calculategpagroupbox.Text = "Calculate GPA";
            // 
            // gpalabel2
            // 
            this.gpalabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gpalabel2.Location = new System.Drawing.Point(48, 37);
            this.gpalabel2.Name = "gpalabel2";
            this.gpalabel2.Size = new System.Drawing.Size(89, 23);
            this.gpalabel2.TabIndex = 6;
            // 
            // gpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 256);
            this.Controls.Add(this.calculategpagroupbox);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.currentgradesgroupbox);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.exitbutton);
            this.Name = "gpa";
            this.Text = "GPA Calculator";
            this.currentgradesgroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewgradegridview)).EndInit();
            this.calculategpagroupbox.ResumeLayout(false);
            this.calculategpagroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label secretlabel;
        private System.Windows.Forms.GroupBox currentgradesgroupbox;
        private System.Windows.Forms.DataGridView viewgradegridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label gpalabel;
        private System.Windows.Forms.GroupBox calculategpagroupbox;
        private System.Windows.Forms.Label gpalabel2;
    }
}